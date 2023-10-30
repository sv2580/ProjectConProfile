using ProjectConProfile.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectConProfile.Forms
{
    public partial class Nastavenia : Form
    {
        public NastaveniaSuborov _nastaveniaSuborov;
        public Nastavenia(NastaveniaSuborov nastaveniaSuborov)
        {
            _nastaveniaSuborov = nastaveniaSuborov;
            InitializeComponent();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Nastavenia_Load(object sender, EventArgs e)
        {
            if(_nastaveniaSuborov.cestaKDatam != null || _nastaveniaSuborov.cestaKDatam != "-")
                this.boxPriecinokData.Text = _nastaveniaSuborov.cestaKDatam;
            if (_nastaveniaSuborov.cestaNaUkladanie != null || _nastaveniaSuborov.cestaNaUkladanie != "-")
                this.boxPriecinokProjekty.Text = _nastaveniaSuborov.cestaNaUkladanie;
            if (_nastaveniaSuborov.cestaKSuboruFakt != null || _nastaveniaSuborov.cestaKSuboruFakt != "-")
                this.boxSuborFaktory.Text = _nastaveniaSuborov.cestaKSuboruFakt;

        }

    
        private void buttonZmenitSuborFaktory_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Vyberte súbor";
            openFileDialog.Filter = "Textové súbory (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                _nastaveniaSuborov.cestaKSuboruFakt = selectedFilePath;
                _nastaveniaSuborov.ulozitNastavenia();
                this.boxSuborFaktory.Text = selectedFilePath;

            }
        }

        private void buttonZmenitPriecinokData_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Vyberte zložku";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                _nastaveniaSuborov.cestaKDatam = selectedFolderPath;
                _nastaveniaSuborov.ulozitNastavenia();
                this.boxPriecinokData.Text = selectedFolderPath;


            }
        }

        private void buttonZmenitOdkazUkladania_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Vyberte zložku";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                _nastaveniaSuborov.cestaNaUkladanie = selectedFolderPath;
                _nastaveniaSuborov.ulozitNastavenia();
                this.boxPriecinokProjekty.Text = selectedFolderPath;

            }
        }
    }
}
