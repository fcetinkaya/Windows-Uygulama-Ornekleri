namespace Ayakkabi_Imalat_Takip
{
    partial class TekliIsPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TekliIsPersonel));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.takipnotxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.ucretxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.prsnl = new System.Windows.Forms.ComboBox();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.takipgrp = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tnotxt = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6.SuspendLayout();
            this.takipgrp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.takipnotxt);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.ucretxt);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.prsnl);
            this.groupBox6.Location = new System.Drawing.Point(6, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(338, 154);
            this.groupBox6.TabIndex = 49;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Personel İşlemleri";
            // 
            // takipnotxt
            // 
            this.takipnotxt.AutoSize = true;
            this.takipnotxt.Location = new System.Drawing.Point(198, 22);
            this.takipnotxt.Name = "takipnotxt";
            this.takipnotxt.Size = new System.Drawing.Size(0, 13);
            this.takipnotxt.TabIndex = 47;
            this.takipnotxt.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "İş Takip Form Numarası : ";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Image = global::Ayakkabi_Imalat_Takip.Properties.Resources.bilgiler;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(201, 16);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.button4.Size = new System.Drawing.Size(124, 25);
            this.button4.TabIndex = 46;
            this.button4.Text = "Takip No Seç";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ucretxt
            // 
            this.ucretxt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ucretxt.Location = new System.Drawing.Point(201, 83);
            this.ucretxt.Name = "ucretxt";
            this.ucretxt.Size = new System.Drawing.Size(124, 20);
            this.ucretxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(198, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ödenen Ücret";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(2, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(114, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Personel Ad Soyad";
            // 
            // prsnl
            // 
            this.prsnl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.prsnl.FormattingEnabled = true;
            this.prsnl.Location = new System.Drawing.Point(5, 83);
            this.prsnl.Name = "prsnl";
            this.prsnl.Size = new System.Drawing.Size(175, 21);
            this.prsnl.TabIndex = 12;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Personel Ad Soyad";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ödenen Ücret";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiş No";
            this.columnHeader2.Width = 96;
            // 
            // takipgrp
            // 
            this.takipgrp.Controls.Add(this.listBox1);
            this.takipgrp.Controls.Add(this.tnotxt);
            this.takipgrp.Location = new System.Drawing.Point(350, 7);
            this.takipgrp.Name = "takipgrp";
            this.takipgrp.Size = new System.Drawing.Size(106, 154);
            this.takipgrp.TabIndex = 54;
            this.takipgrp.TabStop = false;
            this.takipgrp.Text = "Takip Numarası";
            this.takipgrp.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Aqua;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(94, 108);
            this.listBox1.TabIndex = 17;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // tnotxt
            // 
            this.tnotxt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tnotxt.Location = new System.Drawing.Point(6, 15);
            this.tnotxt.Name = "tnotxt";
            this.tnotxt.Size = new System.Drawing.Size(94, 20);
            this.tnotxt.TabIndex = 16;
            this.tnotxt.Leave += new System.EventHandler(this.tnotxt_Leave);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Takip No";
            this.columnHeader1.Width = 90;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(5, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(439, 292);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 317);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistemde Kayıtlı Personel Ücretlendirmeleri";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Image = global::Ayakkabi_Imalat_Takip.Properties.Resources.page_white_delete;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(350, 61);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.button2.Size = new System.Drawing.Size(106, 50);
            this.button2.TabIndex = 51;
            this.button2.Text = "Temizle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Image = global::Ayakkabi_Imalat_Takip.Properties.Resources.kapat;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(350, 111);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.button3.Size = new System.Drawing.Size(106, 50);
            this.button3.TabIndex = 52;
            this.button3.Text = "Vazgeç";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = global::Ayakkabi_Imalat_Takip.Properties.Resources.page_save;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(350, 10);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.button1.Size = new System.Drawing.Size(106, 50);
            this.button1.TabIndex = 50;
            this.button1.Text = "Kaydet";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TekliIsPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 493);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.takipgrp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TekliIsPersonel";
            this.Text = "Tekli Personel Ücretlendirme";
            this.Load += new System.EventHandler(this.TekliIsPersonel_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.takipgrp.ResumeLayout(false);
            this.takipgrp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label takipnotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox ucretxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox prsnl;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox takipgrp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tnotxt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}