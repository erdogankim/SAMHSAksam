using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun15_Interface3
{
    public class DbOperation
    {
        private IDbRepository _repository;
        public DbOperation(IDbRepository repository)
        {
            _repository = repository;
        }

        public void InsertEntityToDb(IEntity entity)
        {
            _repository.AddToDb(entity);
        }
    }
}
