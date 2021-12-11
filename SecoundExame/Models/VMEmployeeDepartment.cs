using SecoundExame.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExame.Models
{
    public class VMEmployeeDepartment
    {
        public List<Employee> employees { get; set; }
        public List<Department> departments { get; set; }

    }
}
