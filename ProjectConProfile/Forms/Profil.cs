using Newtonsoft.Json;
using ProjectConProfile.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectConProfile.Forms
{
    public partial class Profil : Form
    {
        private Form1 _form;
        private Projekt _projekt;
        private KoncentracnyProfil _zvolenyProfil;
        public Profil(Projekt projekt, int index)
        {
            InitializeComponent();
            _form = new Form1();
            _projekt = projekt;
            _zvolenyProfil = _projekt._profily[index];

            populovatGrid(_zvolenyProfil);
            populovatTree();
            dataGridNacitane.DataSource = populovatGrid(_zvolenyProfil);
            dataGridNacitane.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                //this.comboBox1.FormattingEnabled = true;
                //this.comboBox1.Location = new System.Drawing.Point(321, 68);
                //this.comboBox1.Name = "comboBox1";
                //this.comboBox1.Size = new System.Drawing.Size(78, 21);
                //this.comboBox1.TabIndex = 5;
                //this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
                
                ComboBox comboBox = new ComboBox();

                int rozmerX = dataGridNacitane.Width/pocet - 15;

                comboBox.Location = new Point(5 + dataGridNacitane.Location.X + dataGridNacitane.RowHeadersWidth
                                                + i * (rozmerX+ 10),
                                                  dataGridNacitane.Location.Y - 25);
                comboBox.Size = new System.Drawing.Size(rozmerX, 21);
                comboBox.Name = "comboBox" + i;
                // comboBox. += ComboBoxChanged;

                this.Controls.Add(comboBox);
               
            }
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
        private void Profil_Load(object sender, EventArgs e)
        {

        }

        private void treeViewPriecinky_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _zvolenyProfil = _projekt._profily.Find(p => Path.GetFileName(p._nazovPriecinku) == e.Node.Text);
            dataGridNacitane.DataSource = populovatGrid(_zvolenyProfil);
            dataGridNacitane.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridNacitane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                _zvolenyProfil = nacitaneData;
                pridajDoTreePriecinok(_zvolenyProfil);
            }
        }
    }
}
