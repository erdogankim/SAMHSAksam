using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun12_Ornek2
{
    public class MobilOdeme
    {
        public Fatura OdemeYap(Abone abone, Urun urun, int adet)
        {
            Fatura f = new Fatura();

            if (urun.Tur == "Tekel")
            {
                f.AraToplam = f.KDVTutari = f.GenelToplam = 0;
                return f;
            }

            switch (abone.TelefonNo.Substring(0, 3))
            {
                case "555":
                case "505":
                case "507":
                case "554": f.OdemeKurulusu = "TT"; break;

                case "535":
                case "532":
                case "533":
                case "536": f.OdemeKurulusu = "Turkcell"; break;

                case "541":
                case "542":
                case "543":
                case "544":
                case "545":
                case "546":
                case "547": f.OdemeKurulusu = "Vodafone"; break;

            }

            f.AraToplam = urun.Fiyat * adet;
            f.KDVTutari = (f.AraToplam / 100) * (decimal)urun.KDV;
            f.GenelToplam = f.AraToplam + f.KDVTutari;

            return f;

        }
    }
}
