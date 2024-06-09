// Yurt otomasyonu için yurda kabul ve yurt ücreti hesaplama algoritması geliştiriyoruz

// Dışarıdan sınıf bilgisi (1., 2.), sınıf tekrarı durumu varsa bu bilgi girilecek. 
// ikamet şehri bilgisi girilecek. 

// Kurallar
// İkamet şehri antalya ise "Antalyada ikamet eden öğrencilerin yurt kullanım hakkı bulunmamaktadır" 
// uyarısını versin ve hesaplamaya tabii tutmasın. 

// kişi 1. veya 2. sınıfta ise Aylık 7000 TL 
// kişi 3. veya 4. sınıfta ise Aylık 8000 TL 
// 8 ay için ödeme yapması gerekiyor. 

// Kişinin sınıf tekrarı durumu varsa, ödeyeceği ücrete %25 cezai ek ücret eklenir. 

// Toplam ödenecek tutar ekranda gösterilir. 

Console.Write("İkamet şehrini giriniz ...:");
string ikamet = Console.ReadLine();
if (ikamet == "Antalya")
{
    Console.WriteLine("Antalyada ikamet eden öğrencilerin yurt kullanım hakkı bulunmamaktadır");
}
else
{
    Console.Write("Sınıf bilgisini giriniz ...:");
    string sinif = Console.ReadLine();

    Console.Write("Sınıf tekrar durumunu giriniz [E/H]...:");
    string tekrar = Console.ReadLine();

    double aylikTutar = 0;
    if (sinif == "1" || sinif == "2")
    {
        aylikTutar = 7000;
    }
    else
    {
        aylikTutar = 8000;
    }

    if (tekrar == "E")
    {
        aylikTutar *=  1.25;
    }

    double genelToplam = aylikTutar * 8;
    Console.WriteLine(genelToplam);
}