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
            this.SuspendLayout();
            // 
            // buttonNacitatData
            // 
            this.buttonNacitatData.Location = new System.Drawing.Point(193, 167);
            this.buttonNacitatData.Name = "buttonNacitatData";
            this.buttonNacitatData.Size = new System.Drawing.Size(137, 43);
            this.buttonNacitatData.TabIndex = 0;
            this.buttonNacitatData.Text = "Načítať dáta";
            this.buttonNacitatData.UseVisualStyleBackColor = true;
            this.buttonNacitatData.Click += new System.EventHandler(this.buttonNacitatData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNacitatData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNacitatData;
    }
}

