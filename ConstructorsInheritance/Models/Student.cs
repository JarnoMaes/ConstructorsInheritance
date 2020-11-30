using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsInheritance.Models
{
    public class Student : Person
    {
        public string Subject { get; set; }

        public Student(string firstName, string lastName)
            :base(firstName, lastName)                          //.base stuur de waardes naar de parent class!          
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
