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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.buttonExportPicture = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
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
            this.dataGridNacitane.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridNacitane.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridNacitane.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridNacitane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNacitane.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridNacitane.Location = new System.Drawing.Point(402, 152);
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
            this.treeViewPriecinky.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.treeViewPriecinky.Location = new System.Drawing.Point(8, 152);
            this.treeViewPriecinky.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeViewPriecinky.Name = "treeViewPriecinky";
            this.treeViewPriecinky.Size = new System.Drawing.Size(332, 362);
            this.treeViewPriecinky.TabIndex = 1;
            this.treeViewPriecinky.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPriecinky_AfterSelect);
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUlozit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUlozit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUlozit.FlatAppearance.BorderSize = 2;
            this.buttonUlozit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUlozit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUlozit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonUlozit.Location = new System.Drawing.Point(94, 105);
            this.buttonUlozit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(145, 39);
            this.buttonUlozit.TabIndex = 3;
            this.buttonUlozit.Text = "Uložiť projekt";
            this.buttonUlozit.UseVisualStyleBackColor = false;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // pridatPriecinokButton
            // 
            this.pridatPriecinokButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pridatPriecinokButton.BackColor = System.Drawing.Color.Silver;
            this.pridatPriecinokButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.pridatPriecinokButton.FlatAppearance.BorderSize = 2;
            this.pridatPriecinokButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pridatPriecinokButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatPriecinokButton.Image = ((System.Drawing.Image)(resources.GetObject("pridatPriecinokButton.Image")));
            this.pridatPriecinokButton.Location = new System.Drawing.Point(85, 518);
            this.pridatPriecinokButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pridatPriecinokButton.Name = "pridatPriecinokButton";
            this.pridatPriecinokButton.Size = new System.Drawing.Size(85, 39);
            this.pridatPriecinokButton.TabIndex = 4;
            this.pridatPriecinokButton.UseVisualStyleBackColor = false;
            this.pridatPriecinokButton.Click += new System.EventHandler(this.pridatPriecinokButton_Click);
            // 
            // buttonPorovnat
            // 
            this.buttonPorovnat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPorovnat.BackColor = System.Drawing.Color.Silver;
            this.buttonPorovnat.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonPorovnat.FlatAppearance.BorderSize = 2;
            this.buttonPorovnat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPorovnat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPorovnat.Location = new System.Drawing.Point(176, 518);
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
            this.dataGridNasobeneData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridNasobeneData.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridNasobeneData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridNasobeneData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNasobeneData.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridNasobeneData.Location = new System.Drawing.Point(402, 547);
            this.dataGridNasobeneData.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.dataGridNasobeneData.MultiSelect = false;
            this.dataGridNasobeneData.Name = "dataGridNasobeneData";
            this.dataGridNasobeneData.ReadOnly = true;
            this.dataGridNasobeneData.RowHeadersWidth = 10;
            this.dataGridNasobeneData.Size = new System.Drawing.Size(717, 367);
            this.dataGridNasobeneData.TabIndex = 6;
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(1195, 152);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
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
            this.buttonNasobit.Location = new System.Drawing.Point(1560, 985);
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
            this.dataGridProfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridProfil.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridProfil.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridProfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfil.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridProfil.Location = new System.Drawing.Point(1158, 547);
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
            this.Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Max.AutoSize = true;
            this.Max.Location = new System.Drawing.Point(1379, 672);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(32, 16);
            this.Max.TabIndex = 10;
            this.Max.Text = "Max";
            this.Max.Click += new System.EventHandler(this.label1_Click);
            // 
            // Min
            // 
            this.Min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Min.AutoSize = true;
            this.Min.Location = new System.Drawing.Point(1379, 715);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(28, 16);
            this.Min.TabIndex = 11;
            this.Min.Text = "Min";
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // std
            // 
            this.std.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.std.AutoSize = true;
            this.std.Location = new System.Drawing.Point(1379, 757);
            this.std.Name = "std";
            this.std.Size = new System.Drawing.Size(27, 16);
            this.std.TabIndex = 12;
            this.std.Text = "Std";
            // 
            // std2
            // 
            this.std2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.std2.AutoSize = true;
            this.std2.Location = new System.Drawing.Point(1508, 757);
            this.std2.Name = "std2";
            this.std2.Size = new System.Drawing.Size(27, 16);
            this.std2.TabIndex = 15;
            this.std2.Text = "Std";
            // 
            // min2
            // 
            this.min2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.min2.AutoSize = true;
            this.min2.Location = new System.Drawing.Point(1507, 715);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(28, 16);
            this.min2.TabIndex = 14;
            this.min2.Text = "Min";
            // 
            // max2
            // 
            this.max2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.max2.AutoSize = true;
            this.max2.Location = new System.Drawing.Point(1507, 672);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(32, 16);
            this.max2.TabIndex = 13;
            this.max2.Text = "Max";
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExport.Location = new System.Drawing.Point(99, 712);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(140, 44);
            this.buttonExport.TabIndex = 16;
            this.buttonExport.Text = "Exportovať";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Visible = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonExportPicture
            // 
            this.buttonExportPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExportPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonExportPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportPicture.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExportPicture.ForeColor = System.Drawing.Color.White;
            this.buttonExportPicture.Location = new System.Drawing.Point(1374, 484);
            this.buttonExportPicture.Name = "buttonExportPicture";
            this.buttonExportPicture.Size = new System.Drawing.Size(127, 51);
            this.buttonExportPicture.TabIndex = 17;
            this.buttonExportPicture.Text = "Exportovať obrázok";
            this.buttonExportPicture.UseVisualStyleBackColor = false;
            this.buttonExportPicture.Visible = false;
            this.buttonExportPicture.Click += new System.EventHandler(this.buttonExportPicture_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(1413, 669);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 22);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(1413, 712);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 22);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(1413, 754);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 22);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(1541, 754);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(88, 22);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(1541, 712);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(88, 22);
            this.textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.Location = new System.Drawing.Point(1541, 669);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(88, 22);
            this.textBox6.TabIndex = 21;
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1780, 934);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonExportPicture);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private Button buttonExportPicture;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}