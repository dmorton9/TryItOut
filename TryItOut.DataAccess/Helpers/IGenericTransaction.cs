using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.DataAccess.Helpers
{
    public interface IGenericTransaction
    {
        void Commit();

        void RollBack();

        Boolean RollbackOnly { get; set; }

        Boolean IsActive();
    }
}
