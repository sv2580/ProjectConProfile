using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectConProfile.Forms
{
    partial class Porovnanie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Porovnanie));
            this.treeViewPorovnanie = new System.Windows.Forms.TreeView();
            this.buttonPorovnat = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMinimalizuj1 = new System.Windows.Forms.Button();
            this.buttonZrus1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewPorovnanie
            // 
            this.treeViewPorovnanie.Location = new System.Drawing.Point(78, 177);
            this.treeViewPorovnanie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeViewPorovnanie.Name = "treeViewPorovnanie";
            this.treeViewPorovnanie.Size = new System.Drawing.Size(340, 322);
            this.treeViewPorovnanie.TabIndex = 2;
            // 
            // buttonPorovnat
            // 
            this.buttonPorovnat.BackColor = System.Drawing.Color.Silver;
            this.buttonPorovnat.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonPorovnat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPorovnat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPorovnat.Location = new System.Drawing.Point(188, 503);
            this.buttonPorovnat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPorovnat.Name = "buttonPorovnat";
            this.buttonPorovnat.Size = new System.Drawing.Size(100, 33);
            this.buttonPorovnat.TabIndex = 6;
            this.buttonPorovnat.Text = "Porovnať";
            this.buttonPorovnat.UseVisualStyleBackColor = false;
            this.buttonPorovnat.Click += new System.EventHandler(this.buttonPorovnat_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(531, 145);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(659, 450);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "Graf";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonMinimalizuj1);
            this.panel1.Controls.Add(this.buttonZrus1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 76);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonMinimalizuj1
            // 
            this.buttonMinimalizuj1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimalizuj1.FlatAppearance.BorderSize = 0;
            this.buttonMinimalizuj1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimalizuj1.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimalizuj1.Image")));
            this.buttonMinimalizuj1.Location = new System.Drawing.Point(1157, 7);
            this.buttonMinimalizuj1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMinimalizuj1.Name = "buttonMinimalizuj1";
            this.buttonMinimalizuj1.Size = new System.Drawing.Size(39, 28);
            this.buttonMinimalizuj1.TabIndex = 9;
            this.buttonMinimalizuj1.UseVisualStyleBackColor = true;
            this.buttonMinimalizuj1.Click += new System.EventHandler(this.buttonMinimalizuj1_Click);
            // 
            // buttonZrus1
            // 
            this.buttonZrus1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZrus1.FlatAppearance.BorderSize = 0;
            this.buttonZrus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZrus1.Image = ((System.Drawing.Image)(resources.GetObject("buttonZrus1.Image")));
            this.buttonZrus1.Location = new System.Drawing.Point(1204, 7);
            this.buttonZrus1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonZrus1.Name = "buttonZrus1";
            this.buttonZrus1.Size = new System.Drawing.Size(36, 28);
            this.buttonZrus1.TabIndex = 7;
            this.buttonZrus1.UseVisualStyleBackColor = true;
            this.buttonZrus1.Click += new System.EventHandler(this.buttonZrus1_Click);
            // 
            // Porovnanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonPorovnat);
            this.Controls.Add(this.treeViewPorovnanie);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Porovnanie";
            this.Text = "Porovnanie";
            this.Load += new System.EventHandler(this.Porovnanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TreeView treeViewPorovnanie;
        private System.Windows.Forms.Button buttonPorovnat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel panel1;
        private System.Windows.Forms.Button buttonZrus1;
        private System.Windows.Forms.Button buttonMinimalizuj1;
    }
}