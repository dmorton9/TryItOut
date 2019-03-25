using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;


namespace TryItOut.Service
{
    public class Login_Service : ILogin_Service
    {
        private readonly ILogin_UnitOfWork UnitOfWork;

        public Login_Service(ILogin_UnitOfWork UnitOfWork) {

            this.UnitOfWork = UnitOfWork;
        }

        
        public UserLoginDTO LoginUser(string username, string password)
        {
            /* calls UnitOfWork for login tasks */
            var IsLoggedIn = UnitOfWork.LoginUser(username, password);

            return IsLoggedIn;
        }
    }
}
