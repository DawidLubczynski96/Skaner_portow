namespace Skaner_portow
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
            this.przycisk_skanuj = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // przycisk_skanuj
            // 
            this.przycisk_skanuj.Location = new System.Drawing.Point(32, 338);
            this.przycisk_skanuj.Name = "przycisk_skanuj";
            this.przycisk_skanuj.Size = new System.Drawing.Size(398, 39);
            this.przycisk_skanuj.TabIndex = 0;
            this.przycisk_skanuj.Text = "Skanuj";
            this.przycisk_skanuj.UseVisualStyleBackColor = true;
            this.przycisk_skanuj.Click += new System.EventHandler(this.przycisk_skanuj_Click);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(32, 23);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(398, 20);
            this.adres.TabIndex = 1;
            // 
            // info
            // 
            this.info.FormattingEnabled = true;
            this.info.Location = new System.Drawing.Point(32, 67);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(398, 251);
            this.info.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 398);
            this.Controls.Add(this.info);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.przycisk_skanuj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przycisk_skanuj;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.ListBox info;
    }
}

