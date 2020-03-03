using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code360StudentApp.Models
{
    public class Guarantor
    {
        public Guid Id { get; set; }
        public Student student { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[0-9_.+-]+$", ErrorMessage = "Invalid Phone Format")]
        public string Phone { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }

        public string Address { get; set; }


    }

   
}
