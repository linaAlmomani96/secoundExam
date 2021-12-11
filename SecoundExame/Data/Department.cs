using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecoundExame.Data
{
    [Table("Departments")]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Maximum Salary")]

        public double MaxSalary { get; set; }
        [Display(Name = "Minimum Salary")]

        public double MinSalary { get; set; }

        public List<Employee> employees { get; set; }
    }
}