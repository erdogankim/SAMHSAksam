using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun14_Abstraction
{
    public abstract class Car
    {
        public int HP { get; set; }
        public int WheelSize { get; set; }

        public abstract void AddToDb();
    }
}