using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsingAJAX.Context;
using UsingAJAX.Models;

namespace UsingAJAX.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult CreateStudent([FromBody] Student std)
        {
            _context.Students.Add(std);
            _context.SaveChanges();
            string message = "SUCCESS";
            return Json(new { Message = message });
        }

        public JsonResult getStudent(string id)
        {
            List<Student> students = new List<Student>();
            students = _context.Students.ToList();
            return Json(students);
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
