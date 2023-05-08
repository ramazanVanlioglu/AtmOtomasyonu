using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmOtomasyonu
{
    public partial class Ana_Menü : Form
    {
        Form1 form1 = new Form1();//Giriş ekranına dönme işlemi
        Musteri MusteriHesabi = new Musteri();
        public Ana_Menü(Musteri _musteri)
        {
            InitializeComponent();
            MusteriHesabi = _musteri;
        }


        private void Ana_Menü_Load(object sender, EventArgs e)
        {
            
            label_bakiye.Text = MusteriHesabi.Bakiye.ToString() + " ₺";
            label_isim.Text = MusteriHesabi.Isim.ToString() + " " + MusteriHesabi.Soyisim + ".";
            DovizKarsiliklari();
        }
        public void DovizKarsiliklari()
        {
            label_dolar.Text = "Dolar karşılığı: " + MusteriHesabi.BakiyeninEuroKarsiligi() + " $";
            label_euro.Text = "Euro karşılığı: " + MusteriHesabi.BakiyeninEuroKarsiligi() + " €";
        }

        private void button_cikisYap_Click(object sender, EventArgs e)
        {
            DialogResult isExit = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (isExit == DialogResult.Yes)
            {
                MessageBox.Show("Çıkış yapılıyor...\nAna menüye yönlendiriliyorsunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                form1.Show();
            }
        }

        private void button_paraCek_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag is "1" || control.Tag is "2")
                {
                    control.Visible = false;
                }                                     //Elemanları görüntüleme // Visualizing the controls of the panel
                else if (control.Tag is "0")
                {
                    control.Visible = true;
                }
            }

        }

        private void button_paraCekOnay_Click(object sender, EventArgs e)
        {

            DialogResult decision = MessageBox.Show("İşlemi gerçekleştirmek istiyor musunuz?", "İşlem Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (decision == DialogResult.Yes)
            {
                if (Convert.ToInt32(textBox_cekilecekMiktar.Text) > 0)
                {

                    if (MusteriHesabi.Bakiye >= Convert.ToDouble(textBox_cekilecekMiktar.Text) && MusteriHesabi.Bakiye > 0 && Int32.TryParse(textBox_cekilecekMiktar.Text, out _))
                    {
                        MusteriHesabi.Bakiye -= Convert.ToDouble(textBox_cekilecekMiktar.Text);
                        label_bakiye.Text = MusteriHesabi.Bakiye.ToString() + " ₺";
                        MessageBox.Show("Para çekme işlemi başarılı bir şekilde gerçekleşmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView_Durumlar.Rows.Add("Para Çekme", DateTime.UtcNow.ToString(), MusteriHesabi.Isim + " " + MusteriHesabi.Soyisim);//DataGridView'e birtakım bilgiler eklendi.// Some sort of informations added to DataGridView.//

                        richTextBox_durum.Text += "Para çekildi. Çekilen miktar: " + textBox_cekilecekMiktar.Text + " TL\n";
                        DovizKarsiliklari();
                    }
                    else
                    {
                        MessageBox.Show("Hesabınızda yeterli miktarda nakit bulunmamaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Para miktarı düzgün girilmelidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }




        private void button_paraYatir_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag is "0" || control.Tag is "2")
                {
                    control.Visible = false;
                }                                          //Elemanları görüntüleme // Visualizing the controls of the panel
                else if (control.Tag is "1")
                {
                    control.Visible = true;
                }
            }



        }
        private void button_paraYatirOnay_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("Para yatırma işlemini onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (decision == DialogResult.Yes)
            {
                if (Int32.TryParse(textBox_yatirilacakMiktar.Text, out _))
                {
                    MessageBox.Show("Para yatırma işlemi başarılı bir şekilde tamamlandı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MusteriHesabi.Bakiye += Convert.ToDouble(textBox_yatirilacakMiktar.Text);
                    label_bakiye.Text = MusteriHesabi.Bakiye.ToString() + " ₺";

                    richTextBox_durum.Text += "Para yatırıldı. Yatırılan miktar: " + textBox_yatirilacakMiktar.Text + " TL\n";
                    dataGridView_Durumlar.Rows.Add("Para Yatırma", DateTime.UtcNow.ToString(), MusteriHesabi.Isim + " " + MusteriHesabi.Soyisim);//DataGridView'e birtakım bilgiler eklendi.// Some sort of informations added to DataGridView.//

                    DovizKarsiliklari();
                }
                else
                {
                    MessageBox.Show("Para miktarı rakamlardan oluşmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }



        private void button_paraGonder_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag is "0" || control.Tag is "1")
                {
                    control.Visible = false;
                    //Elemanları görüntüleme // Visualizing the controls of the panel
                }
                else if (control.Tag is "2")
                {
                    control.Visible = true;
                }
            }
        }

        private void button_paraGonderOnay_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox_gonderilecekKartNumara.Text, out double _) && textBox_gonderilecekKartNumara.Text.Length == MusteriHesabi.KrediKartiHaneSayisi)
            {
                if (MusteriHesabi.Bakiye >= Convert.ToDouble(textBox_gonderilecekMiktar.Text))
                {
                    DialogResult decision = MessageBox.Show("Havale işlemleri "+MusteriHesabi.HavaleUcreti+" KRŞ tutmaktadır.\nGönderme işlemini gerçekleştirmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (decision == DialogResult.Yes)
                    {
                        MusteriHesabi.Bakiye -= (Convert.ToDouble(textBox_gonderilecekMiktar.Text)+MusteriHesabi.HavaleUcreti);
                        label_bakiye.Text = MusteriHesabi.Bakiye.ToString() + " ₺";
                        string krediKarti = string.Empty;//Kredi kartı hanelerinin görünüme güzellik katıyoruz. // We're putting some icing on a cake which is adding qualities for the credit card digits(Adding "-" between 4 numbers:).
                        for (int i = 0; i < textBox_gonderilecekKartNumara.Text.Length; ++i)
                        {
                            if (i % 4 == 0 && i != 0)
                            {
                                krediKarti += "-";

                            }

                            krediKarti += textBox_gonderilecekKartNumara.Text[i];


                        }
                        MessageBox.Show("İşleminiz başarılı bir şekilde gerçekleşmiştir.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        richTextBox_durum.Text += "Para gönderildi. Gönderilen hesap numarası: " + krediKarti + ", miktar: " + textBox_gonderilecekMiktar.Text + " TL\n";
                        dataGridView_Durumlar.Rows.Add("Para Gönderme", DateTime.UtcNow.ToString(),MusteriHesabi.Isim+" "+MusteriHesabi.Soyisim);//DataGridView'e birtakım bilgiler eklendi.// Some sort of informations added to DataGridView.//
                        DovizKarsiliklari();
                    }
                }
                else
                {
                    MessageBox.Show("Gönderilecek para miktarı var olan bakiyeden büyük olmamalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Gönderilecek para miktarı sadece rakamlardan oluşmalı ve kart numarası " + MusteriHesabi.KrediKartiHaneSayisi + " haneli olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ana_Menü_FormClosing(object sender, FormClosingEventArgs e) // Form kapanırken ekrana çıkar.// Occurs when the form is closing.
        {
            DialogResult decision= MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?","Çıkış Yap",MessageBoxButtons.YesNo);

            if(decision==DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
