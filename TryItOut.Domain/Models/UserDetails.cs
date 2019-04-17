using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Domain.Models
{
    public class UserDetails
    {
        private bool _IsLoggedIn;
        private int _Identifier;
        private string _UserName;
        private string _LastName;
        private string _FirstName;
        private string _LastLoggedIn;
        private int _NumberOfAttempts;

        public bool IsLoggedIn { get => _IsLoggedIn; set => _IsLoggedIn = value; }
        public int Identifier { get => _Identifier; set => _Identifier = value; }
        public string UserName { get => _UserName; set => _UserName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastLoggedIn { get => _LastLoggedIn; set => _LastLoggedIn = value; }
        public int NumberOfAttempts { get => _NumberOfAttempts; set => _NumberOfAttempts = value; }
    }
}
