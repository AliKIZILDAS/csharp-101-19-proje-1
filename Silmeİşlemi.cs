using System;
using System.Collections.Generic;
using System.Collections;


namespace telefonrehberi
{
    public class Silmeİşlemi:KayıtlıNumaralar
    {
        
        public static void Silme()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string input = Console.ReadLine();
            bool silDurumu=false;

            foreach (var item in Kisiler)
            {
                
                if(item.isim==input || item.soyisim==input)
                {
                    silDurumu=true;
                    Console.WriteLine(item.isim + " " + item.soyisim + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)");
                    char input1 =char.Parse( Console.ReadLine());
                    if( input1 == 'y')
                    {
                        Kisiler.Remove(item);
                        //Kisiler.RemoveAll(x => x.FirstName == input || x.LastName == input); tümünü silmek içindir.
                        Console.WriteLine(item.isim + " Başarı ile silindi");
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız");
                        Console.ReadKey();
                        break;
                    }
                    else if (input1 == 'n')
                    {
                        Console.WriteLine("Çıkış yapılıyor.");
                        break;
                    }
                
                }                
                
            }
            
            if (!silDurumu)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen seçim yapınız: ");
            Console.WriteLine("* Silmeyi sonlandırmak için (1)");
            Console.WriteLine("* Yeniden denemek için (2)");
            string input2 = Console.ReadLine();

            if(input2 == "1")
            {
                Console.WriteLine("İşlem sonlandırıldı.");
                //break;
            }
            else if(input2 == "2")
            {
                Silmeİşlemi.Silme();
            }
            else
            {
                Console.WriteLine("Gecersiz bir karakter girdiniz "); 
                Console.ReadKey();                               
            }
            }            
            
                      
        }
    }
}