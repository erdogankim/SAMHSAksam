// Dışarıdan sonindex, ilkindex ve kullanım yeri bilgileri alınacak 

// Girilen bilgilere göre
// KullanılanSuMiktari = sonindex-ilkindex

// Kullanım Yerine göre litre birim fiyatı
// Mesken = 5,7
// Umumi = 4,2
// Kamu = 3,1

// aratoplamTutari = KullanilanSuMiktari + LitreBirimFiyati

// ara toplamın üzerine %20 kdv eklenecek
// kullanım yeri kamu olması durumunda kdv uygulanmaz 

#region DışarıdanGirişler

Console.Write("Son index değerini giriniz ...:");
int sonIndex = Convert.ToInt32(Console.ReadLine());

Console.Write("İlk index değerini giriniz ...:");
int ilkIndex = Convert.ToInt32(Console.ReadLine());

Console.Write("Kullanım yeri giriniz ...[U/M/K]:");
string kullanimYeri = Console.ReadLine();
#endregion

double litreFiyati = 0;
double araToplam = 0;
double genelToplam = 0;
int kullanilanSuMiktari = sonIndex - ilkIndex;

if (kullanimYeri == "M")
{
    litreFiyati = 5.7;
    araToplam = litreFiyati * kullanilanSuMiktari;
    genelToplam = araToplam * 1.2;
}
else if(kullanimYeri == "U")
{
    litreFiyati = 4.2;
    araToplam = litreFiyati * kullanilanSuMiktari;
    genelToplam = araToplam * 1.2;
}
else
{
    litreFiyati = 3.1;
    araToplam = litreFiyati * kullanilanSuMiktari;
    genelToplam = araToplam;
}

Console.Write("Toplam fatura tutari ...:");
Console.WriteLine(genelToplam);