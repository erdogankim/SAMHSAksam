// See https://aka.ms/new-console-template for more information
// ASCII tablosunda a-z A-Z

//char karakter = (char)65;
//Console.WriteLine(karakter);

// n sayısı dışarıdan girilmek üzere, n kadar 5 harfli kelimeyi tek boyutlu dizi değişkende
// saklayan ve bunu ekranda gösteren programı yazınız. 

//Console.WriteLine("n değerini giriniz ...:");
//int n = Convert.ToInt32(Console.ReadLine());
//string[] kelimeler = new string[n];

//Random rnd = new Random();

//for (int i = 0; i < n; i++)
//{
//	string kelime = string.Empty;
//	for (int j = 0; j < 5; j++)
//	{
//		char k = (char)rnd.Next(65, 90);
//		kelime += k;
//	}
//	kelimeler[i] = kelime;
//    Console.WriteLine(kelime);
//}



// n sayısı dışarıdan girilmek üzere nxn lik rastgele sayılarla oluşturulmuş
// 2 adet matrisi toplayıp
// toplam matris değerini ekranda gösteren programı yazınız. 

//Console.Write("n değerini giriniz ...:");
//int n = Convert.ToInt32(Console.ReadLine());

//int[,] m1 = new int[n,n];
//int[,] m2 = new int[n,n];
//int[,] toplam = new int[n, n];

//Random rnd = new Random();

//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        m1[i, j] = rnd.Next(1, 100);
//        m2[i, j] = rnd.Next(1,100);
//        toplam[i,j] = m1[i, j] + m2[i,j];
//    }
//}

//for (int i = 0;i < n; i++)
//{
//    for(int j = 0;j < n; j++)
//    {
//        Console.Write(toplam[i,j]);
//        Console.Write(" ");
//    }
//    Console.WriteLine();
//}


// n sayısı dışarıdan girilmek üzere nxn lik oluşturulmuş bir diziyi
// saat yönünde bir tur çevrilmiş halini oluşturan ve ekranda gösteren programı
// yazınız. 

//int[,] dizi = new int[2, 2];
//int[,] reverse = new int[2, 2];
//Random rnd = new Random();

//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        dizi[i, j] = rnd.Next(1, 100);
//        Console.Write(dizi[i,j]);
//        Console.Write(" ");
//    }
//    Console.WriteLine();
//}

//   0,0  ->   0,1
//   0,1  ->   1,1
//   1,1  ->   1,0
//   1,0  ->   0,0

//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        reverse[i, j+1] = dizi[i, j];
//    }
//}


//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 2; j++)
//    {
//        Console.Write(reverse[i, j]);
//        Console.Write(" ");
//    }
//    Console.WriteLine();
//}


// dışarıdan girilen bir yazının, her üç harfine göre parçalayan
// bunu bir dizi değişkende saklayan programı yazınız. 

Console.Write("Yazıyı giriniz ...:");
string yazi = Console.ReadLine();

int n = yazi.Length % 3 == 0 ? yazi.Length / 3 : (yazi.Length / 3) + 1;

string[] arr = new string[n];
int sayac = 0;

for (int i = 0; i < yazi.Length; i+=3)
{
    if (yazi.Length - i >= 3)
    {
        arr[sayac] = yazi.Substring(i, 3); 
    }
    else
    {
        arr[sayac] = yazi.Substring(i);
    }
    sayac++;
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}