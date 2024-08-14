
using Hafta4Kapanis;

class Program
{
    static void Main(string[] args)
    {
        bool devam = true;

        while (devam)
        {
            Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basınız:");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Telefon telefon = new Telefon();

                Console.Write("Telefon Adı: ");
                telefon.Ad = Console.ReadLine();

                Console.Write("Seri Numarası: ");
                telefon.SeriNumarasi = Console.ReadLine();

                Console.Write("Açıklama: ");
                telefon.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi: ");
                telefon.IsletimSistemi = Console.ReadLine();

                Console.Write("TR Lisanslı mı? (Evet/Hayır): ");
                telefon.TrLisansli = Console.ReadLine().ToLower() == "evet";

                Console.WriteLine("\nÜrün başarıyla üretildi.");
                telefon.BilgileriYazdir();
            }
            else if (secim == "2")
            {
                Bilgisayar bilgisayar = new Bilgisayar();

                Console.Write("Bilgisayar Adı: ");
                bilgisayar.Ad = Console.ReadLine();

                Console.Write("Seri Numarası: ");
                bilgisayar.SeriNumarasi = Console.ReadLine();

                Console.Write("Açıklama: ");
                bilgisayar.Aciklama = Console.ReadLine();

                Console.Write("İşletim Sistemi: ");
                bilgisayar.IsletimSistemi = Console.ReadLine();

                Console.Write("USB Giriş Sayısı (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());

                Console.Write("Bluetooth var mı? (Evet/Hayır): ");
                bilgisayar.BluetoothVarMi = Console.ReadLine().ToLower() == "evet";

                Console.WriteLine("\nÜrün başarıyla üretildi.");
                bilgisayar.BilgileriYazdir();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyiniz.");
                continue;
            }

            Console.WriteLine("\nBaşka bir ürün üretmek ister misiniz? (Evet/Hayır)");
            devam = Console.ReadLine().ToLower() == "evet";
        }

        Console.WriteLine("İyi günler!");
    }
}