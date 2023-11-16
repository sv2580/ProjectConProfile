using Newtonsoft.Json;
using ProjectConProfile.Forms;
using ProjectConProfile.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
        private NastaveniaSuborov _nastavenia;
        public KoncentracnyProfil _zvolenyProfil { get; set; } //dat do druheho formu aj s treeview aj vsetkym


        private bool isFullscreen = false;
        private bool isDragging = false;
        private Point startPoint;

        public Aplikacia()
        {
            _zvolenyProfil = null;
            InitializeComponent();
            //pohyb okna poocou panel1
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.MouseDown += Panel1_MouseDown;
            panel1.MouseMove += Panel1_MouseMove;
            panel1.MouseUp += Panel1_MouseUp;
            _nastavenia = new NastaveniaSuborov();
            //


            this.Load += Aplikacia_Load;


            //
        }


        //rozpoznanie na ktorej obrazovke sa ma appka otvorit
        private void Aplikacia_Load(object sender, EventArgs e)
        {
            // Získame všetky monitory
            Screen[] screens = Screen.AllScreens;

            // Nájdeme monitor, ktorý obsahuje väčšiu časť okna Visual Studio
            foreach (Screen screen in screens)
            {
                if (screen.Bounds.Contains(this.Location))
                {
                    // Nastavíme polohu na pracovnú oblasť tohto monitora
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = screen.WorkingArea.Location;
                    this.WindowState = FormWindowState.Maximized;
                    break;
                }
            }
        }



        //pohyb okna poocou panel1
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && e.Button == MouseButtons.Left)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        //



        private void buttonNacitatData_Click(object sender, EventArgs e)
        {
            _projekt = new Projekt();
            _zvolenyProfil = nacitajData(_projekt);
            if (_zvolenyProfil != null)
                otvorProfilForm();
        }

        public KoncentracnyProfil nacitajData(Projekt projekt)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (_nastavenia.cestaKDatam != null)
                dialog.SelectedPath = _nastavenia.cestaKDatam;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string vybranyPriecinok = dialog.SelectedPath;

                if (projekt._profily.Exists(p => p._nazovPriecinku == vybranyPriecinok))
                {
                    MessageBox.Show($"Priečinok je už v tomto projekte otvorený: {Path.GetFileName(vybranyPriecinok)}");
                    return null;
                }

                string[] vsetkySubory = Directory.GetFiles(vybranyPriecinok, "*.sp");
                if (vsetkySubory.Length == 0)
                {
                    MessageBox.Show($"Vo vybranom priečinku sa nenachádzajú súbory .sp");
                    return null;
                }

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
                    otvorProfilForm();
                    return;
                }
            }

            MessageBox.Show("Pri načítaní došlo k chybe.");

        }

        private void otvorProfilForm()
        {
            if (_profilForm == null)
            {
                
                _profilForm = new Profil(_projekt, 0, panel1, _nastavenia);
                _profilForm.TopLevel = false;
                panel.Controls.Add(_profilForm);
                _profilForm.ControlBox = false;
                // _profilForm.MinimumSize = _profilForm.MaximumSize = _profilForm.Size;
                //
                _profilForm.MinimumSize = _profilForm.MaximumSize = this.panel.Size;
                //
                _profilForm.FormBorderStyle = FormBorderStyle.None;
                _profilForm.Dock = DockStyle.Fill;
                this.panel.Controls.Add(_profilForm);
                this.panel.Tag = _profilForm;

                //

                if (isFullscreen)
                {
                    if (_profilForm != null)
                    {
                        _profilForm.WindowState = FormWindowState.Maximized;
                    }

                    panel1.BringToFront(); // Zobraziť panel nad formulárom Profil
                    buttonSpat.BringToFront();
                }
                //



                _profilForm.BringToFront();
                _profilForm.Show();
                buttonSpat.BringToFront();
                buttonSpat.Visible = true;
                //label1.SendToBack();
                label1.Visible = false;
                this.panel1.Size = new System.Drawing.Size(1707, 50);

                _profilForm.LocationChanged += (sender, e) => {
                    _profilForm.Location = new Point(0, 0);
                };


         

                buttonMinimalizuj.BringToFront();
                buttonMinimalizuj.Visible = true;
                buttonZrus.BringToFront();
                buttonZrus.Visible = true;
                //buttonZvacsi.BringToFront();
                //buttonZvacsi.Visible = true;
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

        /*private void buttonZvacsi_Click(object sender, EventArgs e)
        {

            if (isFullscreen)
            {
                // Ak je obrazovka v režime na celú obrazovku, vráťte ju do určitej veľkosti
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                isFullscreen = false;

                if (_profilForm != null)
                {
                    _profilForm.WindowState = FormWindowState.Normal;
                    _profilForm.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
                }

                panel1.BringToFront(); // Zobraziť panel nad formulárom Profil
                buttonSpat.BringToFront();
            }
            else
            {
                // Ak je obrazovka v normálnom režime, zmeňte ju na celú obrazovku
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                isFullscreen = true;

                if (_profilForm != null)
                {
                   _profilForm.WindowState = FormWindowState.Maximized;
                }
                panel1.BringToFront();
                buttonSpat.BringToFront();
            }

            // Aktualizovať stav premennej isFullscreen
            isFullscreen = (this.WindowState == FormWindowState.Maximized && this.FormBorderStyle == FormBorderStyle.None);



        }*/

        private void buttonMinimalizuj_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonNastavenia_Click(object sender, EventArgs e)
        {
            // Nastavenia nastaveniaForm = new Nastavenia(_nastavenia);
            //nastaveniaForm.Show();



            // Získa aktuálnu obrazovku, na ktorej je aplikácia spustená.
            Screen currentScreen = Screen.FromControl(this);

            // Vytvorí nové okno s nastaveniami.
            Nastavenia nastaveniaForm = new Nastavenia(_nastavenia);

            // Nastaví stred obrazovky ako polohu okna s nastaveniami.
            nastaveniaForm.StartPosition = FormStartPosition.Manual;
            nastaveniaForm.Location = new Point(
                currentScreen.Bounds.Left + (currentScreen.Bounds.Width - nastaveniaForm.Width) / 2,
                currentScreen.Bounds.Top + (currentScreen.Bounds.Height - nastaveniaForm.Height) / 2
            );

            // Zobrazí okno s nastaveniami na strede obrazovky.
            nastaveniaForm.Show();
        }
    }

}
