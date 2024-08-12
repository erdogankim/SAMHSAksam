// Asat adında bir nesne oluşturun. Bu nesnenin içinde Hesapla adında bir method olsun
// Bu hesapla methodu parametre olarak Abone nesnesi alsın. 
// Geriye Fatura adında bir nesne döndürsün. 

// Fatura nesnesinde kişinin 
//   KullandığıSuMiktarı
//   BirimFiyatı
//   AraToplam
//   KDVTutari
//   ToplamTutar 
// Adında propertyler olsun. 

// Abone nesnesinde
//    AboneTuru
//    SonIndex
//    IlkIndex
// Adında propertyler olsun. 

// Hesaplama
// SonIndex-IlkIndex = KullanılanSuMiktarını
// AboneTuruneGöreBirimFiyat =>  Meskenler=10.30, Umumiler=7.50 TL dir. 
using Gun12_Ornek;

Abone a = new Abone();

Console.Write("Abone türünü giriniz ...:");
a.AboneTuru = Console.ReadLine();
// abone türü bilgisini al

Console.Write("SonIndex değerini giriniz ...:");
a.SonIndex = Convert.ToInt32(Console.ReadLine());

// son index değerini al

Console.Write("IlkIndex değerini giriniz ...:");
a.IlkIndex = Convert.ToInt32(Console.ReadLine());
//ilk index değerini al

Asat asat = new Asat();
Fatura f = asat.Hesapla(a);
Console.WriteLine(f.BirimFiyat);
Console.WriteLine(f.AraToplam);
Console.WriteLine(f.KDVTutari);
Console.WriteLine(f.GenelToplam);