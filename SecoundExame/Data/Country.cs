using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecoundExame.Data
{
    [Table("Countries")]
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> employees { get; set; }
    }
}
