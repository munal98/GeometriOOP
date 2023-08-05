namespace GeometriDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbSekil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pDikdortgen = new System.Windows.Forms.Panel();
            this.tbKisaKenar = new System.Windows.Forms.TextBox();
            this.tbUzunKenar = new System.Windows.Forms.TextBox();
            this.pDikUcgen = new System.Windows.Forms.Panel();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.tbTaban = new System.Windows.Forms.TextBox();
            this.pHesapla = new System.Windows.Forms.Panel();
            this.lSonuc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHesapla = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pKare = new System.Windows.Forms.Panel();
            this.tbKareKenar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pEskenarUcgen = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEskenarUcgenKenar = new System.Windows.Forms.TextBox();
            this.pDaire = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbYariCap = new System.Windows.Forms.TextBox();
            this.pDikdortgen.SuspendLayout();
            this.pDikUcgen.SuspendLayout();
            this.pHesapla.SuspendLayout();
            this.pKare.SuspendLayout();
            this.pEskenarUcgen.SuspendLayout();
            this.pDaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şekil";
            // 
            // cbSekil
            // 
            this.cbSekil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSekil.FormattingEnabled = true;
            this.cbSekil.Location = new System.Drawing.Point(84, 12);
            this.cbSekil.Name = "cbSekil";
            this.cbSekil.Size = new System.Drawing.Size(219, 21);
            this.cbSekil.TabIndex = 1;
            this.cbSekil.SelectedIndexChanged += new System.EventHandler(this.cbSekil_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uzun Kenar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kısa Kenar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Taban";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Yükseklik";
            // 
            // pDikdortgen
            // 
            this.pDikdortgen.Controls.Add(this.tbKisaKenar);
            this.pDikdortgen.Controls.Add(this.tbUzunKenar);
            this.pDikdortgen.Controls.Add(this.label2);
            this.pDikdortgen.Controls.Add(this.label3);
            this.pDikdortgen.Location = new System.Drawing.Point(15, 100);
            this.pDikdortgen.Name = "pDikdortgen";
            this.pDikdortgen.Size = new System.Drawing.Size(291, 55);
            this.pDikdortgen.TabIndex = 6;
            // 
            // tbKisaKenar
            // 
            this.tbKisaKenar.Location = new System.Drawing.Point(72, 29);
            this.tbKisaKenar.Name = "tbKisaKenar";
            this.tbKisaKenar.Size = new System.Drawing.Size(216, 20);
            this.tbKisaKenar.TabIndex = 5;
            // 
            // tbUzunKenar
            // 
            this.tbUzunKenar.Location = new System.Drawing.Point(72, 3);
            this.tbUzunKenar.Name = "tbUzunKenar";
            this.tbUzunKenar.Size = new System.Drawing.Size(216, 20);
            this.tbUzunKenar.TabIndex = 4;
            // 
            // pDikUcgen
            // 
            this.pDikUcgen.Controls.Add(this.tbYukseklik);
            this.pDikUcgen.Controls.Add(this.label4);
            this.pDikUcgen.Controls.Add(this.tbTaban);
            this.pDikUcgen.Controls.Add(this.label5);
            this.pDikUcgen.Location = new System.Drawing.Point(15, 223);
            this.pDikUcgen.Name = "pDikUcgen";
            this.pDikUcgen.Size = new System.Drawing.Size(291, 56);
            this.pDikUcgen.TabIndex = 7;
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.Location = new System.Drawing.Point(72, 29);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(216, 20);
            this.tbYukseklik.TabIndex = 7;
            // 
            // tbTaban
            // 
            this.tbTaban.Location = new System.Drawing.Point(72, 3);
            this.tbTaban.Name = "tbTaban";
            this.tbTaban.Size = new System.Drawing.Size(216, 20);
            this.tbTaban.TabIndex = 6;
            // 
            // pHesapla
            // 
            this.pHesapla.Controls.Add(this.lSonuc);
            this.pHesapla.Controls.Add(this.label6);
            this.pHesapla.Controls.Add(this.cbHesapla);
            this.pHesapla.Controls.Add(this.button1);
            this.pHesapla.Location = new System.Drawing.Point(15, 347);
            this.pHesapla.Name = "pHesapla";
            this.pHesapla.Size = new System.Drawing.Size(291, 61);
            this.pHesapla.TabIndex = 8;
            // 
            // lSonuc
            // 
            this.lSonuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lSonuc.Location = new System.Drawing.Point(66, 31);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(222, 23);
            this.lSonuc.TabIndex = 15;
            this.lSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sonuç";
            // 
            // cbHesapla
            // 
            this.cbHesapla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHesapla.FormattingEnabled = true;
            this.cbHesapla.Items.AddRange(new object[] {
            "-- Seçiniz --",
            "Çevre",
            "Alan"});
            this.cbHesapla.Location = new System.Drawing.Point(6, 5);
            this.cbHesapla.Name = "cbHesapla";
            this.cbHesapla.Size = new System.Drawing.Size(201, 21);
            this.cbHesapla.TabIndex = 13;
            this.cbHesapla.SelectedIndexChanged += new System.EventHandler(this.cbHesapla_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pKare
            // 
            this.pKare.Controls.Add(this.tbKareKenar);
            this.pKare.Controls.Add(this.label7);
            this.pKare.Location = new System.Drawing.Point(15, 39);
            this.pKare.Name = "pKare";
            this.pKare.Size = new System.Drawing.Size(291, 55);
            this.pKare.TabIndex = 9;
            // 
            // tbKareKenar
            // 
            this.tbKareKenar.Location = new System.Drawing.Point(72, 15);
            this.tbKareKenar.Name = "tbKareKenar";
            this.tbKareKenar.Size = new System.Drawing.Size(216, 20);
            this.tbKareKenar.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kenar";
            // 
            // pEskenarUcgen
            // 
            this.pEskenarUcgen.Controls.Add(this.label8);
            this.pEskenarUcgen.Controls.Add(this.tbEskenarUcgenKenar);
            this.pEskenarUcgen.Location = new System.Drawing.Point(15, 161);
            this.pEskenarUcgen.Name = "pEskenarUcgen";
            this.pEskenarUcgen.Size = new System.Drawing.Size(291, 56);
            this.pEskenarUcgen.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Kenar";
            // 
            // tbEskenarUcgenKenar
            // 
            this.tbEskenarUcgenKenar.Location = new System.Drawing.Point(72, 15);
            this.tbEskenarUcgenKenar.Name = "tbEskenarUcgenKenar";
            this.tbEskenarUcgenKenar.Size = new System.Drawing.Size(216, 20);
            this.tbEskenarUcgenKenar.TabIndex = 6;
            // 
            // pDaire
            // 
            this.pDaire.Controls.Add(this.label9);
            this.pDaire.Controls.Add(this.tbYariCap);
            this.pDaire.Location = new System.Drawing.Point(15, 285);
            this.pDaire.Name = "pDaire";
            this.pDaire.Size = new System.Drawing.Size(291, 56);
            this.pDaire.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Yarı Çap";
            // 
            // tbYariCap
            // 
            this.tbYariCap.Location = new System.Drawing.Point(72, 15);
            this.tbYariCap.Name = "tbYariCap";
            this.tbYariCap.Size = new System.Drawing.Size(216, 20);
            this.tbYariCap.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 416);
            this.Controls.Add(this.pDaire);
            this.Controls.Add(this.pEskenarUcgen);
            this.Controls.Add(this.pKare);
            this.Controls.Add(this.pHesapla);
            this.Controls.Add(this.pDikUcgen);
            this.Controls.Add(this.pDikdortgen);
            this.Controls.Add(this.cbSekil);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Geometri İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pDikdortgen.ResumeLayout(false);
            this.pDikdortgen.PerformLayout();
            this.pDikUcgen.ResumeLayout(false);
            this.pDikUcgen.PerformLayout();
            this.pHesapla.ResumeLayout(false);
            this.pHesapla.PerformLayout();
            this.pKare.ResumeLayout(false);
            this.pKare.PerformLayout();
            this.pEskenarUcgen.ResumeLayout(false);
            this.pEskenarUcgen.PerformLayout();
            this.pDaire.ResumeLayout(false);
            this.pDaire.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSekil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pDikdortgen;
        private System.Windows.Forms.TextBox tbKisaKenar;
        private System.Windows.Forms.TextBox tbUzunKenar;
        private System.Windows.Forms.Panel pDikUcgen;
        private System.Windows.Forms.TextBox tbYukseklik;
        private System.Windows.Forms.TextBox tbTaban;
        private System.Windows.Forms.Panel pHesapla;
        private System.Windows.Forms.Label lSonuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbHesapla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pKare;
        private System.Windows.Forms.TextBox tbKareKenar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pEskenarUcgen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEskenarUcgenKenar;
        private System.Windows.Forms.Panel pDaire;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbYariCap;
    }
}

