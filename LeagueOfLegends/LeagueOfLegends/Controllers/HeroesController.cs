using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using LeagueOfLegends.DAL.Interface;
using LeagueOfLegends.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeagueOfLegends.Controllers
{
    public class HeroesController : Controller
    {
        IHeroesRepository _heroesRepository;
        public HeroesController(IHeroesRepository heroesRepository)
        {
            _heroesRepository = heroesRepository;
        }

        public IActionResult HeroesList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetHeroesList()
        {
            var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
            // Skiping number of Rows count  
            var start = Request.Form["start"].FirstOrDefault();
            // Paging Length 10,20  
            var length = Request.Form["length"].FirstOrDefault();
            // Sort Column Name  
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            // Sort Column Direction ( asc ,desc)  
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            // Search Value from (Search box)  
            var searchValue = Request.Form["search[value]"].FirstOrDefault();

            //Paging Size (10,20,50,100)  
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;

            var responseData = _heroesRepository.GetHeroesList();

            //Sorting  
            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
            {
                var prop = GetProperty(sortColumn);
                if (sortColumnDirection == "asc")
                {
                    responseData = responseData.OrderBy(prop.GetValue).ToList();
                }
                else
                {
                    responseData = responseData.OrderByDescending(prop.GetValue).ToList();
                }
            }

            //Search  
            if (!string.IsNullOrEmpty(searchValue))
            {
                responseData = (from h in responseData
                                where h.Name.Contains(searchValue)
                                select h).ToList();
            }

            //total number of rows count   
            recordsTotal = responseData.Count();

            //Paging   
            var data = responseData.Skip(skip).Take(pageSize).ToList();

            //Returning Json Data  
            return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }

        [HttpGet]
        public IActionResult GetHeroes(int id)
        {
            var responseData = _heroesRepository.GetHeroes(id);

            return Json(new { response = responseData, code = 1 });
        }

        //public IActionResult AddHeroes(UpdateHeroes model)
        //{

        //}

        //public IActionResult UpdateHeroes(UpdateHeroes model)
        //{

        //}

        //public IActionResult DeleteHeroes(int id)
        //{

        //}

        #region Private
        private PropertyInfo GetProperty(string name)
        {
            var properties = typeof(GetsHeroes).GetProperties();
            PropertyInfo prop = null;
            foreach (var item in properties)
            {
                if (item.Name.ToLower().Equals(name.ToLower()))
                {
                    prop = item;
                    break;
                }
            }
            return prop;
        }
        #endregion
    }
}