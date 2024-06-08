// Dışarıdan girilen, 
// SonIndex
// IlkIndex
// litreFiyatı 
// bilgilerini alarak, kullanılan suyu hesaplayan ve 
// kullanılan suya göre de ödenmesi gereken faturayı hesaplayıp 
// ekranda gösteren programı yazınız. 

// kullanilanSuMiktari = sonIndex - ilkIndex
// FaturaTutari = kullanilanSuMiktari * litreFiyati

Console.Write("Son index değerini giriniz ...:");
string strSonIndex = Console.ReadLine();

Console.Write("İlk index değerini giriniz ...:");
string strIlkIndex = Console.ReadLine();

Console.Write("Litre fiyatını giriniz ...:");
string strLitrFiyati = Console.ReadLine();

int sonIndex = Convert.ToInt32(strSonIndex);
int ilkIndex = Convert.ToInt32(strIlkIndex);
int litreFiyati = Convert.ToInt32(strLitrFiyati);

int kullanilanSuMiktari = sonIndex - ilkIndex;
int faturaTutari = kullanilanSuMiktari * litreFiyati;

Console.Write("Fatura tutari ....:");
Console.WriteLine(faturaTutari);



