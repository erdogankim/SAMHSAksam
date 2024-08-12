using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun12_Ornek
{
    public class Fatura
    {
        public int KullandigiSuMiktari { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal AraToplam { get; set; }
        public decimal KDVTutari { get; set; }
        public decimal GenelToplam { get; set; }
    }
}
