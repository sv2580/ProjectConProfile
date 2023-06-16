using System;

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
            this.buttonNacitatProjekt = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonSpat = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNacitatData
            // 
            this.buttonNacitatData.Location = new System.Drawing.Point(434, 292);
            this.buttonNacitatData.Name = "buttonNacitatData";
            this.buttonNacitatData.Size = new System.Drawing.Size(298, 126);
            this.buttonNacitatData.TabIndex = 0;
            this.buttonNacitatData.Text = "Načítať dáta";
            this.buttonNacitatData.UseVisualStyleBackColor = true;
            this.buttonNacitatData.Click += new System.EventHandler(this.buttonNacitatData_Click);
            // 
            // buttonNacitatProjekt
            // 
            this.buttonNacitatProjekt.Location = new System.Drawing.Point(772, 292);
            this.buttonNacitatProjekt.Name = "buttonNacitatProjekt";
            this.buttonNacitatProjekt.Size = new System.Drawing.Size(305, 126);
            this.buttonNacitatProjekt.TabIndex = 2;
            this.buttonNacitatProjekt.Text = "Načítať projekt";
            this.buttonNacitatProjekt.UseVisualStyleBackColor = true;
            this.buttonNacitatProjekt.Click += new System.EventHandler(this.buttonNacitatProjekt_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.buttonSpat);
            this.panel.Controls.Add(this.buttonNacitatProjekt);
            this.panel.Controls.Add(this.buttonNacitatData);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1648, 796);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // buttonSpat
            // 
            this.buttonSpat.Location = new System.Drawing.Point(36, 41);
            this.buttonSpat.Name = "buttonSpat";
            this.buttonSpat.Size = new System.Drawing.Size(44, 23);
            this.buttonSpat.TabIndex = 3;
            this.buttonSpat.Text = "<-";
            this.buttonSpat.UseVisualStyleBackColor = true;
            this.buttonSpat.Visible = false;
            this.buttonSpat.Click += new System.EventHandler(this.buttonSpat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 796);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button buttonNacitatData;
        private System.Windows.Forms.Button buttonNacitatProjekt;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonSpat;
    }
}

