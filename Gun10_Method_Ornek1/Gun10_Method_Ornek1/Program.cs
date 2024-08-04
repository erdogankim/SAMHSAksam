public class Program
{
    private static void Main(string[] args)
    {
        YurtUcretHesapla("Ankara", "3", true);
    }

    /// <summary>
    /// Yurt ücreti hesaplamak için kullanılan methoddur.
    /// </summary>
    /// <param name="ikametIli">Öğrencinin ikamet ettiği resmi il</param>
    /// <param name="sinif">Öğrencinin aktif okuduğu sınıf</param>
    /// <param name="tekrar">Öğrencinin sınıf tekrarı durumu</param>
    public static void YurtUcretHesapla(string ikametIli, string sinif, bool tekrar)
    {
        if (ikametIli == "İstanbul")
        {
            Console.WriteLine("İstanbulda ikamet edenler yurttan yararlanamaz");
            return;
        }

        double ucret = 8000;
        if (sinif == "3" || sinif == "4")
        {
            ucret = 10000;
        }

        double toplam = ucret * 8;

        if (tekrar)
        {
            toplam *= 1.25;
        }

        Console.WriteLine($"Ödenmesi gereken toplam tutar = {toplam}");
    }
}