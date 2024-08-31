using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun15_Singleton
{
    public class ServiceOperation
    {

        private static ServiceOperation _instance;

        private ServiceOperation()
        {
            Thread.Sleep(5000);
        }

        public static ServiceOperation Instance
        {
            get
            {
                lock (new object())
                {
                    if (_instance == null)
                    {
                        _instance = new ServiceOperation();
                    }
                    return _instance; 
                }
            }
        }

    }
}
