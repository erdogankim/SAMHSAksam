using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun12_Inheritance_Ornek
{
    public class AboneIslem
    {
        public static Fatura FaturaHesapla(Abone abone)
        {
            Fatura f = new Fatura();
            int kullanilanSu = abone.SonIndex - abone.IlkIndex;
            f.AraToplam = kullanilanSu * abone.BirimFiyat;
            f.KDVToplam = f.AraToplam * 0.20M;
            f.GenelToplam = f.AraToplam + f.KDVToplam;
            return f;

        }
    }
}
