using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TryItOut.CommonInterfaces;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccess
{
    public class RegisteredUserRepository : IRegisteredUserRepository
    {
        public RegisteredUserRepository()
        {
        }

        public bool authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Create(List<RegisteredUser> entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(RegisteredUser entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int identity )
        {
            throw new NotImplementedException();
        }

        public string LastLoggedIn_Read(int identifier)
        {
            throw new NotImplementedException();
        }

        public void LastLoggedIn_Update(int identifier)
        {
            throw new NotImplementedException();
        }

        public string NumberOfAtempts_Read(int identifier)
        {
            throw new NotImplementedException();
        }

        public void NumberOfAtempts_Update(int identifier)
        {
            throw new NotImplementedException();
        }

        public RegisteredUser Read(int identifier)
        {
            throw new NotImplementedException();
        }

        public IList<RegisteredUser> Read()
        {
            IList<RegisteredUser> users = new List<RegisteredUser>();

            try
            {               
                string filePath = HttpContext.Current.Server.MapPath("~/App_Data/RegisteredUsers.xml");

                System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(users.GetType());
                System.IO.StreamReader file = new System.IO.StreamReader(filePath);

                users = (List<RegisteredUser>)reader.Deserialize(file);

                file.Close();
            }
            catch
            {
                throw new Exception();
            }

            return users;
        }

        public bool Save(RegisteredUser entity) {

            return false;
        }

        public bool Save(List<RegisteredUser> entity)
        {
            try
            {
                var writer = new System.Xml.Serialization.XmlSerializer(entity.GetType());

                string filePath = HttpContext.Current.Server.MapPath("~/App_Data/RegisteredUsers.xml");

                var wfile = new System.IO.StreamWriter(filePath);
                writer.Serialize(wfile, entity);
                wfile.Close();
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
