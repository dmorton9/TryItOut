using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;
using TryItOut.DataAccess;
using TryItOut.Logic.DTOs;

namespace TryItOut.Logic
{
    public class RegisteredUsersService
    {
        IRegisteredUserRepository repo;

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
            var user = repo.Read();

            List<Domain.Models.RegisteredUser> users = new List<Domain.Models.RegisteredUser>();

            users.Add(new Domain.Models.RegisteredUser() { Identifier = 1, Username = "Admin", Firstname = "System", Lastname = "Admin", Password = "", IsActive = true });
            users.Add(new Domain.Models.RegisteredUser() { Identifier = 2, Username = "dmorton9", Firstname="David", Lastname="Morton", Password = "", IsActive = true });

            repo.Save(users);
        }

        /* ******************************** */
        /* updates a record to the XML file */
        /* ******************************** */

        public void Update()
        {
            var user = repo.Read();

            List<Domain.Models.RegisteredUser> users = new List<Domain.Models.RegisteredUser>();

            repo.Save(users);
        }
    }
}
