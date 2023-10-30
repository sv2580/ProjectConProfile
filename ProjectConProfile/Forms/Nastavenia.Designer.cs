using System;

namespace ProjectConProfile.Forms
{
    partial class Nastavenia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nastavenia));
            this.buttonMinimalizuj1 = new System.Windows.Forms.Button();
            this.buttonZrus1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNastavenia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxPriecinokProjekty = new System.Windows.Forms.TextBox();
            this.boxPriecinokData = new System.Windows.Forms.TextBox();
            this.boxSuborFaktory = new System.Windows.Forms.TextBox();
            this.buttonZmenitSuborFaktory = new System.Windows.Forms.Button();
            this.buttonZmenitPriecinokData = new System.Windows.Forms.Button();
            this.buttonZmenitOdkazUkladania = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMinimalizuj1
            // 
            this.buttonMinimalizuj1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimalizuj1.FlatAppearance.BorderSize = 0;
            this.buttonMinimalizuj1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimalizuj1.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimalizuj1.Image")));
            this.buttonMinimalizuj1.Location = new System.Drawing.Point(443, 7);
            this.buttonMinimalizuj1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMinimalizuj1.Name = "buttonMinimalizuj1";
            this.buttonMinimalizuj1.Size = new System.Drawing.Size(39, 28);
            this.buttonMinimalizuj1.TabIndex = 9;
            this.buttonMinimalizuj1.UseVisualStyleBackColor = true;
            // 
            // buttonZrus1
            // 
            this.buttonZrus1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZrus1.FlatAppearance.BorderSize = 0;
            this.buttonZrus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZrus1.Image = ((System.Drawing.Image)(resources.GetObject("buttonZrus1.Image")));
            this.buttonZrus1.Location = new System.Drawing.Point(490, 7);
            this.buttonZrus1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZrus1.Name = "buttonZrus1";
            this.buttonZrus1.Size = new System.Drawing.Size(36, 28);
            this.buttonZrus1.TabIndex = 7;
            this.buttonZrus1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelNastavenia);
            this.panel1.Controls.Add(this.buttonMinimalizuj1);
            this.panel1.Controls.Add(this.buttonZrus1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 74);
            this.panel1.TabIndex = 10;
            // 
            // labelNastavenia
            // 
            this.labelNastavenia.AutoSize = true;
            this.labelNastavenia.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNastavenia.ForeColor = System.Drawing.Color.White;
            this.labelNastavenia.Location = new System.Drawing.Point(12, 23);
            this.labelNastavenia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNastavenia.Name = "labelNastavenia";
            this.labelNastavenia.Size = new System.Drawing.Size(151, 29);
            this.labelNastavenia.TabIndex = 10;
            this.labelNastavenia.Text = "Nastavenia";
            this.labelNastavenia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelNastavenia.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(101, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Odkaz k súboru s uloženými faktormi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(88, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Odkaz k priečinku kde sú uložené dáta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(95, 386);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Odkaz kde sa majú ukladať projekty";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // boxPriecinokProjekty
            // 
            this.boxPriecinokProjekty.Location = new System.Drawing.Point(68, 442);
            this.boxPriecinokProjekty.Name = "boxPriecinokProjekty";
            this.boxPriecinokProjekty.ReadOnly = true;
            this.boxPriecinokProjekty.Size = new System.Drawing.Size(302, 22);
            this.boxPriecinokProjekty.TabIndex = 16;
            this.boxPriecinokProjekty.Text = "Vybrať";
            // 
            // boxPriecinokData
            // 
            this.boxPriecinokData.Location = new System.Drawing.Point(68, 308);
            this.boxPriecinokData.Name = "boxPriecinokData";
            this.boxPriecinokData.ReadOnly = true;
            this.boxPriecinokData.Size = new System.Drawing.Size(302, 22);
            this.boxPriecinokData.TabIndex = 15;
            this.boxPriecinokData.Text = "Vybrať";
            // 
            // boxSuborFaktory
            // 
            this.boxSuborFaktory.BackColor = System.Drawing.SystemColors.HighlightText;
            this.boxSuborFaktory.Location = new System.Drawing.Point(68, 168);
            this.boxSuborFaktory.Name = "boxSuborFaktory";
            this.boxSuborFaktory.Size = new System.Drawing.Size(302, 22);
            this.boxSuborFaktory.TabIndex = 14;
            this.boxSuborFaktory.Text = "Vybrať";
            // 
            // buttonZmenitSuborFaktory
            // 
            this.buttonZmenitSuborFaktory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonZmenitSuborFaktory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZmenitSuborFaktory.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZmenitSuborFaktory.ForeColor = System.Drawing.Color.White;
            this.buttonZmenitSuborFaktory.Location = new System.Drawing.Point(393, 161);
            this.buttonZmenitSuborFaktory.Name = "buttonZmenitSuborFaktory";
            this.buttonZmenitSuborFaktory.Size = new System.Drawing.Size(90, 36);
            this.buttonZmenitSuborFaktory.TabIndex = 18;
            this.buttonZmenitSuborFaktory.Text = "Zmeniť";
            this.buttonZmenitSuborFaktory.UseVisualStyleBackColor = false;
            this.buttonZmenitSuborFaktory.Click += new System.EventHandler(this.buttonZmenitSuborFaktory_Click);
            // 
            // buttonZmenitPriecinokData
            // 
            this.buttonZmenitPriecinokData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonZmenitPriecinokData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZmenitPriecinokData.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZmenitPriecinokData.ForeColor = System.Drawing.Color.White;
            this.buttonZmenitPriecinokData.Location = new System.Drawing.Point(393, 301);
            this.buttonZmenitPriecinokData.Name = "buttonZmenitPriecinokData";
            this.buttonZmenitPriecinokData.Size = new System.Drawing.Size(90, 36);
            this.buttonZmenitPriecinokData.TabIndex = 19;
            this.buttonZmenitPriecinokData.Text = "Zmeniť";
            this.buttonZmenitPriecinokData.UseVisualStyleBackColor = false;
            this.buttonZmenitPriecinokData.Click += new System.EventHandler(this.buttonZmenitPriecinokData_Click);
            // 
            // buttonZmenitOdkazUkladania
            // 
            this.buttonZmenitOdkazUkladania.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonZmenitOdkazUkladania.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZmenitOdkazUkladania.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZmenitOdkazUkladania.ForeColor = System.Drawing.Color.White;
            this.buttonZmenitOdkazUkladania.Location = new System.Drawing.Point(393, 435);
            this.buttonZmenitOdkazUkladania.Name = "buttonZmenitOdkazUkladania";
            this.buttonZmenitOdkazUkladania.Size = new System.Drawing.Size(90, 36);
            this.buttonZmenitOdkazUkladania.TabIndex = 20;
            this.buttonZmenitOdkazUkladania.Text = "Zmeniť";
            this.buttonZmenitOdkazUkladania.UseVisualStyleBackColor = false;
            this.buttonZmenitOdkazUkladania.Click += new System.EventHandler(this.buttonZmenitOdkazUkladania_Click);
            // 
            // Nastavenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(532, 530);
            this.Controls.Add(this.buttonZmenitOdkazUkladania);
            this.Controls.Add(this.buttonZmenitPriecinokData);
            this.Controls.Add(this.buttonZmenitSuborFaktory);
            this.Controls.Add(this.boxPriecinokProjekty);
            this.Controls.Add(this.boxPriecinokData);
            this.Controls.Add(this.boxSuborFaktory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Nastavenia";
            this.Text = "Nastavenia";
            this.Load += new System.EventHandler(this.Nastavenia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

 
        #endregion

        private System.Windows.Forms.Button buttonMinimalizuj1;
        private System.Windows.Forms.Button buttonZrus1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNastavenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxPriecinokProjekty;
        private System.Windows.Forms.TextBox boxPriecinokData;
        private System.Windows.Forms.TextBox boxSuborFaktory;
        private System.Windows.Forms.Button buttonZmenitSuborFaktory;
        private System.Windows.Forms.Button buttonZmenitPriecinokData;
        private System.Windows.Forms.Button buttonZmenitOdkazUkladania;
    }
}