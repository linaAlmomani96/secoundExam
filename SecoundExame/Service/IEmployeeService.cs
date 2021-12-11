using SecoundExame.Data;
using System.Collections.Generic;

namespace SecoundExame.Service
{
    public interface IEmployeeService
    {
        List<Employee> GetEmpByDept(int id);
        void Delete(int id);
        void Insert(Employee employee);
    }
}