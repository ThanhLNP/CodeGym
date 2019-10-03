using BAL;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        NhanVienService _nhanVienService;

        public NhanVienController(NhanVienService nhanVienService)
        {
            _nhanVienService = nhanVienService;
        }

        // GET api/values
        [HttpGet]
        [Route("api/nhanvien/gets/{id}")]
        public IEnumerable<NhanVien> Gets(int ID)
        {
            return _nhanVienService.GetAllNhanVien(ID);
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/nhanvien/get/{id}")]
        public NhanVien Get(int id)
        {
            return _nhanVienService.GetNhanVienByMaNV(id);
        }

        // POST api/values
        [HttpPost]
        [Route("api/nhanvien/create")]
        public bool Post([FromBody] NhanVien nhanVien)
        {
            return _nhanVienService.CreateNhanVien(nhanVien);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("api/nhanvien/update")]
        public bool Put([FromBody] NhanVien nhanVien)
        {
            return _nhanVienService.UpdateNhanVien(nhanVien);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("api/nhanvien/delete/{id}")]
        public bool Delete(int id)
        {
            return _nhanVienService.DeleteNhanVien(id);
        }
    }
}
