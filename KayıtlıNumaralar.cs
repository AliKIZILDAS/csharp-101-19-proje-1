namespace telefonrehberi
{
    public class KayıtlıNumaralar
    {
        private static List<Rehber> kisiler = new List<Rehber>();

        static KayıtlıNumaralar()
        {
            
            
           kisiler = new List<Rehber>()
            {
                new Rehber {isim = "Ceren",   soyisim = "Koç",     numara = "01234567891"},
                new Rehber {isim = "Kaan",    soyisim = "Kocaman", numara = "01234567892"},
                new Rehber {isim = "Elif",    soyisim = "Aydın",   numara = "01234567893"},
                new Rehber {isim = "Türkan",  soyisim = "Tuna",    numara = "01234567894"},
                new Rehber {isim = "Leyla ",  soyisim = "Kösegil", numara = "01234567895"},
            };
            kisiler.Add(new Rehber{isim="Ali",soyisim="Kızıldaş",numara="05555555555"});
            
        }

        
        public static List<Rehber> Kisiler { get => kisiler;  }
        
        
        public static void RehberYazdır()
        {
            foreach (var item in Kisiler)
            {
                Console.WriteLine(item.isim + " " + item.soyisim + " " + item.numara);
            }
        }        
    }
}