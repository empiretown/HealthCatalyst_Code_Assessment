using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Address { get; set; }
        public string Interest { get; set; }

        public int Age { get; set; }

        public Employee()
        {

        }
    }

   
}
