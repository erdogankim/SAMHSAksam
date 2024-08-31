using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun15_Interface
{
    public class DbOperation : Operation , ICacheSupport
    {
        public override void AddToDb(object obj)
        {
            Console.WriteLine("Object db ye eklendi");
        }

        public object GetFromCache(int id)
        {
            throw new NotImplementedException();
        }

        public override object GetFromDb(object obj)
        {
            return new Person()
            {
                Name = "Ahmet",
                PersonId = 1,
                Surname = "Demir"
            };
        }
    }
}
