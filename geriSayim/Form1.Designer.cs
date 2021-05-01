namespace geriSayim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDakika = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldurum = new System.Windows.Forms.Label();
            this.cmbSaniye = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGun = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbsecim = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbSaat
            // 
            this.cmbSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Location = new System.Drawing.Point(97, 42);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(121, 21);
            this.cmbSaat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saat";
            // 
            // cmbDakika
            // 
            this.cmbDakika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDakika.FormattingEnabled = true;
            this.cmbDakika.Location = new System.Drawing.Point(97, 73);
            this.cmbDakika.Name = "cmbDakika";
            this.cmbDakika.Size = new System.Drawing.Size(121, 21);
            this.cmbDakika.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dakika";
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Location = new System.Drawing.Point(12, 203);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(73, 13);
            this.lbldurum.TabIndex = 5;
            this.lbldurum.Text = "Kalan Zaman:";
            // 
            // cmbSaniye
            // 
            this.cmbSaniye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaniye.FormattingEnabled = true;
            this.cmbSaniye.Location = new System.Drawing.Point(97, 100);
            this.cmbSaniye.Name = "cmbSaniye";
            this.cmbSaniye.Size = new System.Drawing.Size(121, 21);
            this.cmbSaniye.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Saniye";
            // 
            // cmbGun
            // 
            this.cmbGun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGun.FormattingEnabled = true;
            this.cmbGun.Location = new System.Drawing.Point(97, 12);
            this.cmbGun.Name = "cmbGun";
            this.cmbGun.Size = new System.Drawing.Size(121, 21);
            this.cmbGun.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gün";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yapılacak";
            // 
            // cmbsecim
            // 
            this.cmbsecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsecim.FormattingEnabled = true;
            this.cmbsecim.Items.AddRange(new object[] {
            "Bilgisayarı Kapat",
            "Yeniden Başlat"});
            this.cmbsecim.Location = new System.Drawing.Point(97, 127);
            this.cmbsecim.Name = "cmbsecim";
            this.cmbsecim.Size = new System.Drawing.Size(121, 21);
            this.cmbsecim.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 227);
            this.Controls.Add(this.cmbsecim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSaniye);
            this.Controls.Add(this.lbldurum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDakika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Geri Sayım";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDakika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.ComboBox cmbSaniye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbsecim;
    }
}

