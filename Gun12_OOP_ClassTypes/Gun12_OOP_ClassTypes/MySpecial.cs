using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun12_OOP_ClassTypes
{
    public class MySpecial
    {
        static MySpecial()
        {
            Console.WriteLine("Static constructor çalıştı");
        }
        public MySpecial()
        {
            Console.WriteLine("MySpecial instance contructor çalıştı");
        }

        public void InstanceMesajYaz()
        {
            Console.WriteLine("Instance member çalıştı");
        }

        public static void StaticMesajYaz()
        {
            Console.WriteLine("Static member çalıştı");
        }
    }
}
