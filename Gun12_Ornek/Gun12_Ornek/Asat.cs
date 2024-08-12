using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun12_Ornek
{
    public class Asat
    {
        public Fatura Hesapla(Abone abone)
        {
            Fatura fatura = new Fatura();

            fatura.KullandigiSuMiktari = abone.SonIndex - abone.IlkIndex;

            if (abone.AboneTuru == "Mesken")
            {
                fatura.BirimFiyat = 10.30M;
            }
            else
            {
                fatura.BirimFiyat = 7.50M;
            }

            fatura.AraToplam = fatura.BirimFiyat * fatura.KullandigiSuMiktari;
            fatura.KDVTutari = fatura.AraToplam * 0.20M;
            fatura.GenelToplam = fatura.AraToplam + fatura.KDVTutari;

            return fatura;
        }
    }
}
