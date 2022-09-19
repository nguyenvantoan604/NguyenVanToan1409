using Microsoft.AspNetCore.Mvc;
using NguyenVanToan_0709.Models;

namespace NguyenVanToan_0709.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Student()
        {
            List<Student> stdList = new List<Student>()
            {
                new Student {StudentID = 1, StudentName = "Nguyen Van Toan", StudentAge = 22},
                new Student {StudentID = 2, StudentName = "Nguyen Van B", StudentAge = 21},
                new Student {StudentID = 3, StudentName = "Nguyen Van C", StudentAge = 21},
                new Student {StudentID = 4, StudentName = "Nguyen Van D", StudentAge = 21},
                new Student {StudentID = 5, StudentName = "Nguyen Van E", StudentAge = 21},
            };

            ViewData["Students"] = stdList;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            return View();
        }
    }
}
