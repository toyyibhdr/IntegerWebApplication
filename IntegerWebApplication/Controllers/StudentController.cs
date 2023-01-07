using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace IntegerWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new List<Student>();            
            student.Add(new Student()
            {
                Id = 1,
                Name = "Eling",
                Adress = "Banyumas",
                PhoneNumber = "089545567232"
            });

            student.Add(new Student()
            {
                Id = 2,
                Name = "Gilar",
                Adress = "Solo",
                PhoneNumber = "087756643432"
            });

            return View(student);
        }
    }
}
