using ProjectConProfile.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectConProfile
{
    public partial class Form1 : Form
    {
        public Projekt _projekt { get; set; }
        public Form1()
        {
            _projekt = new Projekt();
            InitializeComponent();
        }

        private void buttonNacitatData_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string vybranyPriecinok = dialog.SelectedPath;
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

                                if (startReading == false && line == "#DATA") //zacnem nacitavat data po tomto slove
                                    startReading = true;
                                if(excitacie.Count >= 600)
                                {
                                    ;
                                }

                            }
                            nacitataneExcitacie = true;
                            zoznamNacitanychDat.Add(new NacitaneData(spektrum, nacitaneData));

                        }


                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that may occur during the file reading process
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }

                _projekt._profily.Add(new KoncentracnyProfil(zoznamNacitanychDat, excitacie));

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
