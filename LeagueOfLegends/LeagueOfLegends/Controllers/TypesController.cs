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
    public class TypesController : Controller
    {
        ITypesRepository _typesRepository;
        public TypesController(ITypesRepository typesRepository)
        {
            _typesRepository = typesRepository;
        }

        public IActionResult TypesList()
        {
            return View();
        }


        [HttpPost]
        public IActionResult GetTypesList()
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

            var responseData = _typesRepository.GetTypesList();

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
                responseData = (from t in responseData
                                where t.Name.Contains(searchValue)
                                select t).ToList();
            }

            //total number of rows count   
            recordsTotal = responseData.Count();

            //Paging   
            var data = responseData.Skip(skip).Take(pageSize).ToList();

            //Returning Json Data  
            return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }

        [HttpPost]
        public IActionResult AddTypes([FromBody] Types model)
        {
            var responseData = _typesRepository.AddTypes(model);

            return Json(new { response = responseData });
        }

        [HttpPost]
        public IActionResult UpdateTypes([FromBody] Types model)
        {
            var responseData = _typesRepository.UpdateTypes(model);

            return Json(new { response = responseData });
        }

        [HttpGet]
        public IActionResult DeleteTypes(int id)
        {
            var responseData = _typesRepository.DeleteTypes(id);

            return Json(new { response = responseData });
        }

        #region Private
        private PropertyInfo GetProperty(string name)
        {
            var properties = typeof(Types).GetProperties();
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