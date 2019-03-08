using System.Collections.Generic;
using TryItOut.Domain.Models;

namespace TryItOut.CommonInterfaces
{
    public interface IRegisteredUserRepository
    {
        bool Delete(int identity);
        bool Delete(RegisteredUser entity);
        IList<RegisteredUser> Read();
        RegisteredUser Read(int identifier);
        bool Save(RegisteredUser entity);
        bool Save(List<RegisteredUser> entity);
    }
}