using Microsoft.AspNetCore.Http;
using SecoundExame.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExame.Models
{
    public class VMEmployee
    {
        public Employee employee { get; set; }
        public List<Country> countries { get; set; }
        public List<Department> departments { get; set; }
        public IFormFile FilePath { get; set; }

    }
}
