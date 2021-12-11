using SecoundExame.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExame.Service
{
    public class EmployeeService: IEmployeeService
    {
        HRContext context;
        public EmployeeService(HRContext _context)
        {
            context = _context;
        }

        public List<Employee> GetEmpByDept(int id)
        {
            List<Employee> employees = context.employees.Join(context.departments,
                                                                e => e.Department_Id,
                                                                 d => d.Id,
                                                                
                                                                 (em,de) => em
                                                                 ).Where(e=>e.Department_Id == id).ToList();
            return employees;
        }

        public void Delete(int id)
        {
            Employee employee = context.employees.Find(id);
            context.employees.Remove(employee);
            context.SaveChanges();
        }

        public void Insert(Employee employee)
        {
            context.employees.Add(employee);
            context.SaveChanges();
        }
    }
}
