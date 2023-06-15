namespace ProjectConProfile
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonNacitatData = new System.Windows.Forms.Button();
            this.treeViewPriecinky = new System.Windows.Forms.TreeView();
            this.pridatPriecinokButton = new System.Windows.Forms.Button();
            this.dataGridNacitane = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonNasobitData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNacitane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNacitatData
            // 
            this.buttonNacitatData.Location = new System.Drawing.Point(26, 25);
            this.buttonNacitatData.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNacitatData.Name = "buttonNacitatData";
            this.buttonNacitatData.Size = new System.Drawing.Size(103, 35);
            this.buttonNacitatData.TabIndex = 0;
            this.buttonNacitatData.Text = "Načítať dáta";
            this.buttonNacitatData.UseVisualStyleBackColor = true;
            this.buttonNacitatData.Click += new System.EventHandler(this.buttonNacitatData_Click);
            // 
            // treeViewPriecinky
            // 
            this.treeViewPriecinky.Location = new System.Drawing.Point(26, 101);
            this.treeViewPriecinky.Name = "treeViewPriecinky";
            this.treeViewPriecinky.Size = new System.Drawing.Size(251, 262);
            this.treeViewPriecinky.TabIndex = 1;
            this.treeViewPriecinky.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPriecinky_AfterSelect);
            // 
            // pridatPriecinokButton
            // 
            this.pridatPriecinokButton.Enabled = false;
            this.pridatPriecinokButton.Location = new System.Drawing.Point(284, 339);
            this.pridatPriecinokButton.Name = "pridatPriecinokButton";
            this.pridatPriecinokButton.Size = new System.Drawing.Size(31, 23);
            this.pridatPriecinokButton.TabIndex = 2;
            this.pridatPriecinokButton.Text = "+";
            this.pridatPriecinokButton.UseVisualStyleBackColor = true;
            this.pridatPriecinokButton.Visible = false;
            this.pridatPriecinokButton.Click += new System.EventHandler(this.pridatPriecinokButton_Click);
            // 
            // dataGridNacitane
            // 
            this.dataGridNacitane.AllowUserToAddRows = false;
            this.dataGridNacitane.AllowUserToDeleteRows = false;
            this.dataGridNacitane.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridNacitane.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridNacitane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNacitane.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridNacitane.Location = new System.Drawing.Point(321, 100);
            this.dataGridNacitane.MultiSelect = false;
            this.dataGridNacitane.Name = "dataGridNacitane";
            this.dataGridNacitane.ReadOnly = true;
            this.dataGridNacitane.RowHeadersWidth = 10;
            this.dataGridNacitane.Size = new System.Drawing.Size(487, 262);
            this.dataGridNacitane.TabIndex = 3;
            this.dataGridNacitane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(860, 374);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 261);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(321, 373);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.Size = new System.Drawing.Size(487, 262);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonNasobitData
            // 
            this.buttonNasobitData.Location = new System.Drawing.Point(836, 71);
            this.buttonNasobitData.Name = "buttonNasobitData";
            this.buttonNasobitData.Size = new System.Drawing.Size(75, 23);
            this.buttonNasobitData.TabIndex = 6;
            this.buttonNasobitData.Text = "Nasobit";
            this.buttonNasobitData.UseVisualStyleBackColor = true;
            this.buttonNasobitData.Click += new System.EventHandler(this.buttonNasobitData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 647);
            this.Controls.Add(this.buttonNasobitData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridNacitane);
            this.Controls.Add(this.pridatPriecinokButton);
            this.Controls.Add(this.treeViewPriecinky);
            this.Controls.Add(this.buttonNacitatData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNacitane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNacitatData;
        private System.Windows.Forms.TreeView treeViewPriecinky;
        private System.Windows.Forms.Button pridatPriecinokButton;
        private System.Windows.Forms.DataGridView dataGridNacitane;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonNasobitData;
    }
}

