using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.Domain;

namespace TryItOut.DataAccess
{
    public class PersonRepository : IPersonRepository
    {
        /* *****************************************************
         * Possible idea / school of thought that repository
         * code should not have Save or Delete as this can cause
         * repository (database) to become inconsistent when
         * some save/deletes work whilst others fail
         * A 'Unit of Work' should be used to handle work
         * packages (Repository Actions).
         * ************************************************** */

        public bool Delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public Person Read(int identifier)
        {
            throw new NotImplementedException();
        }

        public IList<Person> Read()
        {
            throw new NotImplementedException();
        }

        public bool Save(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
