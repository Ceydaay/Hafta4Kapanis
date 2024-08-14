using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Kapanis
{
    abstract class BaseMakine
    {
        public DateTime UretimTarihi { get; private set; }
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public BaseMakine()
        {
            UretimTarihi = DateTime.Now;  // Üretim tarihi otomatik olarak atanır
        }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
        }

        public abstract void UrunAdiGetir();
    }

    class Telefon : BaseMakine
    {
        public bool TrLisansli { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisanslı mı: {(TrLisansli ? "Evet" : "Hayır")}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
        }
    }

    class Bilgisayar : BaseMakine
    {
        private int usbGirisSayisi;
        public bool BluetoothVarMi { get; set; }

        public int UsbGirisSayisi
        {
            get { return usbGirisSayisi; }
            set
            {
                if (value == 2 || value == 4)
                    usbGirisSayisi = value;
                else
                {
                    Console.WriteLine("Usb giriş sayısı sadece 2 veya 4 olabilir! -1 atanıyor.");
                    usbGirisSayisi = -1;
                }
            }
        }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
            Console.WriteLine($"Bluetooth var mı: {(BluetoothVarMi ? "Evet" : "Hayır")}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
        }
    }

}
