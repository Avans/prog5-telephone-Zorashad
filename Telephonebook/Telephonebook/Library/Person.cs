using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephonebook.Library
{
    class Person
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public int telephoneNumber { get; set; }
        public String fullname
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        public Person(String firstName, String lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(String firstName, String lastName, int telephoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.telephoneNumber = telephoneNumber;
        }
    }
}
