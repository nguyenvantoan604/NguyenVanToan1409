using Microsoft.AspNetCore.Mvc;
using NguyenVanToan_0709.Models;

namespace NguyenVanToan_0709.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Person()
        {
            List<Person> stdList = new List<Person>()
            {
                new Person {Id = 1, Name = "Nguyen Van T", Age = 22},
                new Person {Id = 2, Name = "Nguyen Van F", Age = 22},
                new Person {Id = 3, Name = "Nguyen Van G", Age = 22},
                new Person {Id = 4, Name = "Nguyen Van H", Age = 22},
                new Person {Id = 5, Name = "Nguyen Van J", Age = 22},

            };

            ViewData["Persons"] = stdList;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person std)
        {
            return View();
        }
    }
}
