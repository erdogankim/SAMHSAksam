using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun11_OOP_Ornek
{
    internal class Yurt
    {
        public double Yerlesim(string sehir, string sinif, bool tekrar)
        {
            if (sehir == "İstanbul")
            {
                return 0;
            }

            double aylikUcret = 0;
            if (sinif == "1" || sinif == "2")
            {
                aylikUcret = 8000;
            }
            else
            {
                aylikUcret = 10000;
            }

            if (tekrar)
            {
                aylikUcret *= 1.25;
            }

            return aylikUcret;
        }
    }
}
