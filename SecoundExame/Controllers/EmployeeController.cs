using Microsoft.AspNetCore.Mvc;
using SecoundExame.Data;
using SecoundExame.Models;
using SecoundExame.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SecoundExame.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeService employeeService;
        IDepartmentService departmentService;
        ICountryService countryService;
        VMEmployeeDepartment vM;
        VMEmployee vMEmployee;
        public EmployeeController(IEmployeeService _employeeService, IDepartmentService _departmentService, ICountryService _countryService)
        {
            employeeService = _employeeService;
            departmentService = _departmentService;
            countryService = _countryService;
            vM = new VMEmployeeDepartment();
            vMEmployee = new VMEmployee();
        }
        public IActionResult Index()
        {
            vM.departments = departmentService.GetAll();
            vM.employees = new List<Data.Employee>();
            return View(vM);
        }
        public IActionResult EmpInDept(int id)
        {
            vM.departments = departmentService.GetAll();
            vM.employees = employeeService.GetEmpByDept(id);
            return View("Index",vM);
        }

        public IActionResult Delete(int id)
        {
            vM.departments = departmentService.GetAll();

            employeeService.Delete(id);
            vM.employees = new List<Data.Employee>();

            return View("Index", vM);

        }
        public IActionResult NewEmployee()
        {
            vMEmployee.departments = departmentService.GetAll();
            vMEmployee.countries = countryService.GetAll();
            return View(vMEmployee);
        }

        public IActionResult Save(VMEmployee vM)
        {
            if (ModelState.IsValid)
            {
                if (vM.FilePath.Length > 0)
                {
                    //string FilePath = Path.Combine(Directory.GetCurrentDirectory(), @"/wwwroot/Images/", vM.FilePath.FileName);
                    //vM.FilePath.CopyTo(new FileStream(FilePath, FileMode.Create));
                    //vM.employee.ImgPath = "http://localhost/SecoundExame" + @"/wwwroot/Images/" + vM.FilePath.FileName;
                }
                employeeService.Insert(vM.employee);
            }
            vMEmployee.departments = departmentService.GetAll();
            vMEmployee.countries = countryService.GetAll();
            return View("NewEmployee",vMEmployee);

        }
    }
}
