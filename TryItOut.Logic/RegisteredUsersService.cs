using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;
using TryItOut.DataAccess;

namespace TryItOut.Service
{

    public class RegisteredUsersService : IRegisteredUsersService
    {
        private readonly IRegisteredUserRepository repo;

        public RegisteredUsersService()
        {
            this.repo = new RegisteredUserRepository();
        }

        public RegisteredUsersService(IRegisteredUserRepository repo)
        {
            this.repo = repo;
        }

        public RegisteredUsersDTO Read()
        {
            RegisteredUsersDTO usersDTO = new RegisteredUsersDTO();

            foreach(var user in repo.Read() )
            {
                usersDTO.NumberOf++;
                usersDTO.registeredUsers.Add(new RegisteredUserDTO()
                {
                    Identifier = user.Identifier,
                    Username = user.Username,
                    Password = user.Password,
                    Lastname = user.Lastname,
                    Firstname = user.Firstname,
                    IsActive = user.IsActive
                });
            }

            usersDTO.IsValid = true;

            return usersDTO;
        }

        /* ********************************* */
        /* Adds a new record to the XML file */
        /* ********************************* */

        public void Save()
        {
        }

        /* ******************************** */
        /* updates a record to the XML file */
        /* ******************************** */

        public void Update()
        {
        }

        public bool AuthenticateUser(string username, string password) {

            bool status = false;

            var users = repo.Read();

            return status;
        }

        public void Dispose()
        {
            /* ToDo */
        }

        public void Read(int identifier)
        {
            throw new NotImplementedException();
        }

        public UserLoginDTO LoginUser(string username, string password)
        {
            UserLoginDTO dto = new UserLoginDTO();

            RegisteredUsersService userServices = new RegisteredUsersService();

            dto.IsLoggedIn = true;
            dto.Message = "Invalid username and/or password";

            return dto;
        }
    }
}
