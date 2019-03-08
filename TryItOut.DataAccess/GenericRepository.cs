
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;

namespace TryItOut.DataAccess
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        public bool delete(int identifier)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Read(int identifier)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> Read()
        {
            throw new NotImplementedException();
        }

        public bool Save(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
