using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Department
    {
        public int ID { get;  set; } // why I have to make them public in order to be seen in the form class ? 
        public string Name { get;  set; }

        public List<Employee> Employees { get; set; }
    }
}
