using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Web.Entities
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200), Required(ErrorMessage = "Position name is required!")]
        public string Name { get; set; }

    }
}
