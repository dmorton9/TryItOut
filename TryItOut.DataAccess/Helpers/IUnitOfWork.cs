using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.DataAccess.Helpers
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericTransaction CurrentTransaction { get; set; }

        void Commit();

        void Rollback();

        Boolean IsInActiveTransaction { get; }

        IGenericTransaction BeginTransaction();

        IGenericTransaction BeginTransaction(IsolationLevel isolationLevel);

        void TransactionalFlush();

        void TransactionalFlush(IsolationLevel isolationLevel);
    }
}
