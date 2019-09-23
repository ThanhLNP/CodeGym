using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFDatabaseFirst.Models;

namespace EFDatabaseFirst.Controllers
{
    public class HomeController : Controller
    {

        private readonly EmployeeContext _dbcontext;

        public HomeController(EmployeeContext dbContext)
        {
            _dbcontext = dbContext;
        }
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
