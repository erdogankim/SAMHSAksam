// Yurt adında bir class oluşturun. 
// Bu class'ın içerisinde Yerlesim adinda bir method olsun
// Bu method parametre olarak ikamet ili, sınıf ve tekrar değerlerini alsın. 
// Bu girilen değerlere göre geriye kişinin ödemesi gereken yurt ücretini hesaplayıp
// döndürsün. 

// BA : İstanbulda ikamet eden öğrencinin yurt hakkı bulunmadığından değer 0 
//     dönülür. 
// BA : 1. ve 2. sınıf öğrencileri için aylık yurt ücreti 8000 TL
//    : 3. ve 4. sınıf öğrencileri için aylık yurt ücreti 10000 TL

// BA : Sınıf tekrarı olan öğrenciler için %25 cezai işlem uygulanır. 
//    : toplam demesi gereken ücretin üzerine eklenir. 

using Gun11_OOP_Ornek;

Console.Write("İkamet ilini giriniz ...:");
string sehir = Console.ReadLine();

Console.Write("Sınıf bilgisini giriniz ...:");
string sinif = Console.ReadLine();

Console.Write("Tekrar durumunu giriniz [E/H] ...:");
string strTekrar = Console.ReadLine();

bool tekrar = strTekrar == "E";

Yurt yurt = new Yurt();
double ucret = yurt.Yerlesim(sehir, sinif, tekrar);
Console.WriteLine(ucret);