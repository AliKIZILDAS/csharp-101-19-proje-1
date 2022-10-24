using System;
using System.Collections.Generic;
using System.Collections;

namespace telefonrehberi
{
    public class Aramaİşlemi : KayıtlıNumaralar
    {
        public static void Arama()
        {
            
            Console.WriteLine("Arama yapmak istediğiniz yöntemi seçiniz:");
            Console.WriteLine("*****************************************");
            Console.WriteLine("İsim veya soy isime göre arama yapmak için: (1)");
            Console.WriteLine("Numaraya göre arama yapmak için: (2)");
            string input = Console.ReadLine();
            bool aramaDurum=false;

            if (input == "1")
            {
                Console.WriteLine("Lütfen isim  veya soyisim giriniz:");
                string input1 = Console.ReadLine();
                //List<Rehber> ilk=new List<Rehber>();
                //ilk.AddRange(telefonRehberim);
                foreach (var item in Kisiler)
                {
                    
                    if (input1 == item.isim || input1 == item.soyisim)
                    {
                        aramaDurum=true;
                        Console.WriteLine("İsim            : " + item.isim);
                        Console.WriteLine("Soyisim         : " + item.soyisim);
                        Console.WriteLine("Telefon Numarası: " + item.numara);
                        Console.WriteLine("-");
                        break;
                    }
                    
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("Lütfen numarayı giriniz:");
                string input2 = Console.ReadLine();
                foreach (var item in Kisiler)
                {
                    if (input2 == item.numara)
                    {
                        aramaDurum=true;
                        Console.WriteLine("İsim            : " + item.isim);
                        Console.WriteLine("Soyisim         : " + item.soyisim);
                        Console.WriteLine("Telefon Numarası: " + item.numara);
                        Console.WriteLine("-");
                        break;
                    }                    
                }

            }
            else
            {
                Console.WriteLine("Yanlış giriş yapıldı.");
            }
            if (!aramaDurum)
            {
                Console.WriteLine("Böyle bir kayıt bulunamadı");
                
            }

            Console.ReadKey();

        }
    }
}