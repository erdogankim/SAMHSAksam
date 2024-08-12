// Abone adında bir nesne 
//   TelefonNo
//   Ad
//   Soyad



// Urun adinda bir nesne
//    Tur
//    Fiyat
//    Indirim (oran)
//    KDV (oran)



// Fatura adinda bir nesne
//   OdemeKurulusu
//   AraToplam
//   KDVTutar
//   GenelToplam

// MobilOdeme
//   OdemeYap(Abone,Urun, Adet) : Fatura

// Ürün bilgileri urun nesnesinin içinden alınıp, Ödeme yapan operatore gör
// (türkcell, vodafone, TT)  fatura nesnesi oluşturulup, hesaplama yapılıp geriye
// döndürülecek. Mobil ödemelerde "Tekel" türü ödemesi yapılamaz. Fatura 0 tl olur.

using Gun12_Ornek2;

Abone a = new Abone();

Console.Write("Ad giriniz ...:");
a.Ad = Console.ReadLine();

Console.Write("Soyad giriniz ...:");
a.Soyad = Console.ReadLine();

Console.Write("Telefon giriniz ...:");
a.TelefonNo = Console.ReadLine();

Urun u = new Urun();
Console.Write("Ürün türünü giriniz ....:");
u.Tur = Console.ReadLine();

Console.Write("İndirim oranını giriniz ...:");
u.Indirim = Convert.ToDouble(Console.ReadLine());

Console.Write("KDV oranını giriniz ...:");
u.KDV = Convert.ToDouble(Console.ReadLine());

Console.Write("Fiyat giriniz ...:");
u.Fiyat = Convert.ToDecimal(Console.ReadLine());

Console.Write("Adet giriniz ...:");
int adet = Convert.ToInt32(Console.ReadLine());

MobilOdeme m = new MobilOdeme();

Fatura f = m.OdemeYap(a, u, adet);

Console.WriteLine(f.AraToplam);
Console.WriteLine(f.KDVTutari);
Console.WriteLine(f.GenelToplam);
Console.WriteLine(f.OdemeKurulusu);