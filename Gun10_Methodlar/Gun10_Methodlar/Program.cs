// Parametre olarak, İkamet ili, sinifi ve tekrar durumu değerlerini alan
// girilen bu değerlere göre yurt hakkını ve ücretini kontrol edip 
// ekranda gösteren programı yazınız. 

// BA : İstanbulda ikamet eden kişilerin yurtta kalma hakkı yoktur. 
// BA : Yurt ücreti, 1-2. sınıflar için aylık 8000 tl, 3-4. için 10000 tl
// BA : Yurt ücreti toplamda 8 ay için hesaplanır. 
// BA : Sınıf tekrarı olması durumunda %25 ek cezai ücret uygulanır. 

namespace Gun10_Methodlar
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //MesajYaz();
            MesajYaz2(20);
        }

        private static void MesajYaz()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Merhaba Dünya");
            }
        }

        private static void MesajYaz2(int mesajSayisi)
        {
            for(int i = 0;i < mesajSayisi; i++)
            {
                Console.WriteLine("Merhaba Dünya");
            }
        }
    }
}