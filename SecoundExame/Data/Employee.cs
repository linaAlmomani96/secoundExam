using SecoundExame.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExame.Data
{[Table("Employees")]
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }
        //[RegularExpression(@"^(\+0?1\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$")]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [ForeignKey("country")]
        [Display(Name ="Country")]
        public int Country_Id { get; set; }
        public Country country { get; set; }

        [ForeignKey("department")]
        [Display(Name = "Department")]
        public int Department_Id { get; set; }
        public Department department { get; set; }
        [DateValidation]
        public DateTime Birthdate { get; set; }
        public string ImgPath { get; set; }
    }
}
