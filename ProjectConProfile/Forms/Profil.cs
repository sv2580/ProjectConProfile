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
    public partial class Profil : Form
    {
        private Projekt _projekt;
        private KoncentracnyProfil _zvolenyProfil;
        public Profil(Projekt projekt, int index)
        {
            InitializeComponent();
            _projekt = projekt;
            _zvolenyProfil = _projekt._profily[index];
            List<double>[] data = new List<double>[_zvolenyProfil._nacitaneData.Count];
            for (int i = 0; i < _zvolenyProfil._nacitaneData.Count; i++)
            {
                data[i] = _zvolenyProfil._nacitaneData[i]._data;
            }

            createBasicGrid(data);
        }


        private DataTable createBasicGrid(List<double>[] data)
        {
            DataTable dataTable = new DataTable();

            foreach (var column in data)
            {
                dataTable.Columns.Add(column[0].ToString());
            }

            DataRow emptyRow = dataTable.NewRow();
            foreach (var column in data)
            {
                emptyRow[column[0].ToString()] = "-";
            }
            dataTable.Rows.Add(emptyRow);



            for (int j = 1; j < data[0].Count; j++)
            {
                DataRow newRow = dataTable.NewRow();

                foreach (var column in data)
                {
                    newRow[column[0].ToString()] = column[j];
                }

                dataTable.Rows.Add(newRow);
            }

            dataTable.Columns[0].ColumnName = " ";

            return dataTable;

        }

        private void Profil_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
