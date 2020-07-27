using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace Web.Entities
{
    [DataContract]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100), DataMember(Name = "name")]
        public string Name { get; set; }

        [StringLength(100), Required(ErrorMessage = "Employee surname is required!"), DataMember(Name = "surname")]
        public string Surname { get; set; }

    }
}
