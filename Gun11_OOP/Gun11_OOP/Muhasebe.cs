namespace MyNamespace
{
    internal class Muhasebe
    {
        public Muhasebe()
        {
            Console.WriteLine("Muhasebe nesnesi oluştu");
        }

        public double Hesapla(int CGS, double gunlukMaas)
        {
            return CGS * gunlukMaas;
        }
    }
}
