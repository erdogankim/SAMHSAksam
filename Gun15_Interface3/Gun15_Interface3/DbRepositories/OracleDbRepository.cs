using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun15_Interface3.DbRepositories
{
    public class OracleDbRepository : IDbRepository
    {
        public void AddToDb(IEntity entity)
        {
            Console.WriteLine("Entity oracle db ye eklendi");
        }
    }
}
