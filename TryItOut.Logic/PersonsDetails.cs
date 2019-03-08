using System;
using System.Collections.Generic;
using System.Text;
using TryItOut.CommonInterfaces;

namespace TryItOut.Logic
{
    public class PersonsDetails
    {
        IPerson person;
        IAddress address;

        public PersonsDetails() { }

        public PersonsDetails(IPerson person,IAddress address) {

            this.person = person;
            this.address = address;
        }
    }
}
