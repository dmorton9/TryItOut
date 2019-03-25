using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.CommonInterfaces
{
    public interface IRegisteredUsersService : IDisposable
    {
        bool AuthenticateUser(string username, string password);

        void Save();

        void Read(int identifier);
    }
}
