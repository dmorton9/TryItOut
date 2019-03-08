using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Domain.Models
{
    public class RegisteredUser : IRegisteredUser
    {
        private int _identifier;
        private string _username;
        private string _password;
        private string _firstname;
        private string _lastname;
        private bool _IsActive;

        public int Identifier { get => _identifier; set => _identifier = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
    }
}
