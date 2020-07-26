using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesWebApp.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Position Position { get; set; }

    }
}
