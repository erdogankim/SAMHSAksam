// n sayısı dışarıdan girilmek üzere, n elemanlı, rastgele sayılarla doldurulmuş
// diziyi oluşturan ve ekranda listeleyen programı yazınız. 

//Console.Write("N değerini giriniz ...:");
//int n = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[n];

//Random rnd = new Random();

//for (int i = 0; i < n; i++)
//{
//    arr[i] = rnd.Next();
//    Console.WriteLine(arr[i]);
//}

// 1-100 arası sayılarla oluşturulmuş 10 elemanlı bir dizi değişkenin içindeki 
// değerlerin karelerini alıp başka bir dizi değişken içerisine aktaran ve 
// bunu ekranda listeleyen programı yazınız. 


//Random rnd = new Random();

//int[] arr = new int[10];
//double[] arr2 = new double[10];
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = rnd.Next(1,100);
//    arr2[i] = Math.Pow(arr[i],2);
//    Console.WriteLine(arr2[i]);
//}


//int[ , ] a = new int[2, 3];
//a[0, 0] = 10;
//a[0, 1] = 20;
//a[0, 2] = 30;
//a[1, 0] = 40;
//a[1, 1] = 50;
//a[1, 2] = 60;

//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.WriteLine(a[i,j]);
//    }
//}

// 3X3 lük bir matrisin içerisini 1-100 arası sayılarla dolduran 
// programı yazınız. 

//int[,] arr2D = new int[3, 3];

//Random rnd = new Random();

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        arr2D[i, j] = rnd.Next(1, 100);
//    }
//}


// N sayısı dışarıdan girilmek üzere. 
// N x N lik birim matrisi oluşturan ve bunu ekrana yazan
// prgramı yazınız. 

//Console.Write("N değerini giriniz ...:");
//int n = Convert.ToInt32(Console.ReadLine());

//int[,] matrix = new int[n, n];

//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        if (i == j)
//        {
//            matrix[i, j] = 1;
//        }
//        else
//        {
//            matrix[i,j] = 0;
//        }
//    }
//}

//for (int i = 0; i < n; i++)
//{
//    for(int j = 0;j < n; j++)
//    {
//        Console.Write(matrix[i,j] + " ");
//    }
//    Console.WriteLine();
//}


// Kolon sayısı dışarıdan girilmek üzere, kolon sayısı kadar sayısal loto tahminini 
// tek bir matriste taşıyan ve bunu ekrana yazan programı yazınız. 

// Not : 1 kolonda 1-49 arasında 6 adet sayı bulunur. 

//Console.Write("Kolon sayısını giriniz ...:");
//int kolonSayisi = Convert.ToInt32(Console.ReadLine());

//int[,] lotoTahmin = new int[kolonSayisi, 6];
//Random rand = new Random();

//for (int i = 0; i < kolonSayisi; i++)
//{
//    for (int j = 0; j < 6; j++)
//    {
//        lotoTahmin[i, j] = rand.Next(1, 49);
//    }
//}

//for (int i = 0;i < kolonSayisi; i++)
//{
//    for(int j = 0;j < 6; j++)
//    {
//        Console.Write(lotoTahmin[i,j] + " ");
//    }
//    Console.WriteLine();
//}


// n sayısı dışarıdan girilmek üzere. 
// nxn lik, 1-100 arası sayılarla doldurulmuş olan rastgele iki adet matrisi
// toplayan ve toplamını ekranda gösteren programı yazınız. 


Console.Write("N sayısını giriniz ...:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] a = new int[n, n];
int[,] b = new int[n, n];
int[,] t = new int[n, n];

Random rnd = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = rnd.Next(1, 100);
        b[i,j] = rnd.Next(1, 100);
        t[i, j] = a[i,j] + b[i,j];

        Console.Write(t[i,j] + " ");
    }
    Console.WriteLine();
}

