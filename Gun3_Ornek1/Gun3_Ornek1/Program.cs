// Dışarıdan girilen boy ve kilo değerlerine göre 
// VKI hesaplayan programı yazınız. 
// Kilo (kg)
// Boy (m)

//VKI = kilo / (boy * boy)

Console.Write("Kilo değerini giriniz (kg) ...:");
int kilo = Convert.ToInt32(Console.ReadLine());

Console.Write("Boy değerini giriniz (m) ...:");
double boy = Convert.ToDouble(Console.ReadLine());

double VKI = kilo / (boy * boy);

if (VKI < 20)
{
    Console.WriteLine("Zayıf");
}
else if(VKI > 20 && VKI < 25)
{
    Console.WriteLine("Normal");
}
else
{
    Console.WriteLine("Kilolu");
}