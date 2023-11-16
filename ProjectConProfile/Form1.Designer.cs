using System;
using System.Windows.Forms;

namespace ProjectConProfile
{
    partial class Aplikacia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aplikacia));
            this.buttonNacitatData = new System.Windows.Forms.Button();
            this.buttonNacitatProjekt = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonNastavenia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMinimalizuj = new System.Windows.Forms.Button();
            this.buttonSpat = new System.Windows.Forms.Button();
            this.buttonZrus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNacitatData
            // 
            this.buttonNacitatData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNacitatData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonNacitatData.FlatAppearance.BorderSize = 2;
            this.buttonNacitatData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNacitatData.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNacitatData.ForeColor = System.Drawing.Color.Black;
            this.buttonNacitatData.Image = ((System.Drawing.Image)(resources.GetObject("buttonNacitatData.Image")));
            this.buttonNacitatData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNacitatData.Location = new System.Drawing.Point(459, 446);
            this.buttonNacitatData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNacitatData.Name = "buttonNacitatData";
            this.buttonNacitatData.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonNacitatData.Size = new System.Drawing.Size(299, 126);
            this.buttonNacitatData.TabIndex = 0;
            this.buttonNacitatData.Text = "       Načítať dáta";
            this.buttonNacitatData.UseMnemonic = false;
            this.buttonNacitatData.UseVisualStyleBackColor = true;
            this.buttonNacitatData.Click += new System.EventHandler(this.buttonNacitatData_Click);
            // 
            // buttonNacitatProjekt
            // 
            this.buttonNacitatProjekt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNacitatProjekt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonNacitatProjekt.FlatAppearance.BorderSize = 2;
            this.buttonNacitatProjekt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNacitatProjekt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNacitatProjekt.Image = ((System.Drawing.Image)(resources.GetObject("buttonNacitatProjekt.Image")));
            this.buttonNacitatProjekt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNacitatProjekt.Location = new System.Drawing.Point(797, 446);
            this.buttonNacitatProjekt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNacitatProjekt.Name = "buttonNacitatProjekt";
            this.buttonNacitatProjekt.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonNacitatProjekt.Size = new System.Drawing.Size(305, 126);
            this.buttonNacitatProjekt.TabIndex = 2;
            this.buttonNacitatProjekt.Text = "         Načítať projekt";
            this.buttonNacitatProjekt.UseVisualStyleBackColor = true;
            this.buttonNacitatProjekt.Click += new System.EventHandler(this.buttonNacitatProjekt_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.buttonNastavenia);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.buttonNacitatProjekt);
            this.panel.Controls.Add(this.buttonNacitatData);
            this.panel.Location = new System.Drawing.Point(0, -2);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1572, 1017);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // buttonNastavenia
            // 
            this.buttonNastavenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNastavenia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonNastavenia.FlatAppearance.BorderSize = 2;
            this.buttonNastavenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNastavenia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNastavenia.Image = ((System.Drawing.Image)(resources.GetObject("buttonNastavenia.Image")));
            this.buttonNastavenia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNastavenia.Location = new System.Drawing.Point(665, 767);
            this.buttonNastavenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNastavenia.Name = "buttonNastavenia";
            this.buttonNastavenia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonNastavenia.Size = new System.Drawing.Size(223, 73);
            this.buttonNastavenia.TabIndex = 2;
            this.buttonNastavenia.Text = "      Nastavenia";
            this.buttonNastavenia.UseVisualStyleBackColor = true;
            this.buttonNastavenia.Click += new System.EventHandler(this.buttonNastavenia_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.buttonMinimalizuj);
            this.panel1.Controls.Add(this.buttonSpat);
            this.panel1.Controls.Add(this.buttonZrus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1570, 96);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonMinimalizuj
            // 
            this.buttonMinimalizuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimalizuj.FlatAppearance.BorderSize = 0;
            this.buttonMinimalizuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimalizuj.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimalizuj.Image")));
            this.buttonMinimalizuj.Location = new System.Drawing.Point(1459, 19);
            this.buttonMinimalizuj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinimalizuj.Name = "buttonMinimalizuj";
            this.buttonMinimalizuj.Size = new System.Drawing.Size(39, 28);
            this.buttonMinimalizuj.TabIndex = 8;
            this.buttonMinimalizuj.UseVisualStyleBackColor = true;
            this.buttonMinimalizuj.Click += new System.EventHandler(this.buttonMinimalizuj_Click);
            // 
            // buttonSpat
            // 
            this.buttonSpat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSpat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSpat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSpat.FlatAppearance.BorderSize = 2;
            this.buttonSpat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpat.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpat.Image")));
            this.buttonSpat.Location = new System.Drawing.Point(11, 12);
            this.buttonSpat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSpat.Name = "buttonSpat";
            this.buttonSpat.Size = new System.Drawing.Size(50, 35);
            this.buttonSpat.TabIndex = 3;
            this.buttonSpat.UseVisualStyleBackColor = false;
            this.buttonSpat.Visible = false;
            this.buttonSpat.Click += new System.EventHandler(this.buttonSpat_Click);
            // 
            // buttonZrus
            // 
            this.buttonZrus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZrus.FlatAppearance.BorderSize = 0;
            this.buttonZrus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZrus.Image = ((System.Drawing.Image)(resources.GetObject("buttonZrus.Image")));
            this.buttonZrus.Location = new System.Drawing.Point(1506, 19);
            this.buttonZrus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZrus.Name = "buttonZrus";
            this.buttonZrus.Size = new System.Drawing.Size(36, 28);
            this.buttonZrus.TabIndex = 6;
            this.buttonZrus.UseVisualStyleBackColor = true;
            this.buttonZrus.Click += new System.EventHandler(this.buttonZrus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Názov Appky";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Aplikacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1009);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Aplikacia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikácia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Button buttonNacitatData;
        private System.Windows.Forms.Button buttonNacitatProjekt;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonSpat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMinimalizuj;
        //private System.Windows.Forms.Button buttonZvacsi;
        private System.Windows.Forms.Button buttonZrus;
        private Button buttonNastavenia;
    }
}

