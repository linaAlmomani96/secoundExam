using SecoundExame.Data;
using System.Collections.Generic;

namespace SecoundExame.Service
{
    public interface IDepartmentService
    {
        List<Department> GetAll();
    }
}