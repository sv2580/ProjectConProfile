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
            this.buttonNacitatData = new System.Windows.Forms.Button();
            this.buttonUlozitProjekt = new System.Windows.Forms.Button();
            this.buttonNacitatProjekt = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNacitatData
            // 
            this.buttonNacitatData.Location = new System.Drawing.Point(269, 232);
            this.buttonNacitatData.Name = "buttonNacitatData";
            this.buttonNacitatData.Size = new System.Drawing.Size(298, 126);
            this.buttonNacitatData.TabIndex = 0;
            this.buttonNacitatData.Text = "Načítať dáta";
            this.buttonNacitatData.UseVisualStyleBackColor = true;
            this.buttonNacitatData.Click += new System.EventHandler(this.buttonNacitatData_Click);
            // 
            // buttonUlozitProjekt
            // 
            //this.buttonUlozitProjekt.Location = new System.Drawing.Point(12, 71);
            //this.buttonUlozitProjekt.Name = "buttonUlozitProjekt";
            //this.buttonUlozitProjekt.Size = new System.Drawing.Size(137, 43);
            //this.buttonUlozitProjekt.TabIndex = 1;
            //this.buttonUlozitProjekt.Text = "Uložiť projekt";
            //this.buttonUlozitProjekt.UseVisualStyleBackColor = true;
            //this.buttonUlozitProjekt.Click += new System.EventHandler(this.buttonUlozitProjekt_Click);
            // 
            // buttonNacitatProjekt
            // 
            this.buttonNacitatProjekt.Location = new System.Drawing.Point(643, 232);
            this.buttonNacitatProjekt.Name = "buttonNacitatProjekt";
            this.buttonNacitatProjekt.Size = new System.Drawing.Size(305, 126);
            this.buttonNacitatProjekt.TabIndex = 2;
            this.buttonNacitatProjekt.Text = "Načítať projekt";
            this.buttonNacitatProjekt.UseVisualStyleBackColor = true;
            this.buttonNacitatProjekt.Click += new System.EventHandler(this.buttonNacitatProjekt_Click);
            // 
            // panel1
            // 
            this.panel.Controls.Add(this.buttonNacitatProjekt);
            this.panel.Controls.Add(this.buttonNacitatData);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel1";
            this.panel.Size = new System.Drawing.Size(1249, 582);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 582);
            this.Controls.Add(this.buttonUlozitProjekt);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNacitatData;
        private System.Windows.Forms.Button buttonUlozitProjekt;
        private System.Windows.Forms.Button buttonNacitatProjekt;
        private System.Windows.Forms.Panel panel;
    }
}

