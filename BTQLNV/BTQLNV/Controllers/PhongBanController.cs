using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BTQLNV.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace BTQLNV.Controllers
{
    public class PhongBanController : Controller
    {
        public List<PhongBanView> GetPhongBan()
        {
            List<PhongBanView> phongBan = new List<PhongBanView>();
            string url = "http://localhost:58349/api/phongban/get";
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

                phongBan = JsonConvert.DeserializeObject<List<PhongBanView>>(responseData);
                return phongBan;
            }
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
            var createResult = false;

            string url = "http://localhost:58349/api/phongban/create";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                var json = JsonConvert.SerializeObject(phongBan);
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
            ModelState.Clear();
            return View(new PhongBan() { });
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var userEdit = new PhongBan();

            var url = "http://localhost:58349/api/phongban/get/" + id;
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

                userEdit = JsonConvert.DeserializeObject<PhongBan>(responseData);
            }
            return View(userEdit);
        }

        [HttpPost]
        public IActionResult Edit(PhongBan model)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:58349/api/phongban/update");
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
            return RedirectToAction("Index", "PhongBan");
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:58349/api/phongban/delete/" + id);
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
