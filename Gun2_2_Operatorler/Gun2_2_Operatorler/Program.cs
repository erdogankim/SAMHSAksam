// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int myValue; // Variable Declaration

myValue = 10; // Value assignment


int deger = 20;

// Operatörler
// 5 + 3

// Yaptıkları temel işleme göre
// Aritmetik Operatörler
// +,-,*,/,%,

int kalan = 5 % 3;


// Atama Operatörleri
// =, +=, -=, *=, /= 
int a = 20;
a += 30; // a = a + 30;
a -= 10; // a = a - 10;
a *= 3;  // a = a * 3;
a /= 2;  // a = a / 2;
int b = 30;
b += a;

a++;
b--;

// Karşılaştırma Operatörlerix
// ==, !=, <, <=, >, >= 

int kSayi1 = 20;
int kSayi2 = 30;

bool sonuc1 = kSayi2 > kSayi1;
bool sonuc2 = b <= kSayi2;

// Mantıksal Operatörler
// &&, ||
bool sonuc3 = sonuc1 && sonuc2;
bool sonuc4 = sonuc1 || sonuc2;


// Aldıkları operand sayısına göre 
// Tek operandlılar  (Unary)
// ++,--    

// Çift operandlılar  (Binary)
// +,-    

// Üç operandlılar  (Trinary)
string degerStr = kSayi1 >= kSayi2 ? "Büyük veya eşit" : "Küçük";
var degerStr2 = kSayi1 >= kSayi2 ? "" : (new object());

//var sayisayi;

// Yanlış Tanım
//int benim+degisken = 10;

// Yanlış Tanım
//int BEnimDegi skEN2 = 20;

// Yanlış Tanım
//int 3DegiskenBenim = 30;

// Doğru Tanım
int benimYeniDegiskenim; // Değişkenler bu notasyon ile tanımlanırlar

// PascalCasing = BenimYeniMethod, BenimYeniSinif 
// Method, class, delegasyon vb yapıların isimlendirmesinde kullanılırlar


// Değişken adı içinde kısalmta olması durumunda Upper Case 
// büyük yazım kullanılır

int KDVMatrahi = 50;

// Kabab Notation
// online-okul-yonetim-sistemi
