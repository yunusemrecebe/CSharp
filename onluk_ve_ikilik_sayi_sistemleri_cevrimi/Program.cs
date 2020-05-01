using System;
using System.Collections;

namespace sayi_tabani_cevrimi
{
    class Program
    {

        static void Main(string[] args) // YUNUS EMRE CEBE -- 190928053
        {
            string secim;
        tekrar:
            Console.Clear();

            Console.WriteLine("'1' = Decimal Sayı Sistemini Binary Sayı Sistemine Çevirme");
            Console.WriteLine("'2' = Binary Sayı Sistemini Decimal Sayı Sistemine Çevirme");
            Console.WriteLine("'Q' = Çıkış");
            Console.Write("Lütfen Yapılacak İşlem Kodunu Giriniz: ");
            secim = Console.ReadLine();
            Console.Clear();

            if (secim == "1")//Decimal'den Binary'ye
            {
                int sayi, sakla;
                string yaz = "", geri;
                ArrayList sonuc = new ArrayList();
                Console.Write("Sayıyı Giriniz..: ");
                sayi = Convert.ToInt32(Console.ReadLine());

                sakla = sayi;
                while (sayi != 0)
                {
                    sonuc.Insert(0, sayi % 2);
                    sayi = sayi / 2;
                }

                foreach (int i in sonuc)
                {
                    yaz += i;
                }

                Console.Clear();
                Console.WriteLine("{1} sayısının Binary sayı sistemindeki karşılığı: {0}", yaz, sakla);

            islem1:
                Console.WriteLine("Üst menüye dönmek için 'G' tuşuna, Çıkış yapmak için 'Q' tuşuna basınız.");
                geri = Console.ReadLine();
                if (geri == "G" || geri == "g")
                {
                    goto tekrar;
                }
                else if (geri == "q" || geri == "Q")
                {
                    Console.Clear();
                    Console.WriteLine("Çıkış yapılıyor.");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı giriş yaptınız! Lütfen tekrar giriş yapınız.");
                    System.Threading.Thread.Sleep(1500);
                    goto islem1;
                }
            }

            else if (secim == "2")//Binary'den Decimal'e
            {
                string sayi, geri;
                Console.Write("Sayıyı Giriniz: ");
                sayi = Console.ReadLine();
                int sonuc = 0;
                for (int i = 0; i < sayi.Length; i++)
                {
                    if (sayi[sayi.Length - i - 1] != '0')
                    {
                        sonuc += (int)Math.Pow(2, i);
                    }
                }
                Console.Clear();
                Console.WriteLine("{1} sayısının Decimal sayı sistemindeki karşılığı: {0}", sonuc, sayi);

            islem2:
                Console.WriteLine("Üst menüye dönmek için 'G' tuşuna, Çıkış yapmak için 'Q' tuşuna basınız.");
                geri = Console.ReadLine();
                if (geri == "G" || geri == "g")
                {
                    goto tekrar;
                }
                else if (geri == "q" || geri == "Q")
                {
                    Console.Clear();
                    Console.WriteLine("Çıkış yapılıyor.");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Hatalı giriş yaptınız! Lütfen tekrar giriş yapınız.");
                    System.Threading.Thread.Sleep(1500);
                    goto islem2;
                }
            }

            else if (secim == "q" || secim == "Q")
            {
                Console.WriteLine("Çıkış yapılıyor.");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Hatalı giriş yaptınız! Lütfen tekrar giriş yapınız.");
                System.Threading.Thread.Sleep(1500);
                goto tekrar;
            }
        }
    }
}
