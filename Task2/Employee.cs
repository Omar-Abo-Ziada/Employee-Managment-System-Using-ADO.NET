using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Employee
    {
        public int SSN { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }

        public Department Department { get; set; }
    }
}
