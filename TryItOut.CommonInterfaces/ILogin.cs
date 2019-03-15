using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.CommonInterfaces
{
    public interface ILogin
    {
        int attempts { get; set; }
        bool Authenticate(string username, string password);
    }
}
