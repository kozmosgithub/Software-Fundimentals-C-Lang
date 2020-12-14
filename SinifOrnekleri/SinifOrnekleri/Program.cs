using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SinifOrnekleri
{

    class Kutuphane
    {

        //Kütüphane Durumları
        public int kitapSayisi = 0;
        public List<string> kitapTuru = new List<string>();
        public int kiralananKitapSayisi = 0;
        public List<string> kitapAdi = new List<string>();
        public List<string> yazarAdi = new List<string>();
        public List<string> yayinEvi = new List<string>();
        public List<string> kitapKategori = new List<string>();
        public int kitapBaskiSayisi;
        public int kitapCiltSayisi;

        public int kitapEkle(int eklenecekKitapSayisi)
        {
            string ktpAdi , yzrAdi , ktpTuru;
            for(int i = 0; i < eklenecekKitapSayisi; i++)
            {
                Console.Write("Girilecek olan kitabın adını yazınız: ");
                ktpAdi = Console.ReadLine();
                kitapAdi.Add(ktpAdi);
                Console.Write("Girilecek olan kitabın yazar adını yazınız: ");
                yzrAdi = Console.ReadLine();
                yazarAdi.Add(yzrAdi);
                kitapSayisi++;
                kitapTuru.Add("1-Roman");
                kitapTuru.Add("2-Bilim-Kurgu");
                kitapTuru.Add("3-Macera");
                kitapTuru.Add("4-Fantastik");
                kitapTuru.Add("5-Polisiye");
                kitapTuru.Add("6-Tarih");
                int sayac = 0;
                while(sayac < kitapTuru.Count) {
                    Console.WriteLine(kitapTuru[sayac]);
                    sayac++;

                    
                }
                Console.Write("Kitap Turunu Giriniz: ");
                ktpTuru = Console.ReadLine();
            }
            return eklenecekKitapSayisi;
        }

        public string kitapKiralama( string ad , string soyad)
        {
            //bir kişi en fazla 5 kitap kiralayabilir.
             int kiralanankitap = 0;
            int secenek;
            char secim;
            do
            {
                Console.WriteLine("---------------------------------------------");
                foreach(string item in kitapAdi)
                {
                    Console.WriteLine(item);
                }
                Console.Write("Sececeginiz kitabin numarasini giriniz: ");
                secenek = Convert.ToInt32(Console.ReadLine());
                switch (secenek)
                {

                }
                Console.WriteLine("---------------------------------------------");

                List<string> kiralananKitapAdi = new List<string>();


                Console.WriteLine("Başka bir kitap kiralamak ister misiniz? (e/h)");
                secim = Convert.ToChar(Console.ReadLine());
                if (secim == 'e')
                    kiralanankitap++;
                else
                    break;
                
            } while (kiralanankitap < 5);

            return ad +" "+ soyad;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            //Kitap kiralama yapısı çağırırken
            char secim;
            string ad, soyad;
            Kutuphane ktp = new Kutuphane();
            Console.WriteLine("Kitap kiralamak ister misiniz? (e/h)");
            secim = Convert.ToChar(Console.ReadLine());
            if (secim == 'e') {
                Console.Write("Adınızı giriniz : ");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı giriniz : ");
            soyad = Console.ReadLine();
            ktp.kitapKiralama(ad, soyad);
            }

            //KitapEkleme Yapısını çağırırken

            int eklenecekKitapSayisi;
            Console.WriteLine("Kaç kitap girilecek: ");
            eklenecekKitapSayisi = Convert.ToInt32(Console.ReadLine());
            ktp.kitapEkle(eklenecekKitapSayisi);

            

        }
    }
}
