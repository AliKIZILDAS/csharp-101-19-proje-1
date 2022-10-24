
using System;
using System.Collections.Generic;

namespace telefonrehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            string input="";
            while (input!= "exit")
            {           
                Console.WriteLine("Telefon Rehberi Uygulamasına Hoşgeldiniz!.Lütfen yapmak istediğiniz işlemi seçiniz.");
                Console.WriteLine("*****************************************");
                Console.WriteLine("(1) Yeni numara kaydetmek");
                Console.WriteLine("(2) Varolan numarayı silmek");
                Console.WriteLine("(3) Varolan numarayı güncellemek");
                Console.WriteLine("(4) Rehberi listelemek");
                Console.WriteLine("(5) Rehberde arama yapmak");
                Console.WriteLine("(exit) Çıkış yapmak için");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Kaydetmeİşlemi.Kaydet();
                    break;

                    case "2":
                        Silmeİşlemi.Silme();
                    break;

                    case "3":
                        Güncellemeİşlemi.Güncelleme();
                    break;

                    case "4":
                        Listelemeİşlemi.Listeleme();
                    break;

                    case "5":
                        Aramaİşlemi.Arama();
                    break;
                    case "exit":
                    break;

                    default:
                        System.Console.WriteLine("1-5 arası program seçiniz ya da exit ile çıkınız.");
                    break;
                }
            }             
        }
    }
}