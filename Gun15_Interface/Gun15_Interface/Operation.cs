using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun15_Interface
{
    public abstract class Operation
    {
        public abstract void AddToDb(object obj);
        public abstract object GetFromDb(object obj);
    }
}
