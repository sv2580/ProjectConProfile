using ProjectConProfile.Objects;
using ScottPlot.Drawing.Colormaps;
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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjectConProfile.Forms
{
    public partial class Porovnanie : Form
    {
        public Projekt _projekt;
        public List<KoncentracnyProfil> _zvolene;
        private bool isDragging = false;
        private Point startPoint;

        public Porovnanie(Projekt projekt)
        {
            InitializeComponent();
            _projekt = projekt;
            _zvolene = new List<KoncentracnyProfil>();
            //pohyb okna poocou panel1
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.MouseDown += Panel1_MouseDown;
            panel1.MouseMove += Panel1_MouseMove;
            panel1.MouseUp += Panel1_MouseUp;
            //
            populovatTree();
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

        private void populovatTree()
        {
            treeViewPorovnanie.BeginUpdate();

            for (int i = 0; i < _projekt._profily.Count; i++)
            {
                treeViewPorovnanie.Nodes.Add(Path.GetFileName(_projekt._profily[i]._nazovPriecinku));
            }

            treeViewPorovnanie.EndUpdate();
            treeViewPorovnanie.CheckBoxes = true;
        }

        private void treeViewPorovnanie_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {

            if (e.Node.Parent != null)
            {
                bool parentChecked = e.Node.Checked;
                foreach (TreeNode childNode in e.Node.Nodes)
                {
                    childNode.Checked = parentChecked;
                }
            }
        }
       
        private void buttonPorovnat_Click(object sender, EventArgs e)
        {
            _zvolene.Clear();
            foreach (TreeNode node in treeViewPorovnanie.Nodes)
            {
                if (node.Checked)
                {
                    KoncentracnyProfil profil =  _projekt._profily.Find(p => Path.GetFileName(p._nazovPriecinku) == node.Text);
                    _zvolene.Add(profil);
                
                }
            }

            chart1.Series.Clear();
            foreach (KoncentracnyProfil data in _projekt._profily)
            {
                Series series = new Series();
                series.ChartType = SeriesChartType.Point;

                for (int i = 0; i < data._profil.Count; i++)
                {
                    series.Points.AddXY(data._excitacia[i], data._profil[i]);
                }
                series.IsVisibleInLegend = true;
                series.LegendText = Path.GetFileName(data._nazovPriecinku);
                chart1.Series.Add(series);
                chart1.Series[chart1.Series.Count - 1].ChartType = SeriesChartType.Line;
            }
            
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.Legends[0].Docking = Docking.Bottom;
        }
        private void Porovnanie_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonZrus1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimalizuj1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen borderPen = new Pen(Color.Gray, 1);

            // Vykreslenie obdĺžnika s okrajom
            Rectangle rect = panel1.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;
            e.Graphics.DrawRectangle(borderPen, rect);

            // Uvoľnenie zdrojov
            borderPen.Dispose();
        }
    }
}
