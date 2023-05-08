using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmOtomasyonu
{
    public partial class Form1 : Form
    {
      
        Musteri mus = new Musteri();//-> Pin uzunlugunu elde etmek için tanımladık. // Defined to obtain length of pin.
        List<Musteri> Musteris = new List<Musteri>();// Tüm müşteriler. // All of the customers.
        Ana_Menü AnaMenu; //-> Bu şekilde tanımlayınca form küçülmesi veya stack overflow almadık. //We didn't get any error such as rescaling of the form size as smaller and stack overflow. <-//
        public Form1()
        {
            InitializeComponent();
        }
        public void BelirliKisiler()
        {
            Musteris.Add(new Musteri("Özlem", "Cim", 3000, 4130));          
            Musteris.Add(new Musteri("Cristiano", "Ronaldo", 1000, 1234));  
            Musteris.Add(new Musteri("Lionel", "Messi", 2000, 9876));       
            Musteris.Add(new Musteri("Neymar", "Da Silva Jr.", 3000, 0101));
            Musteris.Add(new Musteri("David", "Beckham", 4000, 1111));      
            Musteris.Add(new Musteri("Ramazan", "Vanlıoğlu", 1250, 5555));  
            Musteris.Add(new Musteri("Emre", "Demir", 6578.20, 0011));      
            Musteris.Add(new Musteri("Yiğit","Sezen",2500,4444));           
            Musteris.Add(new Musteri("Efe", "Cankan", 4250, 1212));         

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BelirliKisiler();
        }
        public void textiBosalt()
        {
            textBox_sifre.Text = string.Empty;
        }
        private void button_giris_Click(object sender, EventArgs e)
        {
            bool kontrol = true;
            if (textBox_sifre.Text.Length == mus.PinUzunlugu && Int32.TryParse(textBox_sifre.Text, out int forTryParse))
            {
                foreach (Musteri musteri in Musteris)
                {
                    if (musteri.Pin.ToString() == textBox_sifre.Text)
                    {
                        MessageBox.Show("Hoş geldiniz sayın " + musteri.Isim + " " + musteri.Soyisim + ".\nAna sayfaya yönlendiriliyorsunuz.", "Hoş geldiniz"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kontrol = false;
                        AnaMenu = new Ana_Menü(musteri);
                        AnaMenu.ShowDialog();
                        this.Hide();
                        break;
                    }

                }
                if (kontrol)
                {
                    MessageBox.Show("Şifreniz yanlış, lütfen tekrar deneyiniz!", "Şifre Yanlış", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textiBosalt();
                }
            }
            else
            {
                MessageBox.Show("Şifreniz " + mus.PinUzunlugu + " haneden oluşmalı ve sadece rakam içermelidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textiBosalt();
               
            }
        }

        private void btn_cikis_yap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uygulamadan çıkılıyor... İyi günler dileriz!","Çıkış Yap",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult decision= MessageBox.Show("Uygulamadan çıkmak istiyor musunuz? ","Çıkış Yap",MessageBoxButtons.YesNo);
            if(decision==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
