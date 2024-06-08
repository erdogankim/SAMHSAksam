// Dışarıdan, çalıştığı gün sayısı,
// medeni durumu ve rütbe bilgileri girilecek

Console.Write("Çalıştığı gün sayısını giriniz ...:");
string strCGS = Console.ReadLine();
int CGS = Convert.ToInt32(strCGS);

Console.Write("Medeni durumu giriniz ...:");
string medeniDurum = Console.ReadLine();

Console.Write("Rütbeyi giriniz ...:");
string rutbe = Console.ReadLine();

// Rütbesine göre günlük maaşı
// Müdür => 1100
// Şef => 670
int gunlukMaas = rutbe == "Müdür" ? 1100 : ((rutbe == "Şef") ? 670 : 550);

// Hakediş = çalıştığıGünSayısı * günlükMaaş
int hakedis = CGS * gunlukMaas;

// Kişinin medeni duruma göre AGİ hakedişi de vardır 
// Medeni Durumu
// Evli  =>   550
// Bekar  => 350
int AGI = medeniDurum == "Evli" ? 550 : 350;

// Hakedişine eklenerek toplam hakediş bulunur. 
int toplamHakedis = hakedis + AGI;

Console.Write("Toplam hakediş ....:");
Console.WriteLine(toplamHakedis);