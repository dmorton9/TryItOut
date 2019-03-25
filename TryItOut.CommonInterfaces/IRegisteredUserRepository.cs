using System.Collections.Generic;
using TryItOut.Domain.Models;

namespace TryItOut.CommonInterfaces
{
    public interface IRegisteredUserRepository
    {
        /* Delete user from XML file */
        bool Delete(int identity);
        bool Delete(RegisteredUser entity);
        /* ************************* */

        /* Read user from XML file */
        IList<RegisteredUser> Read();
        RegisteredUser Read(int identifier);
        /* ************************* */

        /* Read user from XML file */
        bool Save(RegisteredUser entity);
        bool Save(List<RegisteredUser> entity);
        /* *********************** */

        /* Create user from XML file */
        bool Create(List<RegisteredUser> entity);
        /* ************************* */

        /* authenticate user against XML file */
        bool Authenticate(string username, string password);

        UserLogin IsValidUser(string username, string password);
        /* ********************************** */

        /* Last logged In details for user from XML file */
        string LastLoggedIn_Read(int identifier);

        void LastLoggedIn_Update(int identifier);
        /* ******************************************** */

        /* number of attempts details for user from XML file */
        string NumberOfAtempts_Read(int identifier);

        void NumberOfAtempts_Update(int identifier,int numberOfAttempts);
        /* ******************************************** */
    }
}