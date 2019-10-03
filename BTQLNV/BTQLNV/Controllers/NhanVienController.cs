using BTQLNV.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BTQLNV.Controllers
{
    public class NhanVienController : Controller
    {
        PhongBanController phongBan = new PhongBanController();
        WebRequestMethod webRequest = new WebRequestMethod();

        public IActionResult Index(int id)
        {
            string url = "http://localhost:58349/api/nhanvien/gets/" + id;
            var responseData = webRequest.GetOrDelete(url, "GET");

            List<NhanVien> nhanVien = new List<NhanVien>();
            nhanVien = JsonConvert.DeserializeObject<List<NhanVien>>(responseData);
            var dsPhongBan = phongBan.GetPhongBan();
            ViewBag.PhongBan = dsPhongBan.Where(p => p.ID == id).FirstOrDefault();
            return View(nhanVien);
        }

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.PhongBan = phongBan.GetPhongBan();
            return View();
        }

        [HttpPost]
        public IActionResult Create(NhanVien nhanVien)
        {
            string url = "http://localhost:58349/api/nhanvien/create";
            var createResult = webRequest.PutOrPost(url, "POST", nhanVien);
            if (createResult)
            {
                TempData["Success"] = "User has been created successfully";
            }
            ModelState.Clear();
            ViewBag.PhongBan = phongBan.GetPhongBan();
            return View(new NhanVien());
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var url = "http://localhost:58349/api/nhanvien/get/" + id;
            var responseData = webRequest.GetOrDelete(url, "GET");

            var userEdit = new NhanVien();
            userEdit = JsonConvert.DeserializeObject<NhanVien>(responseData);
            ViewBag.PhongBan = phongBan.GetPhongBan();
            return View(userEdit);
        }

        [HttpPost]
        public IActionResult Edit(NhanVien model)
        {
            string url = "http://localhost:58349/api/nhanvien/update";
            var createResult = webRequest.PutOrPost(url, "PUT", model);
            return RedirectToAction("Index", "NhanVien", new { id = model.IDPB });
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id, int PBID)
        {
            var url = "http://localhost:58349/api/nhanvien/delete/" + id;
            var responseData = webRequest.GetOrDelete(url, "DELETE");
            return RedirectToAction("Index", "NhanVien", new { id = PBID });
        }
        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}