// Iteration Statements (Loops) (Döngüler)
// Belirli bir koşul sağlandığı sürece, aynı kod bloğunu tekrar tekrar
// çalıştıran kodlama yapısına döngü denir. 

//for (int sayacDegiskeni = 1; sayacDegiskeni <= 5; sayacDegiskeni++)
//{
//    Console.WriteLine(sayacDegiskeni);
//}


// 3 basamaklı sayıları listeleyen program
//for (int i = 100; i <= 999; i++)
//{
//    Console.WriteLine(i);
//}


// 2 basamaklı tek sayıları ekranda listeleyen programı yazınız. 
// 10-99

//for (int i = 10; i <= 99; i++)
//{
//    if (i % 2 != 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//for (int i = 11; i <= 99; i += 2)
//{
//    Console.WriteLine(i);
//}


// 15 e tam bölünebilme kuralı, 3 ve 5 e aynı anda bölünebilmesi şeklindedir. 
// 4 basamaklı 15 e tam bölünebilen sayıları listeleyiniz. 

//for (int i = 1000; i <= 9999 ; i++)
//{
//	if (i % 3 == 0 && i % 5 == 0)
//	{
//        Console.WriteLine(i);
//    }

//    //if (i % 15 == 0)
//    //{
//    //    Console.WriteLine(i);
//    //}
//}


// Dışarıdan sayaç başlangıç değeri, maksimum değeri ve artış miktarı girilecek. 
// girilen bu bilgilere göre döngü oluşturup çalıştıran programı yazınız. 

//Console.Write("Sayaç başlangıç değeri ...:");
//int sayacBaslangıc = Convert.ToInt32(Console.ReadLine());

//Console.Write("Sayaç maksimum değeri ...:");
//int sayacMaxDeger = Convert.ToInt32(Console.ReadLine());

//Console.Write("Artış miktarı ....:");
//int artisMiktari = Convert.ToInt32(Console.ReadLine());

//for (int i = sayacBaslangıc; i <= sayacMaxDeger; i+=artisMiktari)
//{
//    Console.WriteLine(i);
//}

//int abc = 359;

//int a = abc / 100;
//int bc = abc - (a * 100);
//int b = bc / 10;
//int c = bc - (b * 10);

//int cba = (c * 100) + (b * 10) + a;

// bir sayıyı tersten yazdırma

// Polidron : tersten yazıldığında aynı değeri veren sayılara polidron denir. 
// 121   ,    353    ,     979     gibi

// Soru : 3 basamaklı polidron sayıları listeleyen programı yazınız. 

//for (int i = 100; i <= 999; i++)
//{
//    int abc = i;
//    int a = abc / 100;
//    int bc = abc - (a * 100);
//    int b = bc / 10;
//    int c = bc - (b * 10);

//    int cba = (c * 100) + (b * 10) + a;

//    if (abc == cba)
//    {
//        Console.WriteLine(i);
//    }
//}

// tersten yazıldığında kendisinin 9 katına eşit olan 4 basamaklı sayıyı 
// ekrana yazdıran programı yazınız. 

//for (int i =1000; i <= 9999; i++)
//{
//    int abcd = i;

//    int a = abcd / 1000;
//    int bcd = abcd - (a * 1000);
//    int b = bcd / 100;
//    int cd = bcd - (b * 100);
//    int c = cd / 10;
//    int d = cd - (c * 10);

//    int dcba = (d * 1000) + (c * 100) + (b * 10) + a;

//    if (abcd * 9 == dcba)
//    {
//        Console.WriteLine(i);
//    }
//}

// 5 tane rastgele sayıyı ekrana yazdırmak için 

//Random rnd = new Random();

//for (int i = 0; i < 5; i++)
//{
//    int rastgeleSayi = rnd.Next(1,100);
//    Console.WriteLine(rastgeleSayi);
//}

// kolon sayısı dışarıdan girilmek üzere. 
// kolon sayısı kadar sayısal loto tahmini üreten programı yazınız. 

// 1 kolonda 6 adet 1-49 arasında sayı bulunur. 


//Console.Write("Kolon sayısını giriniz ...:");
//int kolonSayisi = Convert.ToInt32(Console.ReadLine());

//Random rnd = new Random();

//for (int i = 1; i <= kolonSayisi; i++)
//{
//    for (int j = 1; j <= 6; j++)
//    {
//        int sayi = rnd.Next(1, 49);
//        Console.Write(sayi);
//        Console.Write("-");
//    }
//    Console.WriteLine();
//}

// For varyans
//int i = 1;
//for (; i <= 10; )
//{
//    Console.WriteLine(i);
//    i++;
//}


// aşağıdaki şekli ekrana çizen programı yazınız. 

// *
// **
// ***
// ****
// *****


//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}



// *
// **
// ***
// ****
// *****
// *****
// ****
// ***
// **
// *

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//for (int i = 5 ; i >= 1; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

// *        *
// **      **
// ***    ***
// ****  ****
// **********
// **********
// ****  ****
// ***    ***
// **      **
// *        *
//

