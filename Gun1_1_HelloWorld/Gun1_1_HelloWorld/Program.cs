// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Değişken (variables)
// Ram üzerinde ayrılmış belirli bir alanda, belirli bir tür değeri saklayabilmemi (atayabilmemi)
// ihtiyaç durumunda bu değeri tekrar kullanabilmemi sağlayan programatik yapılardır. 


int sayi;
sayi = 10;

// Tam sayı değişken türleri
bool sayi1 = true;
byte sayi2 = 5; // 8 bitlik değişken   0-255 
sbyte sayi3 = -5;
short sayi4;   // 16 bitlik değişken   +- 32747
ushort sayi5;    // 16 bitlik    0-65535
int sayi6; // 32 bitlik eksiye düşebilen 
uint sayi7;  // 32 bitlik
long sayi8;  // 64 bitlik eksiye düşebilen
ulong sayi9; // 64 bitlik 

// Ondalıklı değişken türleri

float sayi10 = 5.2f;    // 32 bitlik bir değişken türüdür, tam sayı kısmı maksimum 16 bit değer tutabilir
// virgülden sonra 7 hane hassasiyeti vardır
double sayi11 = 100.27; // 64 bitlik bir değişken türüdür, tam sayı kısmı maksimum 32 bitlik değer tutar
// virgülden sonra 15-16 hane hassasiyeti vardır
decimal sayi12 = 250.15m; // 128 bitlik bir değişken türüdür, tam sayı kısmı maksimum 64 bitlik değer tutar
// virgülden sonra 27-28 hane hassasiyeti vardır. 


// Operatorlerin kullanım alanı açısından gruplanması

// + , - , * , / , %  Aritmetik operatörler

// ==, !=, <, <=, >, >= Karşılaştırma (Comparer) operatörleri. Sonuç olarak bool değer döndürürler

int a = 5 + 3;


// &&, ||  // 
