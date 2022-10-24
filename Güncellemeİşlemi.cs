using System;
using System.Collections.Generic;
using System.Collections;

namespace telefonrehberi
{
    public class Güncellemeİşlemi : KayıtlıNumaralar
    {
        public static void Güncelleme()
        {
            
            
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string input = Console.ReadLine();
            bool guncelDurumu=false;
            
            foreach (var item in Kisiler)
            {
                if (input == item.isim || input == item.soyisim)
                {
                    guncelDurumu=true;
                    Console.WriteLine("Lütfen yeni numarayı giriniz:");
                    string input1 = Console.ReadLine();
                    item.numara = input1;
                    break;
                }
            }
            if (!guncelDurumu)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen seçim yapınız: ");
                Console.WriteLine("* Güncellemeyi sonlandırmak için (1)");
                Console.WriteLine("* Yeniden denemek için (2)");
                int input2 = Convert.ToInt32(Console.ReadLine());

                if(input2 == 1)
                {
                    Console.WriteLine("İşlem sonlandırıldı.");
                    
                }
                else
                {
                    Güncellemeİşlemi.Güncelleme();
                }
            }
                            
            Console.ReadKey();
        }
    }

}