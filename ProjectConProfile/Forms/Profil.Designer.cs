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
            this.dataGridNacitane = new System.Windows.Forms.DataGridView();
            this.treeViewPriecinky = new System.Windows.Forms.TreeView();
            this.buttonUlozit = new System.Windows.Forms.Button();
            this.pridatPriecinokButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNacitane)).BeginInit();
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
            this.dataGridNacitane.Location = new System.Drawing.Point(350, 75);
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
            this.treeViewPriecinky.Location = new System.Drawing.Point(29, 75);
            this.treeViewPriecinky.Name = "treeViewPriecinky";
            this.treeViewPriecinky.Size = new System.Drawing.Size(253, 322);
            this.treeViewPriecinky.TabIndex = 1;
            this.treeViewPriecinky.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPriecinky_AfterSelect);
            // 
            // buttonUlozit
            // 
            this.buttonUlozit.Location = new System.Drawing.Point(74, 12);
            this.buttonUlozit.Name = "buttonUlozit";
            this.buttonUlozit.Size = new System.Drawing.Size(160, 23);
            this.buttonUlozit.TabIndex = 3;
            this.buttonUlozit.Text = "Uložiť projekt";
            this.buttonUlozit.UseVisualStyleBackColor = true;
            this.buttonUlozit.Click += new System.EventHandler(this.buttonUlozit_Click);
            // 
            // pridatPriecinokButton
            // 
            this.pridatPriecinokButton.Location = new System.Drawing.Point(74, 412);
            this.pridatPriecinokButton.Name = "pridatPriecinokButton";
            this.pridatPriecinokButton.Size = new System.Drawing.Size(36, 23);
            this.pridatPriecinokButton.TabIndex = 4;
            this.pridatPriecinokButton.Text = "+";
            this.pridatPriecinokButton.UseVisualStyleBackColor = true;
            this.pridatPriecinokButton.Click += new System.EventHandler(this.pridatPriecinokButton_Click);
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1630, 749);
            this.Controls.Add(this.pridatPriecinokButton);
            this.Controls.Add(this.buttonUlozit);
            this.Controls.Add(this.treeViewPriecinky);
            this.Controls.Add(this.dataGridNacitane);
            this.Name = "Profil";
            this.Text = "Profil";
            this.Load += new System.EventHandler(this.Profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNacitane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridNacitane;
        private System.Windows.Forms.TreeView treeViewPriecinky;
        private System.Windows.Forms.Button buttonUlozit;
        private System.Windows.Forms.Button pridatPriecinokButton;
    }
}