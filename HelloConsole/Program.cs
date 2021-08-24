using System;

namespace HelloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Merhaba Console!");
            ////Console.WriteLine("Merhaba Serdar!");  // yazılanları satır satır yazar

            ////Console.Write("serdar");
            ////Console.Write("turan"); // write yanyana yazar

            //////Kullanıcıdan bilgi almak için readline kullanılır

            //Console.ReadLine
            //Kullanıcıya adınızı giriniz yazdıralım ve bilgi girilmesini isteyelim

            Console.WriteLine("Adınızı Giriniz");
            string ad= Console.ReadLine();  // Kullanıcının yazdığını okumak için yazarız

            Console.WriteLine("Soyadınızı giriniz");
            string soyad = Console.ReadLine();
            Console.WriteLine("Adınız:{0} Soyadınız: {1}", ad, soyad);

            Console.WriteLine($"Adınız:{ad}Soyadınız:{soyad}");




        }
    }
}

// CTRL+K+D --- otomatik düzenleme yapar. boşluk fazla bırakmışsan vs..
// crtl+s kodları kaydetmek için
// Projeyi başlatmak için kısayol F5 yada YUkarıdaki HelloConsole (Start) tuşuna bas
/* Birden fazla yorum satırı 
   yazılabilir
            */

// Bir veya birden fazla kod satırını yorum yatırı yapar CTRL+K+C
// CTRL+K+U Bir veya birden fazla yorum satırını tekrar kod satırına çevirmek için kullanılır.
