using ProjectConProfile.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace ProjectConProfile
{
    public partial class Form1 : Form
    {
        public Projekt _projekt { get; set; }
        public KoncentracnyProfil _zvolenyProfil { get; set; } //dat do druheho formu aj s treeview aj vsetkym
        public Form1()
        {
            _projekt = new Projekt();
            _zvolenyProfil = null;
            InitializeComponent();
        }

        private void buttonNacitatData_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string vybranyPriecinok = dialog.SelectedPath;
                
                if(_projekt._profily.Exists(p => p._nazovPriecinku == vybranyPriecinok))
                {
                    MessageBox.Show($"Priečinok je už v tomto projekte otvorený: {Path.GetFileName(vybranyPriecinok)}");
                    return;
                }

                string[] vsetkySubory = Directory.GetFiles(vybranyPriecinok, "*.sp");

                bool nacitataneExcitacie = false;
                List<NacitaneData> zoznamNacitanychDat = new List<NacitaneData>();
                List<double> excitacie = new List<double>();


                foreach (string subor in vsetkySubory)
                {
                    List<double> nacitaneData = new List<double>();
                    int spektrum = -1;

                    string pattern = @"(?<=m)\d+(?=\.)"; //cisla co su po m a pred . 
                    Match typeOfData = Regex.Match(Path.GetFileName(subor), pattern); //chcem extrahovat cislo suboru ako su 0,2 atd pred .sp
                    if (int.TryParse(typeOfData.Value, NumberStyles.Float, CultureInfo.InvariantCulture, out int resultType))
                    {
                        spektrum = resultType;
                    }

                    try
                    {
                        using (StreamReader reader = new StreamReader(subor))
                        {
                            string line;
                            bool startReading = false;
                            int row = 0;
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (startReading && !string.IsNullOrWhiteSpace(line))
                                {
                                    string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries); //rozdelenie slov v riadku
                                    if (nacitataneExcitacie == false && double.TryParse(words[0].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out double x))
                                    {
                                        excitacie.Add(x);
                                    }

                                    if (double.TryParse(words[1].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out double result)) //skusam slovo dat na double
                                    {
                                        nacitaneData.Add(result);
                                        row++;
                                    }
                                }

                                if (startReading == false && line == "#DATA") 
                                    startReading = true;

                            }
                            nacitataneExcitacie = true;
                            zoznamNacitanychDat.Add(new NacitaneData(spektrum, nacitaneData, Path.GetFileName(subor)));

                        }

                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that may occur during the file reading process
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
                zoznamNacitanychDat = zoznamNacitanychDat.OrderBy(data => data._spektrum).ToList();
                KoncentracnyProfil profil = new KoncentracnyProfil(zoznamNacitanychDat, excitacie, vybranyPriecinok);
                _projekt._profily.Add(profil);
                pridajDoTreePriecinok(profil);
                pridatPriecinokButton.Visible = true;
                pridatPriecinokButton.Enabled = true;
                _zvolenyProfil = profil;
                dataGridNacitane.DataSource = populovatGrid(_zvolenyProfil);
                dataGridNacitane.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                vytvorComboboxy();
            }
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

        private DataTable populovatGrid(KoncentracnyProfil profil)
        {

            DataTable dataTable = new DataTable();

            foreach (NacitaneData data in profil._nacitaneData)
            {
                dataTable.Columns.Add(data._nazovSuboru);

            }


            for (int j = 0; j < profil._nacitaneData[0]._data.Count; j++)
            {
                DataRow newRow = dataTable.NewRow();

                foreach (NacitaneData data in profil._nacitaneData)
                {
                    newRow[data._nazovSuboru] = data._data[j];
                }

                dataTable.Rows.Add(newRow);
            }

            return dataTable;

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeViewPriecinky_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //zmenit zobrazovany profil 
            _zvolenyProfil = _projekt._profily.Find(p => Path.GetFileName(p._nazovPriecinku) == e.Node.Text);
            dataGridNacitane.DataSource = populovatGrid(_zvolenyProfil);
            dataGridNacitane.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }

        private void pridatPriecinokButton_Click(object sender, EventArgs e)
        {
            buttonNacitatData_Click(sender, e);
        }

        private void vytvorComboboxy()
        {
            int pocet = dataGridNacitane.ColumnCount;
            for (int i = 0; i < pocet; i++)
            {
                //this.comboBox1.FormattingEnabled = true;
                //this.comboBox1.Location = new System.Drawing.Point(321, 68);
                //this.comboBox1.Name = "comboBox1";
                //this.comboBox1.Size = new System.Drawing.Size(78, 21);
                //this.comboBox1.TabIndex = 5;
                //this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);

                ComboBox comboBox = new ComboBox();
                int rozmerX = dataGridNacitane.Columns[0].Width - 10;
                comboBox.Location = new Point(5 + dataGridNacitane.Location.X + dataGridNacitane.RowHeadersWidth + i * (rozmerX + 10),
                                                  dataGridNacitane.Location.Y - 25) ; 
                comboBox.Size = new System.Drawing.Size(rozmerX, 21);
                comboBox.Name = "comboBox" + i;
               // comboBox. += ComboBoxChanged;

                this.Controls.Add(comboBox);
            }
        }

        //private void ComboBoxChanged(object sender, EventArgs e)
        //{
        //    ComboBox comboBox = (ComboBox)sender; 
        //    string vybranaHodnota = comboBox.SelectedItem.ToString();
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonNasobitData_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < dataGridNacitane.Rows.Count;i++)
            {
                ComboBox hodnota = this.Controls["comboBox"+i] as ComboBox;
            }
        }


    }
}
