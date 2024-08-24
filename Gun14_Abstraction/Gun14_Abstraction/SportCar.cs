using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun14_Abstraction
{
    public class SportCar : Car
    {
        public int DoorCount { get; set; }

        public override void AddToDb()
        {
            throw new NotImplementedException();
        }
    }
}
