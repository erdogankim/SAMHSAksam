// Dışarıdan girilen iki ayrı yazılı notunun ortalamasını alıp
// ortalamaya göre durumunu ekrana yazan programı yazınız. 

// Ortalama 
// 0-24 = Geçersiz
// 25-44 = Zayıf
// 45-54 = Geçer
// 55-69 = Orta
// 70-84 = İyi
// 85-100 = Pekiyi


Console.Write("1. yazılı notunu giriniz ...:");
int yazili1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. yazılı notunu giriniz ...:");
int yazili2 = Convert.ToInt32(Console.ReadLine());

int ortalama  = (yazili1 +yazili2) / 2;

if (ortalama >= 0 && ortalama <= 24)
{
    Console.WriteLine("Geçersiz");
}
else if(ortalama >= 25 && ortalama <= 44)
{
    Console.WriteLine("Zayıf");
}
else if (ortalama >= 45 && ortalama <= 54)
{
    Console.WriteLine("Geçer");
}
else if ((ortalama >= 55) && (ortalama <= 69))
{
    Console.WriteLine("Orta");
}
else if(ortalama >= 70 && ortalama <= 84)
{
    Console.WriteLine("iyi");
}
else
{
    Console.WriteLine("Pekiyi");
}