using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun11_OOP_AccessModifiers
{
    // Bir adet kişi nesnesi oluşturun. 
    // Bu kişi nesnesinde özellik olarak 

    // Ad, Soyad, TCKN, Telefon, Email, Doğum Tarihi, Doğum Yeri, Yasi özellikleri olsun. 
    internal class Person
    {
        public string name;

        string _surname;

        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }
        }


    }
}
