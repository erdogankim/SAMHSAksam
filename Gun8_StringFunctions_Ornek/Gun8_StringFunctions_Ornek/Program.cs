// , ile ayrılmış kişi listesini girdiğimiz sistemde
// Her kişi için ayrı ayrı vize ve final notlarını kullanıcıdan isteyen 
// Bu bilgileri bir aray içerisine kaydeden ve daha sonra ortalamayı hesaplayıp 
// genel sonucu ekranda gösteren programı yazınız. 


// Örn
// Kişileri giriniz ...: Ahmet,Mehmet
// Ahmet için vize notunu giriniz ...: 50
// Ahmet için final notunu giriniz ...: 80
// Ahmet için ortalama not = 65

// Mehmet için vize notunu giriniz ...: 60
// Mehmet için final notunu giriniz ...: 60
// Mehmet için ortalama = 60

// Ahmet    50     80     65
// Mehmet   60     60     60


Console.Write("Kişileri giriniz ....:");
string strKisiler = Console.ReadLine();

string[] kisiler = strKisiler.Split(",");

string[,] notlar = new string[kisiler.Length, 4];

for (int i = 0; i < kisiler.Length; i++)
{
    notlar[i,0] = kisiler[i];

    Console.Write(kisiler[i] + " için vize notunu giriniz ...:");
    notlar[i, 1] = Console.ReadLine();

    Console.Write(kisiler[i] + " için final notunu giriniz ...:");
    notlar[i, 2] = Console.ReadLine();

    notlar[i, 3] = ((Convert.ToInt32(notlar[i, 1]) + Convert.ToInt32(notlar[i, 2])) / 2)
                    .ToString();
}

for (int i = 0; i < kisiler.Length; i++)
{
    string yazi = $"{notlar[i,0]} - {notlar[i, 1]} - {notlar[i, 2]} - {notlar[i, 3]}";
    Console.WriteLine(yazi);
}