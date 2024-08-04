namespace Gun10_Method_ReturnValue
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double VKI = VKIHesapla(78, 1.76);
            Console.WriteLine($"VKI Değeriniz = {VKI}");

        }

        private static double VKIHesapla(double kilo, double boy)
        {
            double VKI = kilo / Math.Pow(boy, 2);
            return VKI;
        }
    }
}