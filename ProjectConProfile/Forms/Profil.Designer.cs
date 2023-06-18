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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.dataGridNacitane.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridNacitane.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridNacitane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNacitane.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridNacitane.Location = new System.Drawing.Point(387, 75);
            this.dataGridNacitane.MultiSelect = false;
            this.dataGridNacitane.Name = "dataGridNacitane";
            this.dataGridNacitane.ReadOnly = true;
            this.dataGridNacitane.RowHeadersWidth = 10;
            this.dataGridNacitane.Size = new System.Drawing.Size(649, 322);
            this.dataGridNacitane.TabIndex = 2;
            this.dataGridNacitane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNacitane_CellContentClick_1);
            // 
            // treeViewPriecinky
            // 
            this.treeViewPriecinky.Location = new System.Drawing.Point(12, 75);
            this.treeViewPriecinky.Name = "treeViewPriecinky";
            this.treeViewPriecinky.Size = new System.Drawing.Size(340, 322);
            this.treeViewPriecinky.TabIndex = 1;
            this.treeViewPriecinky.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPriecinky_AfterSelect);
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(89, 29);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(160, 23);
            this.buttonUlozit.TabIndex = 3;
            this.buttonUlozit.Text = "Uložiť projekt";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // pridatPriecinokButton
            // 
            this.pridatPriecinokButton.Location = new System.Drawing.Point(89, 412);
            this.pridatPriecinokButton.Name = "pridatPriecinokButton";
            this.pridatPriecinokButton.Size = new System.Drawing.Size(68, 23);
            this.pridatPriecinokButton.TabIndex = 4;
            this.pridatPriecinokButton.Text = "+";
            this.pridatPriecinokButton.UseVisualStyleBackColor = true;
            this.pridatPriecinokButton.Click += new System.EventHandler(this.pridatPriecinokButton_Click);
            // 
            // buttonPorovnat
            // 
            this.buttonPorovnat.Location = new System.Drawing.Point(166, 412);
            this.buttonPorovnat.Name = "buttonPorovnat";
            this.buttonPorovnat.Size = new System.Drawing.Size(83, 23);
            this.buttonPorovnat.TabIndex = 5;
            this.buttonPorovnat.Text = "Porovnať";
            this.buttonPorovnat.UseVisualStyleBackColor = true;
            this.buttonPorovnat.Click += new System.EventHandler(this.buttonPorovnat_Click);
            // 
            // dataGridNasobeneData
            // 
            this.dataGridNasobeneData.AllowUserToAddRows = false;
            this.dataGridNasobeneData.AllowUserToDeleteRows = false;
            this.dataGridNasobeneData.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridNasobeneData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridNasobeneData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNasobeneData.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridNasobeneData.Location = new System.Drawing.Point(387, 415);
            this.dataGridNasobeneData.MultiSelect = false;
            this.dataGridNasobeneData.Name = "dataGridNasobeneData";
            this.dataGridNasobeneData.ReadOnly = true;
            this.dataGridNasobeneData.RowHeadersWidth = 10;
            this.dataGridNasobeneData.Size = new System.Drawing.Size(649, 322);
            this.dataGridNasobeneData.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1062, 75);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(453, 322);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "Graf";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // buttonNasobit
            // 
            this.buttonNasobit.Location = new System.Drawing.Point(1557, 984);
            this.buttonNasobit.Name = "buttonNasobit";
            this.buttonNasobit.Size = new System.Drawing.Size(72, 23);
            this.buttonNasobit.TabIndex = 8;
            this.buttonNasobit.Text = "Násobiť";
            this.buttonNasobit.UseVisualStyleBackColor = true;
            this.buttonNasobit.Click += new System.EventHandler(this.buttonNasobit_Click);
            // 
            // dataGridProfil
            // 
            this.dataGridProfil.AllowUserToAddRows = false;
            this.dataGridProfil.AllowUserToDeleteRows = false;
            this.dataGridProfil.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridProfil.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridProfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfil.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridProfil.Location = new System.Drawing.Point(1062, 415);
            this.dataGridProfil.MultiSelect = false;
            this.dataGridProfil.Name = "dataGridProfil";
            this.dataGridProfil.ReadOnly = true;
            this.dataGridProfil.RowHeadersWidth = 10;
            this.dataGridProfil.Size = new System.Drawing.Size(167, 322);
            this.dataGridProfil.TabIndex = 9;
            this.dataGridProfil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProfil_CellContentClick);
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(1270, 516);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(32, 16);
            this.Max.TabIndex = 10;
            this.Max.Text = "Max";
            this.Max.Click += new System.EventHandler(this.label1_Click);
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(1270, 550);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(28, 16);
            this.Min.TabIndex = 11;
            this.Min.Text = "Min";
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // std
            // 
            this.std.AutoSize = true;
            this.std.Location = new System.Drawing.Point(1270, 583);
            this.std.Name = "std";
            this.std.Size = new System.Drawing.Size(27, 16);
            this.std.TabIndex = 12;
            this.std.Text = "Std";
            // 
            // std2
            // 
            this.std2.AutoSize = true;
            this.std2.Location = new System.Drawing.Point(1430, 583);
            this.std2.Name = "std2";
            this.std2.Size = new System.Drawing.Size(27, 16);
            this.std2.TabIndex = 15;
            this.std2.Text = "Std";
            // 
            // min2
            // 
            this.min2.AutoSize = true;
            this.min2.Location = new System.Drawing.Point(1430, 550);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(28, 16);
            this.min2.TabIndex = 14;
            this.min2.Text = "Min";
            // 
            // max2
            // 
            this.max2.AutoSize = true;
            this.max2.Location = new System.Drawing.Point(1430, 516);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(32, 16);
            this.max2.TabIndex = 13;
            this.max2.Text = "Max";
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1630, 749);
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
            this.Name = "Profil";
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
    }
}