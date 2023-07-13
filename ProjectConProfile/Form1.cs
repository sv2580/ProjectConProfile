using Newtonsoft.Json;
using ProjectConProfile.Forms;
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
    public partial class Aplikacia : Form
    {
        public Projekt _projekt { get; set; }
        private Profil _profilForm;
        public KoncentracnyProfil _zvolenyProfil { get; set; } //dat do druheho formu aj s treeview aj vsetkym
        private bool isFullscreen = false;

        public Aplikacia()
        {
            _zvolenyProfil = null;
            InitializeComponent();          
        }

     
        private void buttonNacitatData_Click(object sender, EventArgs e)
        {
            _projekt = new Projekt();
            _zvolenyProfil = nacitajData(_projekt);
            if(_zvolenyProfil != null)
               otvorProfilForm();
        }

        public  KoncentracnyProfil nacitajData(Projekt projekt)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string vybranyPriecinok = dialog.SelectedPath;

                if (projekt._profily.Exists(p => p._nazovPriecinku == vybranyPriecinok))
                {
                    MessageBox.Show($"Priečinok je už v tomto projekte otvorený: {Path.GetFileName(vybranyPriecinok)}");
                    return null;
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

                                if (startReading == false && line == "#DATA") //zacnem nacitavat data po tomto slove
                                    startReading = true;

                            }
                            nacitataneExcitacie = true;
                            zoznamNacitanychDat.Add(new NacitaneData(spektrum, nacitaneData, Path.GetFileName(subor)));

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Pri načítaní súboru došlo k chybe: {ex}");
                    }
                }

                zoznamNacitanychDat = zoznamNacitanychDat.OrderBy(data => data._spektrum).ToList();
                KoncentracnyProfil profil = new KoncentracnyProfil(zoznamNacitanychDat, excitacie, vybranyPriecinok);
                projekt._profily.Add(profil);
                return profil;
            }
            return null;
        }



        private void buttonNacitatProjekt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CPRJ files (*.cprj)|*.cprj";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string projectData = File.ReadAllText(openFileDialog.FileName);
                    _projekt = JsonConvert.DeserializeObject<Projekt>(projectData);
                    _projekt._nazovProjektu = Path.GetFileName(openFileDialog.FileName);
                }
            }

            otvorProfilForm();
        }

        private void otvorProfilForm()
        {
            if (_profilForm == null)
            {
                _profilForm = new Profil(_projekt,0);
                _profilForm.TopLevel = false;
                panel.Controls.Add(_profilForm);
                _profilForm.ControlBox = false;
                _profilForm.MinimumSize = _profilForm.MaximumSize = _profilForm.Size;
                _profilForm.FormBorderStyle = FormBorderStyle.None;
                _profilForm.Dock = DockStyle.Fill;
                this.panel.Controls.Add(_profilForm);
                this.panel.Tag = _profilForm;
                _profilForm.BringToFront();
                _profilForm.Show();
                buttonSpat.BringToFront();
                buttonSpat.Visible = true;
                //label1.SendToBack();
                label1.Visible = false;
                this.panel1.Size = new System.Drawing.Size(1707, 40);

                _profilForm.LocationChanged += (sender, e) => {
                    _profilForm.Location = new Point(0, 0);
                };

                buttonMinimalizuj.BringToFront();
                buttonMinimalizuj.Visible = true;
                buttonZrus.BringToFront();
                buttonZrus.Visible = true;
                buttonZvacsi.BringToFront();
                buttonZvacsi.Visible = true;
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUlozitProjekt_Click(object sender, EventArgs e)
        {

        }

        private void buttonSpat_Click(object sender, EventArgs e)
        {
            if (_profilForm != null)
            {
                _profilForm.SendToBack();
                panel.Controls.Remove(_profilForm);
                _profilForm = null;
                buttonSpat.Visible = false;
                panel1.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
            
        }

        private void buttonZrus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZvacsi_Click(object sender, EventArgs e)
        {

            if (isFullscreen)
            {
                // Ak je obrazovka v režime na celú obrazovku, vráťte ju do určitej veľkosti
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                isFullscreen = false;
            }
            else
            {
                // Ak je obrazovka v normálnom režime, zmeňte ju na celú obrazovku
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                isFullscreen = true;
            }
        }

        private void buttonMinimalizuj_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
