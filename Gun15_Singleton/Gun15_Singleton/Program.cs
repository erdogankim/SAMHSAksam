// See https://aka.ms/new-console-template for more information
using Gun15_Singleton;

Console.WriteLine("Service çalıştırılıyor.");

ServiceOperation operation = ServiceOperation.Instance;
Console.WriteLine("Service çalıştı.");

Console.WriteLine("ikinci service çalıştırılıyor");
ServiceOperation operation2 = ServiceOperation.Instance;
Console.WriteLine("ikinci service çalıştı");