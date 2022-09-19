using Microsoft.AspNetCore.Mvc;
using NguyenVanToan_0709.Models;

namespace NguyenVanToan_0709.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            List<Employee> listNv = new List<Employee>()
            {
                new Employee {EmployeeID = 123, EmployeeName = "Nguyen Van A", EmployeeAge = 25},
                new Employee {EmployeeID = 124, EmployeeName = "Nguyen Van B", EmployeeAge = 21},
                new Employee {EmployeeID = 125, EmployeeName = "Nguyen Van C", EmployeeAge = 31},
                new Employee {EmployeeID = 126, EmployeeName = "Nguyen Van D", EmployeeAge = 21},

            };

            ViewData["Employees"] = listNv;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee std)
        {
            return View();
        }
    }
}
