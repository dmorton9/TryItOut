
using TryItOut.CommonInterfaces;

namespace TryItOut.Logic
{
    public class Login : ILogin
    {
        public int attempts {
            get => throw new System.NotImplementedException();
            set => throw new System.NotImplementedException();
        }

        public bool Authenticate(string username, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}
