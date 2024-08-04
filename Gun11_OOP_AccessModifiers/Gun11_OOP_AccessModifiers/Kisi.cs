using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun11_OOP_AccessModifiers
{
    internal class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }

        public int Yas
        {
            get
            {
               return Convert.ToInt32((DateTime.Now - DogumTarihi).TotalDays / 365);
            }
        }
    }
}
