//// Belir bir tarihi nokta atışı işaret eder. 
//DateTime tarih = new DateTime(2024, 07, 28);

//// Belirli bir zaman parçasını tutan türdür
//TimeSpan ts = new TimeSpan(3, 2, 15);

using System.Globalization;
using System.Xml.Linq;

DateTime bugun = DateTime.Now;
//Console.WriteLine(bugun);

//DateTime ucYilSonra = bugun.AddYears(3);
//Console.WriteLine(ucYilSonra);

//DateTime sekizAySonra = bugun.AddMonths(8);
//Console.WriteLine(sekizAySonra);

//DateTime sekizAyOnce = bugun.AddDays(-8);
//Console.WriteLine(sekizAyOnce);

//DateTime ikiYilBesAySekizGunSonra = bugun.AddYears(2).AddMonths(5).AddDays(8);
//Console.WriteLine(ikiYilBesAySekizGunSonra);

//Console.WriteLine(bugun.Day);
//Console.WriteLine(bugun.Month);
//Console.WriteLine(bugun.Year);
//Console.WriteLine(bugun.Hour);
//Console.WriteLine(bugun.Minute);
//Console.WriteLine(bugun.Second);

//Console.WriteLine(bugun.DayOfWeek);
//Console.WriteLine(bugun.DayOfYear);


//Console.WriteLine(bugun.ToLongDateString());
//Console.WriteLine(bugun.ToShortDateString());
//Console.WriteLine(bugun.ToLongTimeString());
//Console.WriteLine(bugun.ToShortTimeString());


//string[] arrFormats = bugun.GetDateTimeFormats();

//Console.WriteLine("--------------- Formatlar ----------------");
//for (int i = 0; i < arrFormats.Length; i++)
//{
//    Console.WriteLine(arrFormats[i]);
//}

//Console.WriteLine(bugun.GetDateTimeFormats()[17]);


//Console.WriteLine(bugun.ToString(CultureInfo.GetCultureInfo("tr-TR")));
//Console.WriteLine(bugun.ToString(CultureInfo.GetCultureInfo("en-US")));

//var cultureInfo = CultureInfo.GetCultureInfo("tr-TR");
////cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
////cultureInfo.NumberFormat.CurrencyGroupSeparator = ",";

//decimal totalPrice = 10420.894M;
//Console.WriteLine(totalPrice.ToString(CultureInfo.GetCultureInfo("en-US")));
//Console.WriteLine(totalPrice.ToString(CultureInfo.GetCultureInfo("tr-TR")));


// Dışarıdan Fiş Tarihi, Fiş Tutarı, bilgileri alınacak. 
// - Fiş tarihi kabulü kuralları
//   Maksimum 3 gün öncesine kadar fiş tarihi girilebilir. 
// - Fiş tutarı kabulü
//   Maksimum 100.000 tl ye kadar olan fişler kabul edilecektir. 

// Dışarıdan girilen bu bilgilerin uygunluk durumuna göre ekrana "Kaydedildi" yazan
// Veya kayıt başarısız. Sebebi : ...  şeklinde sebebini anlatarak kaydı iptal eden 
// algoritma kodlarını yazınız. 


//Console.WriteLine(CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DateSeparator);

//Console.Write("Fiş tarihini giriniz ...:");
//DateTime fisTarihi = Convert.ToDateTime(Console.ReadLine(), CultureInfo.GetCultureInfo("tr-TR"));

//Console.Write("Fiş tutarını giriniz ...:");
//decimal fisTutari = Convert.ToDecimal(Console.ReadLine(), CultureInfo.GetCultureInfo("tr-TR"));

//if (DateTime.Now.AddDays(-3) > fisTarihi || fisTutari > 100000)
//{
//    Console.WriteLine("Fiş kaydı yapılamaz");
//}
//else
//{
//    Console.WriteLine("Fiş kaydı yapıldı");
//}


//DateTime tarih1 = new DateTime(2024,7,26);
//DateTime tarih2 = DateTime.Now;

//TimeSpan ts = tarih2 - tarih1;

//Console.WriteLine($"{ts.Days} - {ts.Hours}");
//Console.WriteLine(ts.Hours);
//Console.WriteLine(ts.Minutes);
//Console.WriteLine(ts.Seconds);
//Console.WriteLine(ts.Microseconds);

// Ticks değeri : Bir tarihin mili saniyeye kadar olan sayısal karşılığıdır 

//DateTime tarih = DateTime.Now;

//Console.WriteLine(tarih.Ticks);

//DateTime dt = new DateTime(638577860892233010);
//Console.WriteLine(dt);

// Dışarıdan girilen 3 farklı tarihin ortalama tarihini ekrana yazdıran programı yazınız. 


//Console.Write("3 adet tarihi aralarında virgul kullanarak giriniz ...:");

//string strTarihler = Console.ReadLine();

//string[] arrTarihler = strTarihler.Split(",");

//long toplamTicks = 0;

//for (int i = 0; i < arrTarihler.Length; i++)
//{
//    toplamTicks += Convert.ToDateTime(arrTarihler[i]).Ticks;
//}

//long ortalamaTicks = toplamTicks / arrTarihler.Length;

//DateTime ortalamaTarih = new DateTime((long)ortalamaTicks);
//Console.WriteLine(ortalamaTarih);

// 2024 yılı için rastgele 10 adet tarih oluşturup bunu bir dizi değişkende saklayan
// ekranda gösteren ve bu 10 adet tarihin ortalama tarihini de ekrana yazan 
// programı yazınız. 

DateTime[] arrDateTimes = new DateTime[10];
Random rnd = new Random();
long baslangicTicks = (new DateTime(2024, 01, 01)).Ticks;
long bitisTicks = (new DateTime(2024, 12, 31)).Ticks;

long toplamTicks = 0;

for (int i = 0; i < arrDateTimes.Length; i++)
{
    long ticks = rnd.NextInt64(baslangicTicks, bitisTicks);
    arrDateTimes[i] = new DateTime(ticks);
    Console.WriteLine(arrDateTimes[i]);
    toplamTicks += ticks;
}

long ortalamaTicks = toplamTicks / 10;

DateTime ortalamaTarih = new DateTime(ortalamaTicks);
Console.WriteLine(ortalamaTarih);

