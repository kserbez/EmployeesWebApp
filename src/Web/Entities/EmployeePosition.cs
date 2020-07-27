using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class EmployeePosition
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Position is required!")]
        public Position Position { get; set; }

        [Required(ErrorMessage = "Employee is required!")]
        public Employee Employee { get; set; }

        [Required(ErrorMessage = "StartDate is required!")]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
