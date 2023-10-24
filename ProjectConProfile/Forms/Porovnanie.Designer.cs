using System;
using System.Drawing;
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
            this.chartCompare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMinimalizuj1 = new System.Windows.Forms.Button();
            this.buttonZrus1 = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompare)).BeginInit();
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
            this.buttonPorovnat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPorovnat.Location = new System.Drawing.Point(188, 503);
            this.buttonPorovnat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPorovnat.Name = "buttonPorovnat";
            this.buttonPorovnat.Size = new System.Drawing.Size(100, 33);
            this.buttonPorovnat.TabIndex = 6;
            this.buttonPorovnat.Text = "Porovnať";
            this.buttonPorovnat.UseVisualStyleBackColor = false;
            this.buttonPorovnat.Click += new System.EventHandler(this.buttonPorovnat_Click);
            // 
            // chartCompare
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCompare.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCompare.Legends.Add(legend1);
            this.chartCompare.Location = new System.Drawing.Point(531, 145);
            this.chartCompare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartCompare.Name = "chartCompare";
            this.chartCompare.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCompare.Series.Add(series1);
            this.chartCompare.Size = new System.Drawing.Size(659, 450);
            this.chartCompare.TabIndex = 8;
            this.chartCompare.Text = "Graf";
            this.chartCompare.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonMinimalizuj1);
            this.panel1.Controls.Add(this.buttonZrus1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 74);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonMinimalizuj1
            // 
            this.buttonMinimalizuj1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimalizuj1.FlatAppearance.BorderSize = 0;
            this.buttonMinimalizuj1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimalizuj1.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimalizuj1.Image")));
            this.buttonMinimalizuj1.Location = new System.Drawing.Point(1145, 7);
            this.buttonMinimalizuj1.Margin = new System.Windows.Forms.Padding(4);
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
            this.buttonZrus1.Location = new System.Drawing.Point(1192, 7);
            this.buttonZrus1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZrus1.Name = "buttonZrus1";
            this.buttonZrus1.Size = new System.Drawing.Size(36, 28);
            this.buttonZrus1.TabIndex = 7;
            this.buttonZrus1.UseVisualStyleBackColor = true;
            this.buttonZrus1.Click += new System.EventHandler(this.buttonZrus1_Click);
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Location = new System.Drawing.Point(60, 578);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(32, 16);
            this.max.TabIndex = 10;
            this.max.Text = "Max";
            this.max.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 611);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 643);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Std";
            // 
            // Porovnanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1234, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.max);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartCompare);
            this.Controls.Add(this.buttonPorovnat);
            this.Controls.Add(this.treeViewPorovnanie);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Porovnanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porovnanie";
            this.Load += new System.EventHandler(this.Porovnanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCompare)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TreeView treeViewPorovnanie;
        private System.Windows.Forms.Button buttonPorovnat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCompare;
        private Panel panel1;
        private System.Windows.Forms.Button buttonZrus1;
        private System.Windows.Forms.Button buttonMinimalizuj1;
        private Label max;
        private Label label1;
        private Label label2;
    }
}