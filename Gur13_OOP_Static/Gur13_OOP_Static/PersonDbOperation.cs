using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gur13_OOP_Static
{
    public class PersonDbOperation
    {
        public PersonDbOperation()
        {
            Console.WriteLine("Instance constructor çalıştı");
        }

        static PersonDbOperation()
        {
            Console.WriteLine("Yetki kontrolü yapılıyor");
            Thread.Sleep(2000);
            Console.WriteLine("Cache kontrolü yapılıyor");
            Thread.Sleep(2000);
            Console.WriteLine("Static oluşum tamamlandı");
        }

        public static void AddPersonToDb(Person person)
        {
            Console.WriteLine(person.Name + " db ye eklendi");
        }

        public static void DeletePersonFromDb(Person person)
        {
            Console.WriteLine(person.Name + " db den silindi");
        }
    }
}
