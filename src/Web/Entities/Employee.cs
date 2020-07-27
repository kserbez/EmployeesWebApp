using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Web.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100), Required(ErrorMessage = "Employee surname is required!")]
        public string Surname { get; set; }

    }
}
