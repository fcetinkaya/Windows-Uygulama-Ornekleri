namespace TaseronTakip
{
    partial class PersonelMaasRaporlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelMaasRaporlari));
            this.Raporlabtn = new System.Windows.Forms.Button();
            this.personelcombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SenecomboBox = new System.Windows.Forms.ComboBox();
            this.AycomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Raporlabtn
            // 
            this.Raporlabtn.Location = new System.Drawing.Point(133, 60);
            this.Raporlabtn.Name = "Raporlabtn";
            this.Raporlabtn.Size = new System.Drawing.Size(104, 23);
            this.Raporlabtn.TabIndex = 14;
            this.Raporlabtn.Text = "Raporla";
            this.Raporlabtn.UseVisualStyleBackColor = true;
            this.Raporlabtn.Click += new System.EventHandler(this.Raporlabtn_Click);
            // 
            // personelcombo
            // 
            this.personelcombo.FormattingEnabled = true;
            this.personelcombo.Location = new System.Drawing.Point(133, 8);
            this.personelcombo.Name = "personelcombo";
            this.personelcombo.Size = new System.Drawing.Size(104, 21);
            this.personelcombo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Personel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Maaş Tarihi (Ay.Yıl)";
            // 
            // SenecomboBox
            // 
            this.SenecomboBox.FormattingEnabled = true;
            this.SenecomboBox.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.SenecomboBox.Location = new System.Drawing.Point(191, 34);
            this.SenecomboBox.Name = "SenecomboBox";
            this.SenecomboBox.Size = new System.Drawing.Size(46, 21);
            this.SenecomboBox.TabIndex = 15;
            // 
            // AycomboBox
            // 
            this.AycomboBox.FormattingEnabled = true;
            this.AycomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.AycomboBox.Location = new System.Drawing.Point(133, 34);
            this.AycomboBox.Name = "AycomboBox";
            this.AycomboBox.Size = new System.Drawing.Size(52, 21);
            this.AycomboBox.TabIndex = 16;
            // 
            // PersonelMaasRaporlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 91);
            this.Controls.Add(this.SenecomboBox);
            this.Controls.Add(this.AycomboBox);
            this.Controls.Add(this.Raporlabtn);
            this.Controls.Add(this.personelcombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonelMaasRaporlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Maaş Raporları";
            this.Load += new System.EventHandler(this.PersonelMaasRaporlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Raporlabtn;
        private System.Windows.Forms.ComboBox personelcombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SenecomboBox;
        private System.Windows.Forms.ComboBox AycomboBox;
    }
}