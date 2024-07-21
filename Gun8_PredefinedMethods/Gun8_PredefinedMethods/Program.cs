// String methods
string kelime = "Deneme";

Console.WriteLine("------------------Length---------------------");
////// Length
Console.WriteLine(kelime.Length); // Length is property

Console.WriteLine("------------------ToLower -------------------");
////// ToLower
Console.WriteLine(kelime.ToLower()); // ToLowerCase

Console.WriteLine("------------------ToUpper -------------------");
////// ToUpper
Console.WriteLine(kelime.ToUpper()); // ToUpperCase

Console.WriteLine("------------------CompareTo -------------------");
////// CompareTo
Console.WriteLine(kelime.CompareTo("Deneme")); // Compare two strings

Console.WriteLine("------------------Replace -------------------");
////// Replace
Console.WriteLine(kelime.Replace("e","a")); // Replace with new string

Console.WriteLine("------------------Contains -------------------");
////// Contains
Console.WriteLine(kelime.Contains("De")); // Contains

Console.WriteLine("------------------Örnek -------------------");
string karsilastirilacak = "De";
Console.WriteLine(kelime.ToLower().Contains(karsilastirilacak.ToLower()));

Console.WriteLine("------------------Split Örnek -------------------");
string kelime2 = "Ahmet|Mehmet|Hasan|Hüseyin|Ali";

string[] splittedWords = kelime2.Split("|");
for (int i = 0; i < splittedWords.Length; i++)
{
    Console.WriteLine(splittedWords[i]);
}

