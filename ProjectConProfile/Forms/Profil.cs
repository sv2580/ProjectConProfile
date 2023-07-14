using Newtonsoft.Json;
using ProjectConProfile.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace ProjectConProfile.Forms
{
    public partial class Profil : Form
    {
        private Aplikacia _form;
        private Projekt _projekt;
        private KoncentracnyProfil _zvolenyProfil;
        public const string SuborFaktorovSpektier = "faktory.txt";
        private List<ComboBox> _boxy = new List<ComboBox>();

        //
        private Panel _panel1;
        //



        MultimapDictionary _faktory;

        public Profil(Projekt projekt, int index, Panel panel1)
        {
            
            InitializeComponent();
            _form = new Aplikacia();
            _projekt = projekt;
            _zvolenyProfil = _projekt._profily[index];
            //
            _panel1 = panel1;
            //
            

            _faktory = new MultimapDictionary();
            populovatTree();

            dataGridNacitane.DataSource = populovatGrid(false);
            dataGridNacitane.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridNasobeneData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProfil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (_zvolenyProfil._nasobeneData != null && _zvolenyProfil._nasobeneData.Count > 0)
            {
                dataGridNasobeneData.DataSource = populovatGrid(true);
                profilGrid();
            }


            vytvoritGraf();
            nacitanieFaktorov(SuborFaktorovSpektier);
            vytvorComboboxy();

        }

        

        private void populovatTree()
        {
            treeViewPriecinky.BeginUpdate();

            for (int i = 0; i < _projekt._profily.Count; i++)
            {
                treeViewPriecinky.Nodes.Add(Path.GetFileName(_projekt._profily[i]._nazovPriecinku));
                for (int j = 0; j < _projekt._profily[i]._nacitaneData.Count; j++)
                {
                    treeViewPriecinky.Nodes[i].Nodes.Add(_projekt._profily[i]._nacitaneData[j]._nazovSuboru);
                }
            }

            treeViewPriecinky.EndUpdate();
        }

        private void pridajDoTreePriecinok(KoncentracnyProfil profil)
        {
            treeViewPriecinky.BeginUpdate();
            treeViewPriecinky.Nodes.Add(Path.GetFileName(profil._nazovPriecinku));
            foreach (NacitaneData data in profil._nacitaneData)
            {
                treeViewPriecinky.Nodes[_projekt._profily.Count - 1].Nodes.Add(data._nazovSuboru);
            }
            treeViewPriecinky.EndUpdate();
        }

        private void vytvorComboboxy()
        {
            int pocet = dataGridNacitane.ColumnCount;
            for (int i = 0; i < pocet; i++)
            {
                ComboBox comboBox = new ComboBox();
                int spektrum = _zvolenyProfil._nacitaneData[i]._spektrum;
                int rozmerX = dataGridNacitane.Width / pocet - 15;

                comboBox.Location = new Point(5 + dataGridNacitane.Location.X + dataGridNacitane.RowHeadersWidth
                                                + i * (rozmerX + 10),
                                                  dataGridNacitane.Location.Y - 25);
                comboBox.Size = new System.Drawing.Size(rozmerX, 21);
                comboBox.Name = "comboBox" + spektrum;
                buttonNasobit.Location = new Point(dataGridNacitane.Location.X + dataGridNacitane.Width,
                                                  dataGridNacitane.Location.Y - 25);

                List<double> hodnoty = _faktory.GetValue(spektrum);
                if (hodnoty != null && hodnoty.Count > 0)
                {
                    foreach (double value in hodnoty)
                    {
                        comboBox.Items.Add(value);
                    }
                    comboBox.SelectedIndex = 0;
                }
                this._boxy.Add(comboBox);
                this.Controls.Add(comboBox);

            }
        }

        private DataTable populovatGrid(bool nasobene)
        {
            List<List<double>> data = new List<List<double>>();

            if (!nasobene)
            {
                for (int i = 0; i < _zvolenyProfil._nacitaneData.Count; i++)
                {
                    data.Add(new List<double>(_zvolenyProfil._nacitaneData[i]._data));
                }
            }
            else
            {
                for (int i = 0; i < _zvolenyProfil._nacitaneData.Count; i++)
                {
                    data.Add(new List<double>(_zvolenyProfil._nasobeneData[i]._nasobeneData));
                }
            }

            DataTable dataTable = new DataTable();

            foreach (NacitaneData nacitane in _zvolenyProfil._nacitaneData)
            {
                dataTable.Columns.Add(nacitane._nazovSuboru);
            }

            for (int j = 0; j < _zvolenyProfil._nacitaneData[0]._data.Count; j++)
            {
                DataRow newRow = dataTable.NewRow();
                for (int i = 0; i < _zvolenyProfil._nacitaneData.Count; i++)
                {
                    newRow[_zvolenyProfil._nacitaneData[i]._nazovSuboru] = data[i][j];
                }
                dataTable.Rows.Add(newRow);
            }

            return dataTable;

        }
        private void profilGrid()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Excitácie");
            dataTable.Columns.Add("Maximá");

            for (int j = 0; j < _zvolenyProfil._profil.Count; j++)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["Excitácie"] = _zvolenyProfil._excitacia[j];
                newRow["Maximá"] = _zvolenyProfil._profil[j];
                dataTable.Rows.Add(newRow);
            }

            dataGridProfil.DataSource = dataTable;
        }

        private void vytvoritGraf()
        {
            chart1.Series.Clear();
            foreach (NacitaneData data in _zvolenyProfil._nacitaneData)
            {
                pridatDoGrafu(_zvolenyProfil._excitacia, data._data, data._spektrum.ToString());
            }
            if (_zvolenyProfil._profil.Count > 0)
                pridatDoGrafu(_zvolenyProfil._excitacia, _zvolenyProfil._profil, "Max");

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.Legends[0].Docking = Docking.Bottom;

        }
        private void pridatDoGrafu(List<double> x, List<double> y, string nazov)
        {
            Series series = new Series();
            series.ChartType = SeriesChartType.Point;

            for (int i = 0; i < x.Count; i++)
            {
                series.Points.AddXY(x[i], y[i]);
            }
            series.IsVisibleInLegend = true;
            series.LegendText = nazov;
            chart1.Series.Add(series);
            chart1.Series[chart1.Series.Count - 1].ChartType = SeriesChartType.Line;
        }
        private void Profil_Load(object sender, EventArgs e)
        {
            _panel1.Visible = true;
            _panel1.BringToFront();

        }
        private void treeViewPriecinky_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _zvolenyProfil = _projekt._profily.Find(p => Path.GetFileName(p._nazovPriecinku) == e.Node.Text);
            if (_zvolenyProfil != null)
            {
                dataGridNacitane.DataSource = populovatGrid(false);
                dataGridNacitane.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                vytvoritGraf();
                //foreach (ComboBox comboBox in this.Controls.OfType<ComboBox>())
                //{
                //    this.Controls.Remove(comboBox);
                //}
                foreach(ComboBox box in _boxy)
                {
                    this.Controls.Remove(box);
                }
                vytvorComboboxy();

                if (_zvolenyProfil._nasobeneData != null && _zvolenyProfil._nasobeneData.Count > 0)
                {
                    dataGridNasobeneData.DataSource = populovatGrid(true);
                    profilGrid();
                }
                else
                {
                    dataGridNasobeneData.DataSource = null;
                    dataGridProfil.DataSource = null;
                }
            }
            else
            {
                _zvolenyProfil = _projekt._profily[0];
            }
        }

        private void dataGridNacitane_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {

            var serializedProject = JsonConvert.SerializeObject(_projekt);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CPRJ files (*.cprj)|*.cprj";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, serializedProject);
                    MessageBox.Show("Projekt uložený");
                }
            }
        }

        private void pridatPriecinokButton_Click(object sender, EventArgs e)
        {
            KoncentracnyProfil nacitaneData = _form.nacitajData(_projekt);
            if (nacitaneData != null)
            {
                pridajDoTreePriecinok(_zvolenyProfil);
            }
        }

      

        private void buttonPorovnat_Click(object sender, EventArgs e)
        {
            Porovnanie porovnanie = new Porovnanie(_projekt);
            porovnanie.Show();
            
        }


        private void nacitanieFaktorov(string subor)
        {
            //nacitanie spektier z textaku
            using (StreamReader reader = new StreamReader(subor)) //na prvom mieste spektrum na druhom faktor
            {
                string line;
                int row = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    int spektrum = -1;
                    double faktor = -1;
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        if (int.TryParse(words[0].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out int key))
                        {
                            spektrum = key;
                        }

                        if (double.TryParse(words[1].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                        {
                            faktor = value;
                            row++;
                        }
                        if (spektrum != -1 && faktor != -1)
                            _faktory.AddValue(spektrum, faktor);
                    }
                }
            }
            ;
        }

        private void buttonNasobit_Click(object sender, EventArgs e)
        {
            List<double> faktory = new List<double>();
            for (int i = 0; i < dataGridNacitane.Columns.Count; i++)
            {
                int spektrum = _zvolenyProfil._nacitaneData[i]._spektrum;
                double zvolenyFaktor = -1;
                ComboBox combobox = this.Controls["comboBox" + spektrum] as ComboBox;
                if (combobox.SelectedIndex == -1)
                {

                    if (combobox.Text != "" && double.TryParse(combobox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double faktor))
                    {
                        using (StreamWriter writer = new StreamWriter("faktory.txt", true))
                        {
                            writer.WriteLine(spektrum + " " + faktor + "\n");
                        }
                        zvolenyFaktor = faktor;
                    }
                    else
                    {
                        MessageBox.Show("Chybne zadané hodnoty");
                        return;
                    }

                }
                else
                {
                    zvolenyFaktor = _faktory.GetValue(spektrum)[combobox.SelectedIndex];
                }
                faktory.Add(zvolenyFaktor);
            }
            _zvolenyProfil._nasobeneData = new List<NasobeneData>();

            for (int i = 0; i < _zvolenyProfil._nacitaneData.Count; i++)
            {
                NasobeneData data = new NasobeneData(faktory[i]);
                _zvolenyProfil._nasobeneData.Add(data);
                _zvolenyProfil._nasobeneData[i].nasobData(_zvolenyProfil._nacitaneData[i]);
            }

            dataGridNasobeneData.DataSource = populovatGrid(true);

            if (_zvolenyProfil._profil.Count > 0)
            {
                _zvolenyProfil._profil = new List<double>();
                chart1.Series[chart1.Series.Count - 1].Points.Clear();
                chart1.Series.RemoveAt(chart1.Series.Count - 1);
            }

            _zvolenyProfil.vytvoritProfil();
            profilGrid();
            pridatDoGrafu(_zvolenyProfil._excitacia, _zvolenyProfil._profil, "Max");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridProfil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Min_Click(object sender, EventArgs e)
        {

        }

    }
}

