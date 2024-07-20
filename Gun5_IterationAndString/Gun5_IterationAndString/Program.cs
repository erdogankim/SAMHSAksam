// piglatin adında bir oyun bulunmaktadır. 

// Dışarıdan girilen bir kelime için. 
// Örn : KONYA

// KONYA
// ONYAK
// NYAKO
// YAKON
// AKONY
// KONYA

// şeklinde kelimenin dizilimini veren programı yazınız. 

//Console.Write("Kelimeyi giriniz ...:");

//string kelime = Console.ReadLine();

//Console.WriteLine(kelime);

//for (int i = 0; i < kelime.Length; i++)
//{
//    string ilkHarf = kelime.Substring(0, 1);
//    string kalan = kelime.Substring(1);
//    kelime = kalan + ilkHarf;
//    Console.WriteLine(kelime);
//}

// Dışarıdan girilen kelimenin polidron olup olmadığını tespit eden programı yazınız. 

// RADAR -> Polidron
// ANTALA -> Polidron Değil



// ALİ

Console.Write("Kelimeyi giriniz ...:");
string kelime = Console.ReadLine().ToLower();
string tersKelime = string.Empty;

for (int i = 0; i < kelime.Length; i++)
{
    tersKelime += kelime.Substring(kelime.Length - (i + 1), 1).ToLower();
}


if (kelime == tersKelime)
{
    Console.WriteLine("Polidron");
}
else
{
    Console.WriteLine("Polidron değildir");
}
