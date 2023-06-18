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
            this.treeViewPorovnanie = new System.Windows.Forms.TreeView();
            this.buttonPorovnat = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewPorovnanie
            // 
            this.treeViewPorovnanie.Location = new System.Drawing.Point(12, 25);
            this.treeViewPorovnanie.Name = "treeViewPorovnanie";
            this.treeViewPorovnanie.Size = new System.Drawing.Size(340, 322);
            this.treeViewPorovnanie.TabIndex = 2;
            treeViewPorovnanie.BeforeCheck += treeViewPorovnanie_BeforeCheck;

            // 
            // buttonPorovnat
            // 
            this.buttonPorovnat.Location = new System.Drawing.Point(129, 364);
            this.buttonPorovnat.Name = "buttonPorovnat";
            this.buttonPorovnat.Size = new System.Drawing.Size(83, 23);
            this.buttonPorovnat.TabIndex = 6;
            this.buttonPorovnat.Text = "Porovnať";
            this.buttonPorovnat.UseVisualStyleBackColor = true;
            this.buttonPorovnat.Click += new System.EventHandler(this.buttonPorovnat_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(452, 25);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(658, 450);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "Graf";
            // 
            // Porovnanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 599);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonPorovnat);
            this.Controls.Add(this.treeViewPorovnanie);
            this.Name = "Porovnanie";
            this.Text = "Porovnanie";
            this.Load += new System.EventHandler(this.Porovnanie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TreeView treeViewPorovnanie;
        private System.Windows.Forms.Button buttonPorovnat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}