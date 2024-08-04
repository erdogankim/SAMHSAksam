namespace MyNamespace
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //MyClass mcls = new MyClass(10);

            Muhasebe muh = new Muhasebe();
            double sonuc = muh.Hesapla(30, 3000);
            Console.WriteLine(sonuc);

        }
    }
}