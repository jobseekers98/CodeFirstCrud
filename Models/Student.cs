using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstCrud.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter your anme")]
        [Column(TypeName = "nvarchar(270)")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter your age")]
     
        public int Age { get; set; }
        [Required(ErrorMessage ="Please enter your collegename")]
        [Column(TypeName = "nvarchar(270)")]
        public string Collegename { get; set; }
        [Required(ErrorMessage ="Please enter your Address")]
        [Column(TypeName = "nvarchar(270)")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your Email Address")]
        [Column(TypeName = "nvarchar(270)")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your password ")]
        [Column(TypeName = "nvarchar(270)")]
        public string Password { get; set; }


    }

}
