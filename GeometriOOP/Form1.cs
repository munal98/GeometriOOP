using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace GeometriDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSekil.Items.Add("-- Seçiniz --"); // index 0
            cbSekil.Items.Add("Kare"); // index 1
            cbSekil.Items.Add("Dikdörtgen"); // index 2
            cbSekil.Items.Add("Eşkenar Üçgen"); // index 3
            cbSekil.Items.Add("Dik Üçgen"); // index 4
            cbSekil.Items.Add("Daire"); // index 5
            cbSekil.SelectedIndex = 0;
            pKare.Visible = false;
            pDikdortgen.Visible = false;
            pEskenarUcgen.Visible = false;
            pDikUcgen.Visible = false;
            pDaire.Visible = false;
            Point point = new Point();
            point.X = 12;
            point.Y = 39;
            pDikdortgen.Location = point;
            pEskenarUcgen.Location = point;
            pDikUcgen.Location = point;
            pDaire.Location = point;
            point.X = 12;
            point.Y = 100;
            pHesapla.Location = point;
            Size size = new Size();
            size.Width = this.Width;
            size.Height = 200;
            this.Size = size;
            cbHesapla.SelectedIndex = 0;
        }

        private void cbSekil_SelectedIndexChanged(object sender, EventArgs e)
        {
            lSonuc.Text = "";
            pKare.Visible = false;
            pDikdortgen.Visible = false;
            pEskenarUcgen.Visible = false;
            pDikUcgen.Visible = false;
            pDaire.Visible = false;
            if (cbSekil.SelectedIndex == 1)
            {
                pKare.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 2)
            {
                pDikdortgen.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 3)
            {
                pEskenarUcgen.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 4)
            {
                pDikUcgen.Visible = true;
            }
            else if (cbSekil.SelectedIndex == 5)
            {
                pDaire.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lSonuc.Text = "";
            try
            {
                if (cbSekil.SelectedIndex != 0 && cbHesapla.SelectedIndex != 0)
                {
                    double sonuc = 0;
                    if (cbSekil.SelectedIndex == 1) // Kare
                    {
                        if (tbKareKenar.Text == "")
                        {
                            MessageBox.Show("Lütfen değerleri eksiksiz girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            Kare kare = new Kare();
                            kare.UzunKenar = Convert.ToDouble(tbKareKenar.Text, new CultureInfo("tr"));
                            if (cbHesapla.SelectedIndex == 1) // Çevre
                            {
                                sonuc = kare.CevreHesapla();
                            }
                            else // Alan
                            {
                                sonuc = kare.AlanHesapla();
                            }
                            lSonuc.Text = sonuc.ToString(new CultureInfo("tr"));
                        }
                    }
                    else if (cbSekil.SelectedIndex == 2) // Dikdörtgen
                    {
                        if (tbUzunKenar.Text == "" || tbKisaKenar.Text == "")
                        {
                            MessageBox.Show("Lütfen değerleri eksiksiz girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            Dikdortgen dikdortgen = new Dikdortgen();
                            dikdortgen.UzunKenar = Convert.ToDouble(tbUzunKenar.Text, new CultureInfo("tr"));
                            dikdortgen.KisaKenar = Convert.ToDouble(tbKisaKenar.Text, new CultureInfo("tr"));
                            if (cbHesapla.SelectedIndex == 1) // Çevre
                            {
                                sonuc = dikdortgen.CevreHesapla();
                            }
                            else // Alan
                            {
                                sonuc = dikdortgen.AlanHesapla();
                            }
                            lSonuc.Text = sonuc.ToString(new CultureInfo("tr"));
                        }
                    }
                    else if (cbSekil.SelectedIndex == 3) // Eşkenar üçgen
                    {
                        if (tbEskenarUcgenKenar.Text == "")
                        {
                            MessageBox.Show("Lütfen değerleri eksiksiz girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            EskenarUcgen eskenarUcgen = new EskenarUcgen();
                            eskenarUcgen.TabanKenar = Convert.ToDouble(tbEskenarUcgenKenar.Text, new CultureInfo("tr"));
                            if (cbHesapla.SelectedIndex == 1) // Çevre
                            {
                                sonuc = eskenarUcgen.CevreHesapla();
                            }
                            else // Alan
                            {
                                sonuc = eskenarUcgen.AlanHesapla();
                            }
                            lSonuc.Text = sonuc.ToString(new CultureInfo("tr"));
                        }
                    }
                    else if (cbSekil.SelectedIndex == 4) // Dik üçgen
                    {
                        if (tbTaban.Text == "" || tbYukseklik.Text == "")
                        {
                            MessageBox.Show("Lütfen değerleri eksiksiz girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            DikUcgen dikUcgen = new DikUcgen();
                            dikUcgen.TabanKenar = Convert.ToDouble(tbTaban.Text, new CultureInfo("tr"));
                            dikUcgen.Yukseklik = Convert.ToDouble(tbYukseklik.Text, new CultureInfo("tr"));
                            if (cbHesapla.SelectedIndex == 1) // Çevre
                            {
                                sonuc = dikUcgen.CevreHesapla();
                            }
                            else // Alan
                            {
                                sonuc = dikUcgen.AlanHesapla();
                            }
                            lSonuc.Text = sonuc.ToString(new CultureInfo("tr"));
                        }
                    }
                    else // Daire
                    {
                        if (tbYariCap.Text == "")
                        {
                            MessageBox.Show("Lütfen değerleri eksiksiz girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            Daire daire = new Daire();
                            daire.YariCap = Convert.ToDouble(tbYariCap.Text, new CultureInfo("tr"));
                            if (cbHesapla.SelectedIndex == 1) // Çevre
                            {
                                sonuc = daire.CevreHesapla();
                            }
                            else // Alan
                            {
                                sonuc = daire.AlanHesapla();
                            }
                            lSonuc.Text = sonuc.ToString(new CultureInfo("tr"));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen şekil ve hesaplama seçimlerini yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("İşlem sırasında hata meydana geldi! Lütfen girdiğiniz değerleri kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbHesapla_SelectedIndexChanged(object sender, EventArgs e)
        {
            lSonuc.Text = "";
        }
    }
}
