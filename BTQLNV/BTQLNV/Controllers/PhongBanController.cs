using BTQLNV.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace BTQLNV.Controllers
{
    public class PhongBanController : Controller
    {
        WebRequestMethod webRequest = new WebRequestMethod();

        public List<PhongBanView> GetPhongBan()
        {
            var url = "http://localhost:58349/api/phongban/get";
            var responseData = webRequest.GetOrDelete(url, "GET");

            List<PhongBanView> phongBan = new List<PhongBanView>();
            phongBan = JsonConvert.DeserializeObject<List<PhongBanView>>(responseData);
            return phongBan;
        }

        public IActionResult Index()
        {
            return View(GetPhongBan());
        }

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PhongBan phongBan)
        {
            string url = "http://localhost:58349/api/phongban/create";
            var createResult = webRequest.PutOrPost(url, "POST", phongBan);
            if (createResult)
            {
                TempData["Success"] = "User has been created successfully";
            }
            ModelState.Clear();
            return View(new PhongBan() { });
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var url = "http://localhost:58349/api/phongban/get/" + id;
            var responseData = webRequest.GetOrDelete(url, "GET");

            var userEdit = new PhongBan();
            userEdit = JsonConvert.DeserializeObject<PhongBan>(responseData);
            return View(userEdit);
        }

        [HttpPost]
        public IActionResult Edit(PhongBan phongBan)
        {
            string url = "http://localhost:58349/api/phongban/update";
            var createResult = webRequest.PutOrPost(url, "PUT", phongBan);
          
            return RedirectToAction("Index", "PhongBan");
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var url = "http://localhost:58349/api/phongban/delete/" + id;
            var responseData = webRequest.GetOrDelete(url, "DELETE");

            return RedirectToAction("Index", "PhongBan");
        }
        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
