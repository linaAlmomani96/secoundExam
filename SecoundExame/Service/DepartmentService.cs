using SecoundExame.Data;
using System.Collections.Generic;
using System.Linq;

namespace SecoundExame.Service
{
    public class DepartmentService: IDepartmentService
    {
        HRContext context;
        public DepartmentService(HRContext _context)
        {
            context = _context;
        }

        public List<Department> GetAll()
        {
            List<Department> departments = context.departments.ToList();
            return departments;
        }
    }
}