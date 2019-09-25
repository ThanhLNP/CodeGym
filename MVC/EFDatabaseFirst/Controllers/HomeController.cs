using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFDatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeContext _dbcontext;

        public HomeController(EmployeeContext dbContext)
        {
            _dbcontext = dbContext;
        }

        private List<SkillModel> GetSkills()
        {
            var skills = _dbcontext.tblSkills.Select(s => new SkillModel()
            {
                Title = s.Title,
                SkillID = s.SkillID
            }).ToList();
            return skills;
        }

        #region View list
        public IActionResult Index()
        {
            var _emplst = _dbcontext.tblEmployees.
                          Join(_dbcontext.tblSkills, e => e.SkillID, s => s.SkillID,
                          (e, s) => new EmployeeViewModel
                          {
                              EmployeeID = e.EmployeeID,
                              EmployeeName = e.EmployeeName,
                              PhoneNumber = e.PhoneNumber,
                              Skill = s.Title,
                              YearsExperience = e.YearsExperience
                          }).ToList();
            IList<EmployeeViewModel> emplst = _emplst;
            return View(emplst);
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Skills = GetSkills();
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreateModel model)
        {
            var employee = new tblEmployee()
            {
                EmployeeID = model.EmployeeID,
                EmployeeName = model.EmployeeName,
                PhoneNumber = model.PhoneNumber,
                SkillID = model.SkillID,
                YearsExperience = model.YearsExperience
            };
            _dbcontext.tblEmployees.Add(employee);

            try
            {
                if (_dbcontext.SaveChanges() > 0)
                {
                    TempData["Message"] = "Employee has been added successfully.";
                }
                else
                {
                    TempData["Error"] = "Something went wrong, please contact administrator.";
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
            }

            return RedirectToAction("Create");
        }
        #endregion

        #region Delete
        //chua dung model va view
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = _dbcontext.tblEmployees.Find(id);
            _dbcontext.Remove(employee);
            _dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        #region Details
        //dung chung model voi view
        [HttpGet]
        public IActionResult Details(int id)
        {
            var _employees = _dbcontext.tblEmployees.
                            Join(_dbcontext.tblSkills, e => e.SkillID, s => s.SkillID,
                            (e, s) => new EmployeeViewModel
                            {
                                EmployeeID = e.EmployeeID,
                                EmployeeName = e.EmployeeName,
                                PhoneNumber = e.PhoneNumber,
                                Skill = s.Title,
                                YearsExperience = e.YearsExperience
                            }).Where(e => e.EmployeeID == id).FirstOrDefault();
            return View(_employees);
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //var _employees = _dbcontext.tblEmployees.Where(e => e.EmployeeID == id).FirstOrDefault();
            //var employeeEdit = new EmployeeEditModel()
            //{
            //    EmployeeID = _employees.EmployeeID,
            //    EmployeeName = _employees.EmployeeName,
            //    PhoneNumber = _employees.PhoneNumber,
            //    SkillID = _employees.SkillID,
            //    YearsExperience = _employees.YearsExperience
            //};
            var employeeEdit = _dbcontext.tblEmployees.Select(e => new EmployeeEditModel()
            {
                EmployeeID = e.EmployeeID,
                EmployeeName = e.EmployeeName,
                PhoneNumber = e.PhoneNumber,
                SkillID = e.SkillID,
                YearsExperience = e.YearsExperience
            }).Where(e => e.EmployeeID == id).FirstOrDefault();
            ViewBag.Skills = GetSkills();
            return View(employeeEdit);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeEditModel model)
        {
            var employee = _dbcontext.tblEmployees.Find(model.EmployeeID);
            employee.EmployeeName = model.EmployeeName;
            employee.PhoneNumber = model.PhoneNumber;
            employee.SkillID = model.SkillID;
            employee.YearsExperience = model.YearsExperience;
            _dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
