//int a = 5;
//int[] b = { 3, 5, 7 };


//int[] c = new int[3];
//c[0] = 10;
//c[1] = 20;
//c[2] = 30;


//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine(c[i]);
//}

// içi 1-100 arasında rastgele sayılarla doldurulmuş
// 10 elemanlı bir dizi değişkenin değerlerini ekrana yazınız. 
//int[] arr1D = new int[10];

//Random rnd = new Random();

//for (int i = 0; i< 10; i++)
//{
//    arr1D[i] = rnd.Next(1,100);
//}

//for (int i = 0;i< 10; i++)
//{
//    Console.WriteLine(arr1D[i]);
//}


//Console.Write("Kelimeyi giriniz ...:");
//string kelime = Console.ReadLine();

//string[] harfler = new string[kelime.Length];

//for (int i = 0; i < harfler.Length; i++)
//{
//    harfler[i] = kelime[i].ToString();
//    Console.WriteLine(harfler[i]);
//}


// Adım sayısı dışarıdan girilmek üzere. 
// Girilen adım sayısı kadar fibonacci sayılarını ekrana yazdıran programı yazınız. 

// Örn; Adım = 6
//  0-1-1-2-3-5

// Örn; Adım = 10
//  0-1-1-2-3-5-8-13-21-35



//Console.Write("Adım sayısını giriniz ...:");
//int adimSayisi = Convert.ToInt32(Console.ReadLine());

//int ilk = 0;
//int sonraki = 1;

//Console.WriteLine(ilk);
//Console.WriteLine(sonraki);

//for (int i = 0; i < adimSayisi; i++)
//{
//    int sonuc = ilk + sonraki;
//    ilk = sonraki;
//    sonraki = sonuc;
//    Console.WriteLine(sonuc);
//}


// n sayısı dışarıdan girilmek üzere, n elemanlı rastgele sayılarla 
// oluşturulmuş bir dizi değişkenin içindeki değerleri küçükten büyüğe doğru
// tekrar sıralayıp ekrana yazdıran programı yazınız. 

Console.Write("Adim sayısını giriniz ...:");
int adim = Convert.ToInt32(Console.ReadLine());
int[] arr1D = new int[adim];
Random rnd = new Random();

for (int i = 0; i < adim; i++)
{
    arr1D[i] = rnd.Next(1,100);
    Console.WriteLine(arr1D[i]);
}

Array.Sort(arr1D);
Console.WriteLine("-------------------------------------");
for (int i = 0;i < arr1D.Length; i++)
{
    Console.WriteLine(arr1D[i]);
}


// Quick sort ve bubble sort algoritmalarını araştırın. 
// ikisi için de birer tane örnek. 