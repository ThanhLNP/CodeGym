using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BTQLNV.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BTQLNV.Controllers
{
    public class NhanVienController : Controller
    {
        PhongBanController phongBan = new PhongBanController();

        public IActionResult Index(int id)
        {
            List<NhanVien> nhanVien = new List<NhanVien>();
            string url = "http://localhost:58349/api/nhanvien/gets/" + id;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            WebResponse response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                nhanVien = JsonConvert.DeserializeObject<List<NhanVien>>(responseData);
            }
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
            var createResult = false;

            string url = "http://localhost:58349/api/nhanvien/create";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(nhanVien);
                streamWriter.Write(json);
            }

            var response = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                createResult = bool.Parse(result);
            }
            if (createResult)
            {
                TempData["Success"] = "User has been created successfully";
            }
            ViewBag.PhongBan = phongBan.GetPhongBan();
            return View(new NhanVien());
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var userEdit = new NhanVien();

            var url = "http://localhost:58349/api/nhanvien/get/" + id;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }

                userEdit = JsonConvert.DeserializeObject<NhanVien>(responseData);
            }
            ViewBag.PhongBan = phongBan.GetPhongBan();
            return View(userEdit);
        }

        [HttpPost]
        public IActionResult Edit(NhanVien model)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:58349/api/nhanvien/update");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(model);

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
            return RedirectToAction("Index", "NhanVien", new { id = model.IDPB });
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id, int PBID)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:58349/api/nhanvien/delete/" + id);
            httpWebRequest.Method = "DELETE";
            var response = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = response.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream)?.Dispose();
                }
            }
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