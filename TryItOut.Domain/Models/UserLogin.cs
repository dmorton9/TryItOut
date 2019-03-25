using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Domain.Models
{
    public class UserLogin
    {
        private bool _IsLoggedIn;
        private string _lastLoggedIn;
        private int _NumberOfAttempts;

        public bool IsLoggedIn { get => _IsLoggedIn; set => _IsLoggedIn = value; }
        public string LastLoggedIn { get => _lastLoggedIn; set => _lastLoggedIn = value; }
        public int NumberOfAttempts { get => _NumberOfAttempts; set => _NumberOfAttempts = value; }
    }
}
