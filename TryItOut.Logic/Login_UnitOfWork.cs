
using TryItOut.CommonInterfaces;
using TryItOut.Domain.Models;

namespace TryItOut.Service
{
    public class Login_UnitOfWork : ILogin_UnitOfWork
    {
        /* ****************** */
        /* Unit of work class */
        /* ****************** */

        private readonly IRegisteredUserRepository RegUserRepo;

        public Login_UnitOfWork(IRegisteredUserRepository RegUserRepo)
        {
            this.RegUserRepo = RegUserRepo;
        }

        /* The unit of work would be 
         * a. authenticate user
         * b. update LastLogedIn
         * c. reset number of attempts */

        public UserLogin LoginUser(string username, string password)
        {
            UserLogin rtnDetails = new UserLogin();

            if( RegUserRepo.IsValidUser(username, password).IsLoggedIn ) {

                /* Is a valid user */
                rtnDetails.IsLoggedIn = true;
                /* Update last logged In */
                RegUserRepo.LastLoggedIn_Update(1);
                /* Reset attempts */
                RegUserRepo.NumberOfAtempts_Update(1, 0);
            }

            return rtnDetails;
        }

    }

}
