namespace Gun10_MethodOverload
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double sonuc = MaasHesapla(30, 10500);
            double sonuc2 = MaasHesapla(30, 10500, "E");
        }

        // Parametre olarak calıştığı gün sayısı ve günlük maaşı bilgilerini alan
        // toplam maaşı hesaplayıp geriye döndüren programı yazınız. 

        // ToplamMaaş = CGS * GünlükMaaş

        private static double MaasHesapla(int cgs, double gunlukMaas)
        {
            double toplam = cgs * gunlukMaas;
            return toplam;
        }

        // Parametre olarak calıştığı gün sayısı, günlük maaşı ve medeni durumu
        // bilgilerini alan
        // toplam maaşı hesaplayıp geriye döndüren programı yazınız
        // BA: Medeni durumu Evli olanlar için AGI = 1100 TL
        // Bekar olanlar için AGI 850 TL ekstra toplam maaşa eklenir. 

        private static double MaasHesapla(int cgs, double gunlukMaas, string mDurum)
        {
            double toplam = cgs * gunlukMaas;

            int AGI = 850;
            if (mDurum == "E")
            {
                AGI = 1100;
            }

            toplam += AGI;

            return toplam;
        }

    }
}