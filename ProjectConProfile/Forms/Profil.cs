﻿using Newtonsoft.Json;
using ProjectConProfile.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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
        public string SuborFaktorovSpektier;
        private List<ComboBox> _boxy = new List<ComboBox>();
        //pridane Ninka - uchovavanie povodných dát niekde
        private List<NacitaneData> povodneData;
        private NastaveniaSuborov _nastavenia;
        //
        private Panel _panel1;
        string priruckaPath;
        //



        MultimapDictionary _faktory;

        public Profil(Projekt projekt, int index, Panel panel1, NastaveniaSuborov nastavenia)
        {

            InitializeComponent();
            _form = new Aplikacia();
            _projekt = projekt;
            _zvolenyProfil = _projekt._profily[index];
            //
            _panel1 = panel1;
            _nastavenia = nastavenia;

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

            if (_nastavenia.cestaKSuboruFakt == null)
                _nastavenia.cestaKSuboruFakt = "factors.txt";
            nacitanieFaktorov(_nastavenia.cestaKSuboruFakt);
            vytvorComboboxy();
            check_prirucka();
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
                comboBox.Name = "comboBox" + i;
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
            List<List<string>> data = new List<List<string>>();
            // string[][] data = new string[_zvolenyProfil._nacitaneData.Count][];

            if (!nasobene)
            {
                for (int i = 0; i < _zvolenyProfil._nacitaneData.Count; i++)
                {
                    List<string> pom = new List<string>();
                    for (int j = 0; j < _zvolenyProfil._excitacia.Count; j++)
                    {

                        if (_zvolenyProfil._nacitaneData[i]._data[j].HasValue)
                            pom.Add(_zvolenyProfil._nacitaneData[i]._data[j].ToString());
                        else
                            pom.Add("-");

                    }

                    data.Add(pom);
                }
            }
            else
            {
                for (int i = 0; i < _zvolenyProfil._nacitaneData.Count; i++)
                {
                    List<string> pom = new List<string>();
                    for (int j = 0; j < _zvolenyProfil._excitacia.Count; j++)
                    {
                        if (_zvolenyProfil._nasobeneData[i]._nasobeneData[j].HasValue)
                            pom.Add(_zvolenyProfil._nasobeneData[i]._nasobeneData[j].ToString());
                        else
                            pom.Add("-");
                    }

                    data.Add(pom);
                }
            }

            DataTable dataTable = new DataTable();

            foreach (NacitaneData nacitane in _zvolenyProfil._nacitaneData)
            {
                dataTable.Columns.Add(nacitane._nazovSuboru);
            }

            for (int j = 0; j < _zvolenyProfil._nacitaneData[0]._data.Length; j++)
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

            for (int j = 0; j < _zvolenyProfil._profil.Length; j++)
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
            if (_zvolenyProfil._profil != null &&_zvolenyProfil._profil.Length > 0)
            {
                double?[] list = _zvolenyProfil._profil.Select(x => (double?)x).ToArray();
                pridatDoGrafu(_zvolenyProfil._excitacia, list, "Max");

            }

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.Legends[0].Docking = Docking.Bottom;

        }
        private void pridatDoGrafu(List<double> x, double?[] y, string nazov)
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
                foreach (ComboBox box in _boxy)
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            var serializedProject = JsonConvert.SerializeObject(_projekt);
            if (_nastavenia.cestaNaUkladanie != null)
                saveFileDialog.InitialDirectory = _nastavenia.cestaNaUkladanie;


            using (saveFileDialog)
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
                pridajDoTreePriecinok(nacitaneData);
            }
        }

        private void buttonPorovnat_Click(object sender, EventArgs e)
        {
            int profilyNaPorovnanie = 0;


            foreach (KoncentracnyProfil profil in _projekt._profily)
            {
                if (profil._profil != null && profil._profil.Length > 0)
                    profilyNaPorovnanie++;
                if (profilyNaPorovnanie == 2)
                    break;
            }

            if (profilyNaPorovnanie < 2)
            {
                MessageBox.Show("Pre porovnanie je potrebné mať vytvorené najmenej dva koncentračné profily.");
            }
            else
            {
                Porovnanie porovnanie = new Porovnanie(_projekt);
                porovnanie.Show();
            }



        }

        private void nacitanieFaktorov(string subor)
        {
            //nacitanie spektier z textaku

            if (File.Exists(_nastavenia.cestaKSuboruFakt))
            {
                using (StreamReader reader = new StreamReader(_nastavenia.cestaKSuboruFakt)) //na prvom mieste spektrum na druhom faktor
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
            else // nemalo by sa stat kedze sa vytvara v appdata ale preistotu 
            {
                DialogResult result = MessageBox.Show("Súbor s faktormi nenájdený. Chcete teraz vytvoriť prázdny súbor kde sa budú faktory ukladať? ", "Vytvoriť", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // načítanie dialogu kde sa nastaví tento prádzny súbor

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    saveFileDialog.Filter = "(*.txt)|*.txt";
                    saveFileDialog.Title = "Vyberte umiestnenie pre vytvorený súbor";
                    saveFileDialog.FileName = "factors.txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Vytvorenie prázdneho súboru
                        try
                        {
                            File.Create(filePath).Close();
                            MessageBox.Show("Prázdny súbor bol vytvorený, nastavenia uložené.", "Informácia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _nastavenia.cestaKSuboruFakt = filePath;

                            string[] lines = {
                                "0 1",
                                "2 1.4",
                                "8 2.2",
                                "32 3.6",
                                "128 5",
                                "512 1"
                            };

                            File.WriteAllLines(filePath, lines);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Chyba pri vytváraní súboru: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


                else if (result == DialogResult.No)
                {
                    // zavretie všetkého vrátenie na hlavnú stranu
                }
            }
        }

        private void buttonNasobit_Click(object sender, EventArgs e)
        {
            povodneData = new List<NacitaneData>(_zvolenyProfil._nacitaneData);
            List<double> faktory = new List<double>();
            for (int i = 0; i < dataGridNacitane.Columns.Count; i++)
            {
                int spektrum = _zvolenyProfil._nacitaneData[i]._spektrum;
                double zvolenyFaktor = -1;
                ComboBox combobox = this.Controls["comboBox" + i] as ComboBox;
                if (combobox.SelectedIndex == -1)
                {
                    if (combobox.Text != "" && double.TryParse(combobox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double faktor))
                    {
                        using (StreamWriter writer = new StreamWriter(_nastavenia.cestaKSuboruFakt, true))
                        {
                            if (spektrum != -1 && faktor != -1 && !_faktory.GetValue(spektrum).Contains(faktor))
                            {
                                writer.WriteLine(spektrum + " " + faktor);
                                combobox.Items.Add(faktor);
                                _faktory.AddValue(spektrum,faktor);
                            }
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

            if (_zvolenyProfil._profil != null && _zvolenyProfil._profil.Length > 0)
            {
                _zvolenyProfil._profil = new double[_zvolenyProfil._excitacia.Count];
                chart1.Series[chart1.Series.Count - 1].Points.Clear();
                chart1.Series.RemoveAt(chart1.Series.Count - 1);
            }

            _zvolenyProfil.vytvoritProfil();
            profilGrid();
            double?[] list = _zvolenyProfil._profil.Select(x => (double?)x).ToArray();

            pridatDoGrafu(_zvolenyProfil._excitacia, list, "Max");
            buttonExport.Visible = true;
            buttonExportPicture.Visible = true;

            //SABKA
            double maxValue = FindMaxValueInDataGridNacitane();
            double minValue = FindMinValueInDataGridNacitane();
            double standardDeviation = CalculateStandardDeviation();
            double maxValueN = FindMaxValueInDataGridNasobene();
            double minValueN = FindMinValueInDataGridNasobene();
            double standardDeviationN = CalculateStandardDeviationNasobene();

            textBox1.Text = maxValue.ToString();
            textBox2.Text = minValue.ToString();
            textBox3.Text = standardDeviation.ToString();
            textBox6.Text = maxValueN.ToString();
            textBox5.Text = minValueN.ToString();
            textBox4.Text = standardDeviationN.ToString();

            //_zvolenyProfil._maxValue = maxValue;
            //_zvolenyProfil._minValue = minValue;
            // _zvolenyProfil._standardDeviation = standardDeviation;
            _zvolenyProfil._maxValueN = maxValueN;
            _zvolenyProfil._minValueN = minValueN;
            _zvolenyProfil._standardDeviationN = standardDeviationN;


            // string fileName =  ".txt";

            // Call the function to save variables to a text file
            //SaveStatsToFile(fileName, maxValue, minValue, standardDeviation, maxValueN, minValueN, standardDeviationN);

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

        private void ExportDataGridsToCSV(DataGridView dataGridView1, DataGridView dataGridView2, DataGridView dataGridView3)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV súbory (*.csv)|*.csv";
            saveFileDialog.Title = "Vyberte umiestnenie pre exportovaný CSV súbor";
            if (_nastavenia.cestaNaUkladanie != null)
                saveFileDialog.InitialDirectory = _nastavenia.cestaNaUkladanie;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    // Export hlavičky tabuľky 1 (dataGridNasobeneData)
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        writer.Write(column.HeaderText + ";");
                    }
                    writer.Write(";"); // Prázdny stĺpec

                    // Export hlavičky tabuľky 2 (dataGridNasobeneData)
                    foreach (DataGridViewColumn column in dataGridView2.Columns)
                    {
                        writer.Write(column.HeaderText + ";");
                    }
                    writer.Write(";"); // Prázdny stĺpec

                    // Export hlavičky tabuľky 3 (dataGridProfil)
                    foreach (DataGridViewColumn column in dataGridView3.Columns)
                    {
                        writer.Write(column.HeaderText + ";");
                    }
                    writer.WriteLine();

                    //export dat

                    int maxRowCount = Math.Max(dataGridView1.Rows.Count, Math.Max(dataGridView2.Rows.Count, dataGridView3.Rows.Count));

                    for (int i = 0; i < maxRowCount; i++)
                    {
                        if (i < dataGridView1.Rows.Count)
                        {
                            foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                            {
                                writer.Write(cell.Value + ";");
                            }
                        }
                        writer.Write(";"); // Prázdny stĺpec

                        if (i < dataGridView1.Rows.Count)
                        {
                            foreach (DataGridViewCell cell in dataGridView2.Rows[i].Cells)
                            {
                                writer.Write(cell.Value + ";");
                            }
                        }
                        writer.Write(";"); // Prázdny stĺpec

                        if (i < dataGridView2.Rows.Count)
                        {
                            foreach (DataGridViewCell cell in dataGridView3.Rows[i].Cells)
                            {
                                writer.Write(cell.Value + ";");
                            }
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Dáta boli úspešne exportované do súboru " + saveFileDialog.FileName + ".");
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            ExportDataGridsToCSV(dataGridNacitane, dataGridNasobeneData, dataGridProfil);
        }

        private void ExportChartAsImage()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Obrázky (*.png)|*.png";
            saveFileDialog.Title = "Vyberte umiestnenie pre exportovaný obrázok";
            if (_nastavenia.cestaNaUkladanie != null)
                saveFileDialog.InitialDirectory = _nastavenia.cestaNaUkladanie;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Vytvorenie snímku grafu
                Bitmap chartImage = new Bitmap(chart1.Width, chart1.Height);
                chart1.DrawToBitmap(chartImage, new Rectangle(0, 0, chart1.Width, chart1.Height));

                // Uloženie snímku ako obrázka
                chartImage.Save(saveFileDialog.FileName, ImageFormat.Png);

                MessageBox.Show("Obrázok bol úspešne exportovaný do súboru " + saveFileDialog.FileName + ".");
            }
        }

        private void buttonExportPicture_Click(object sender, EventArgs e)
        {
            ExportChartAsImage();
        }

        private double FindMaxValueInDataGridNacitane()
        {
            double maxValue = double.MinValue;

            // Loop through the rows in the DataGridView
            foreach (DataGridViewRow row in dataGridNacitane.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (double.TryParse(cell.Value.ToString(), out double cellValue))
                        {
                            if (cellValue > maxValue)
                            {
                                maxValue = cellValue;
                            }
                        }
                    }
                }
            }

            return maxValue;
        }

        private double FindMaxValueInDataGridNasobene()
        {
            double maxValueN = double.MinValue;

            // Loop through the rows in the DataGridView
            foreach (DataGridViewRow row in dataGridNasobeneData.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (double.TryParse(cell.Value.ToString(), out double cellValue))
                        {
                            if (cellValue > maxValueN)
                            {
                                maxValueN = cellValue;
                            }
                        }
                    }
                }
            }

            return maxValueN;
        }

        private double FindMinValueInDataGridNacitane()
        {
            double minValue = double.MaxValue;

            // Loop through the rows in the DataGridView
            foreach (DataGridViewRow row in dataGridNacitane.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (double.TryParse(cell.Value.ToString(), out double cellValue))
                        {
                            if (cellValue < minValue)
                            {
                                minValue = cellValue;
                            }
                        }
                    }
                }
            }

            return minValue;
        }

        private double FindMinValueInDataGridNasobene()
        {
            double minValueN = double.MaxValue;

            // Loop through the rows in the DataGridView
            foreach (DataGridViewRow row in dataGridNasobeneData.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (double.TryParse(cell.Value.ToString(), out double cellValue))
                        {
                            if (cellValue < minValueN)
                            {
                                minValueN = cellValue;
                            }
                        }
                    }
                }
            }

            return minValueN;
        }

        private double CalculateStandardDeviation()
        {
            List<double> values = new List<double>();

            // Loop through the rows in the DataGridView
            foreach (DataGridViewRow row in dataGridNacitane.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (double.TryParse(cell.Value.ToString(), out double cellValue))
                        {
                            values.Add(cellValue);
                        }
                    }
                }
            }

            // Calculate standard deviation using LINQ
            double mean = values.Average();
            double sumOfSquaredDifferences = values.Sum(value => Math.Pow(value - mean, 2));
            double standardDeviation = Math.Sqrt(sumOfSquaredDifferences / values.Count);

            return standardDeviation;
        }

        private double CalculateStandardDeviationNasobene()
        {
            List<double> values = new List<double>();

            // Loop through the rows in the DataGridView
            foreach (DataGridViewRow row in dataGridNasobeneData.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (double.TryParse(cell.Value.ToString(), out double cellValue))
                        {
                            values.Add(cellValue);
                        }
                    }
                }
            }

            // Calculate standard deviation using LINQ
            double meanN = values.Average();
            double sumOfSquaredDifferencesN = values.Sum(value => Math.Pow(value - meanN, 2));
            double standardDeviationN = Math.Sqrt(sumOfSquaredDifferencesN / values.Count);

            return standardDeviationN;
        }

        private void SaveStatsToFile(string filePath, params object[] variables)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (object variable in variables)
                    {
                        writer.WriteLine(variable.ToString());
                    }
                }
                //Console.WriteLine("Variables saved successfully to: " + filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while saving variables: " + ex.Message);
            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void check_prirucka()
        {
            // Specify the PDF file name without the path
            string pdfFileName = "Deploy/prirucka.pdf";
            string startupPath = Application.StartupPath;

            string targetPath = startupPath;
            for (int i = 0; i < 2; i++)
            {
                targetPath = Path.GetDirectoryName(targetPath);
                if (targetPath == null)

                {
                    helpbttn.Hide();
                    //MessageBox.Show("Unable to navigate back 2 directories from the startup path.", "Error");
                    return;
                }
            }

            // Combine the known directory and the provided file name
            string pdfFilePath = Path.Combine(targetPath, pdfFileName);



            // Check if the file exists before attempting to open it
            if (File.Exists(pdfFilePath))
            {
                // Open the PDF file using the default PDF viewer
                priruckaPath = pdfFilePath;
            }
            else
            {

                helpbttn.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Process.Start(priruckaPath);
        }
    }
}

