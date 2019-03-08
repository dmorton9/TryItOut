using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.DataAccess.Helpers
{
    public class UnitOfWork
    {
        public const string CurrentUnitOFWorkKey = "CurrentUnitOfWork.Key";

        private IUnitOfWorkFactory _unitOfWorkFactory = null;

        private IUnitOfWorkFactory UnitOfWorkFactory{

            get
            {
                if (_unitOfWorkFactory == null)
                {
                    
                }

                return _unitOfWorkFactory;
            }
        }

    }
}
