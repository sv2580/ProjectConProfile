using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProjectConProfile.Forms
{
    partial class Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profil));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridNacitane = new System.Windows.Forms.DataGridView();
            this.treeViewPriecinky = new System.Windows.Forms.TreeView();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.pridatPriecinokButton = new System.Windows.Forms.Button();
            this.buttonPorovnat = new System.Windows.Forms.Button();
            this.dataGridNasobeneData = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonNasobit = new System.Windows.Forms.Button();
            this.dataGridProfil = new System.Windows.Forms.DataGridView();
            this.Max = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.std = new System.Windows.Forms.Label();
            this.std2 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNacitane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNasobeneData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridNacitane
            // 
            this.dataGridNacitane.AllowUserToAddRows = false;
            this.dataGridNacitane.AllowUserToDeleteRows = false;
            this.dataGridNacitane.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridNacitane.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridNacitane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNacitane.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridNacitane.Location = new System.Drawing.Point(383, 157);
            this.dataGridNacitane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridNacitane.MultiSelect = false;
            this.dataGridNacitane.Name = "dataGridNacitane";
            this.dataGridNacitane.ReadOnly = true;
            this.dataGridNacitane.RowHeadersWidth = 10;
            this.dataGridNacitane.Size = new System.Drawing.Size(717, 363);
            this.dataGridNacitane.TabIndex = 2;
            this.dataGridNacitane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNacitane_CellContentClick_1);
            // 
            // treeViewPriecinky
            // 
            this.treeViewPriecinky.Location = new System.Drawing.Point(21, 157);
            this.treeViewPriecinky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeViewPriecinky.Name = "treeViewPriecinky";
            this.treeViewPriecinky.Size = new System.Drawing.Size(332, 362);
            this.treeViewPriecinky.TabIndex = 1;
            this.treeViewPriecinky.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPriecinky_AfterSelect);
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUlozit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUlozit.FlatAppearance.BorderSize = 2;
            this.buttonUlozit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUlozit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUlozit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUlozit.Location = new System.Drawing.Point(107, 110);
            this.buttonUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 6);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(145, 39);
            this.buttonUlozit.TabIndex = 3;
            this.buttonUlozit.Text = "Uložiť projekt";
            this.buttonUlozit.UseVisualStyleBackColor = false;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // pridatPriecinokButton
            // 
            this.pridatPriecinokButton.BackColor = System.Drawing.Color.Silver;
            this.pridatPriecinokButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.pridatPriecinokButton.FlatAppearance.BorderSize = 2;
            this.pridatPriecinokButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pridatPriecinokButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatPriecinokButton.Image = ((System.Drawing.Image)(resources.GetObject("pridatPriecinokButton.Image")));
            this.pridatPriecinokButton.Location = new System.Drawing.Point(98, 523);
            this.pridatPriecinokButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pridatPriecinokButton.Name = "pridatPriecinokButton";
            this.pridatPriecinokButton.Size = new System.Drawing.Size(85, 39);
            this.pridatPriecinokButton.TabIndex = 4;
            this.pridatPriecinokButton.UseVisualStyleBackColor = false;
            this.pridatPriecinokButton.Click += new System.EventHandler(this.pridatPriecinokButton_Click);
            // 
            // buttonPorovnat
            // 
            this.buttonPorovnat.BackColor = System.Drawing.Color.Silver;
            this.buttonPorovnat.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonPorovnat.FlatAppearance.BorderSize = 2;
            this.buttonPorovnat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPorovnat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPorovnat.Location = new System.Drawing.Point(189, 523);
            this.buttonPorovnat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPorovnat.Name = "buttonPorovnat";
            this.buttonPorovnat.Size = new System.Drawing.Size(124, 39);
            this.buttonPorovnat.TabIndex = 5;
            this.buttonPorovnat.Text = "Porovnať";
            this.buttonPorovnat.UseVisualStyleBackColor = false;
            this.buttonPorovnat.Click += new System.EventHandler(this.buttonPorovnat_Click);
            // 
            // dataGridNasobeneData
            // 
            this.dataGridNasobeneData.AllowUserToAddRows = false;
            this.dataGridNasobeneData.AllowUserToDeleteRows = false;
            this.dataGridNasobeneData.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridNasobeneData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridNasobeneData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNasobeneData.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridNasobeneData.Location = new System.Drawing.Point(383, 541);
            this.dataGridNasobeneData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridNasobeneData.MultiSelect = false;
            this.dataGridNasobeneData.Name = "dataGridNasobeneData";
            this.dataGridNasobeneData.ReadOnly = true;
            this.dataGridNasobeneData.RowHeadersWidth = 10;
            this.dataGridNasobeneData.Size = new System.Drawing.Size(717, 367);
            this.dataGridNasobeneData.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(1118, 181);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(470, 338);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "Graf";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // buttonNasobit
            // 
            this.buttonNasobit.BackColor = System.Drawing.Color.LightGray;
            this.buttonNasobit.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonNasobit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNasobit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNasobit.Location = new System.Drawing.Point(1557, 985);
            this.buttonNasobit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNasobit.Name = "buttonNasobit";
            this.buttonNasobit.Size = new System.Drawing.Size(85, 30);
            this.buttonNasobit.TabIndex = 8;
            this.buttonNasobit.Text = "Násobiť";
            this.buttonNasobit.UseVisualStyleBackColor = false;
            this.buttonNasobit.Click += new System.EventHandler(this.buttonNasobit_Click);
            // 
            // dataGridProfil
            // 
            this.dataGridProfil.AllowUserToAddRows = false;
            this.dataGridProfil.AllowUserToDeleteRows = false;
            this.dataGridProfil.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridProfil.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridProfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfil.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridProfil.Location = new System.Drawing.Point(1118, 541);
            this.dataGridProfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridProfil.MultiSelect = false;
            this.dataGridProfil.Name = "dataGridProfil";
            this.dataGridProfil.ReadOnly = true;
            this.dataGridProfil.RowHeadersWidth = 10;
            this.dataGridProfil.Size = new System.Drawing.Size(184, 367);
            this.dataGridProfil.TabIndex = 9;
            this.dataGridProfil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProfil_CellContentClick);
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(1323, 660);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(32, 16);
            this.Max.TabIndex = 10;
            this.Max.Text = "Max";
            this.Max.Click += new System.EventHandler(this.label1_Click);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(1323, 703);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(28, 16);
            this.Min.TabIndex = 11;
            this.Min.Text = "Min";
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // std
            // 
            this.std.AutoSize = true;
            this.std.Location = new System.Drawing.Point(1323, 745);
            this.std.Name = "std";
            this.std.Size = new System.Drawing.Size(27, 16);
            this.std.TabIndex = 12;
            this.std.Text = "Std";
            // 
            // std2
            // 
            this.std2.AutoSize = true;
            this.std2.Location = new System.Drawing.Point(1470, 745);
            this.std2.Name = "std2";
            this.std2.Size = new System.Drawing.Size(27, 16);
            this.std2.TabIndex = 15;
            this.std2.Text = "Std";
            // 
            // min2
            // 
            this.min2.AutoSize = true;
            this.min2.Location = new System.Drawing.Point(1470, 703);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(28, 16);
            this.min2.TabIndex = 14;
            this.min2.Text = "Min";
            // 
            // max2
            // 
            this.max2.AutoSize = true;
            this.max2.Location = new System.Drawing.Point(1470, 660);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(32, 16);
            this.max2.TabIndex = 13;
            this.max2.Text = "Max";
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExport.Location = new System.Drawing.Point(112, 717);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(140, 44);
            this.buttonExport.TabIndex = 16;
            this.buttonExport.Text = "Exportovať";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click); // Pridajte obsluhu udalosti pre button
            this.buttonExport.Visible = false;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1593, 912);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.std2);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.std);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.dataGridProfil);
            this.Controls.Add(this.buttonNasobit);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridNasobeneData);
            this.Controls.Add(this.buttonPorovnat);
            this.Controls.Add(this.pridatPriecinokButton);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.treeViewPriecinky);
            this.Controls.Add(this.dataGridNacitane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Profil";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNacitane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNasobeneData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridNacitane;
        private System.Windows.Forms.TreeView treeViewPriecinky;
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.Button pridatPriecinokButton;
        private System.Windows.Forms.Button buttonPorovnat;
        private System.Windows.Forms.DataGridView dataGridNasobeneData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonNasobit;
        private System.Windows.Forms.DataGridView dataGridProfil;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label std;
        private System.Windows.Forms.Label std2;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Button buttonExport;

        
    }
}