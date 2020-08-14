using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class EmployeePosition
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Employee is required!")]
        public Employee Employee { get; set; }

        [Required(ErrorMessage = "Position is required!")]
        public Position Position { get; set; }


        [Required(ErrorMessage = "Salary is required!"), Column(TypeName = "decimal(12, 4)")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "StartDate is required!")]
        public DateTime DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

    }
}
