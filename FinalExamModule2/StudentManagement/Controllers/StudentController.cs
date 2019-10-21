using Microsoft.AspNetCore.Mvc;
using StudentManagement.DAL;
using StudentManagement.Models;
using StudentManagement.Models.Language.Response;
using StudentManagement.Models.Level.Response;
using StudentManagement.Models.Student.Request;
using System.Collections.Generic;
using System.Diagnostics;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepository _StudentRepository = new StudentRepository();
        private readonly LanguageRepository _LanguageRepository = new LanguageRepository();
        private readonly LevelRepository _LevelRepository = new LevelRepository();

        private IList<LanguageList> GetLanguageList()
        {
            return _LanguageRepository.GetLanguageList();
        }

        private IList<AllLevel> GetAllLevel()
        {
            return _LevelRepository.GetAllLevel();
        }

        private List<string> GetSearchList()
        {
            List<string> SearchList = new List<string>()
            {
                "Name",
                "Email"
            };
            return SearchList;
        }

        [HttpGet]
        public IActionResult StudentsList()
        {
            ViewBag.SearchList = GetSearchList();
            return View(_StudentRepository.GetStudentList());
        }

        [HttpGet]
        public IActionResult Student(GetStudent model)
        {
            return View(_StudentRepository.GetStudent(model));
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            ViewBag.Language = GetLanguageList();
            ViewBag.Level = GetAllLevel();
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(AddStudent model)
        {
            var createResult = _StudentRepository.AddStudent(model);

            if (ModelState.IsValid)
            {
                if (createResult > 0)
                {
                    TempData["Success"] = "Student has been added success";
                }
                else
                {
                    TempData["Error"] = "Something went wrong, please try again later";
                }
            }
            ModelState.Clear();
            ViewBag.Language = GetLanguageList();
            ViewBag.Level = GetAllLevel();
            return View(new AddStudent());
        }

        [HttpGet]
        public IActionResult DeleteStudent(DeleteStudent model)
        {
            _StudentRepository.DeleteStudent(model);
            return RedirectToAction("StudentsList", "Student");
        }

        [HttpPost]
        public IActionResult StudentSearch(StudentSearch model)
        {
            ViewBag.SearchList = GetSearchList();
            return View(_StudentRepository.StudentSearch(model));
        }

        [HttpGet]
        public IActionResult EditStudent(GetStudent model)
        {
            ViewBag.Language = GetLanguageList();
            ViewBag.Level = GetAllLevel();
            return View(_StudentRepository.GetStudent(model));
        }

        [HttpPost]
        public IActionResult EditStudent(UpdateStudent model)
        {
            var createResult = _StudentRepository.UpdateStudent(model);

            if (ModelState.IsValid)
            {
                if (createResult > 0)
                {
                    return RedirectToAction("StudentsList");
                }
                else
                {
                    TempData["Error"] = "Something went wrong, please try again later";
                }
            }
            ViewBag.Language = GetLanguageList();
            ViewBag.Level = GetAllLevel();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
