// Bilinçsiz, (otonom yapılan) tür dönüşümü
byte sayi1 = 50;
short sayi2 = sayi1;
int sayi3 = sayi2;
long sayi4 = sayi3;

// Bilinçli (müdehale ile yapılan) tür dönüşümü
int sayi5 = (int)sayi4;
short sayi6 = (short)sayi5;
byte sayi7 = (byte)sayi6;

short sayi8 = 257;
byte sayi9 = (byte) sayi8;

Console.WriteLine(sayi8);
Console.WriteLine(sayi9);

Console.Write("Lütfen bir sayı giriniz ...:");
string strSayi = Console.ReadLine();

int girilenSayi = Convert.ToInt32(strSayi);

// Ödev : Bitwise operatörleri araştırın ve birer örnek yapın. 
//        >>     <<   |     &
