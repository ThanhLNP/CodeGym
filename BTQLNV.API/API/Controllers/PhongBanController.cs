using BAL;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    public class PhongBanController : ControllerBase
    {
        PhongBanService _phongBanService;

        public PhongBanController(PhongBanService phongBanService)
        {
            _phongBanService = phongBanService;
        }

        // GET api/values
        [HttpGet]
        [Route("api/phongban/get")]
        public IEnumerable<PhongBanView> Get()
        {
            return _phongBanService.GetAllPhongBan();
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/phongban/get/{id}")]
        public PhongBanView Get(int ID)
        {
            return _phongBanService.GetPhongBanByID(ID);
        }

        // POST api/values
        [HttpPost]
        [Route("api/phongban/create")]
        public bool Post([FromBody] PhongBan phongBan)
        {
            return _phongBanService.CreatePhongBan(phongBan);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("api/phongban/update")]
        public bool Put([FromBody] PhongBan phongBan)
        {
            return _phongBanService.UpdatePhongBan(phongBan);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("api/phongban/delete/{id}")]
        public bool Delete(int ID)
        {
            return _phongBanService.DeletePhongBan(ID);
        }
    }
}
