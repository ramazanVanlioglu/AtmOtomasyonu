using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmOtomasyonu
{
    public class Musteri
    {
        //Musteri bakiye

        public double HavaleUcreti { get; set; } = 1.32;
        public int PinUzunlugu { get; set; } = 4;
        public string Isim { get; set; }

        public string Soyisim { get; set; }
        public double Bakiye { get; set; }

        public double Euro { get; set; } = 20;
        public double Dolar { get; set; } = 20;

        public double KrediKartiHaneSayisi { get; set; } = 16;
        public int Pin { get; set; }

        public double BakiyeninDolarKarsiligi()
        {
            return Bakiye / Dolar;
        }

        public double BakiyeninEuroKarsiligi()
        {
            return Bakiye / Euro;
        }

        public Musteri()
        {

        }

        public Musteri(string _isim, string _soyisim, double _bakiye, int _pin)
        {
            this.Isim = _isim;
            this.Soyisim = _soyisim;
            this.Pin = _pin;
            this.Bakiye = _bakiye;
        }

        public double BakiyeGoruntule()
        {
            return Bakiye;
        }




    }
}
