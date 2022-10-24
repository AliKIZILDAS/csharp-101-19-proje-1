using System;
using System.Collections;
using System.Collections.Generic;

namespace telefonrehberi
{
    public class Listelemeİşlemi : KayıtlıNumaralar
    {
        public static void Listeleme()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("***********************************");
            
            
            foreach (var item in Kisiler)
            {
                Console.WriteLine("İsim            : " + item.isim);
                Console.WriteLine("Soyisim         : " + item.soyisim);
                Console.WriteLine("Telefon Numarası: " + item.numara);
                Console.WriteLine("-");
            }

            Console.WriteLine($"Rehberde {Kisiler.Count} kişi mevcuttur.Ana menüye dönmek için bir tuşa basınız.. ");
            Console.ReadKey();
        }
    }
}