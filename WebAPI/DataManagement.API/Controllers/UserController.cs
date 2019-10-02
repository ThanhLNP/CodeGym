using DataManagement.Business.Interfaces;
using DataManagement.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DataManagement.API.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        // GET api/values
        [HttpGet]
        [Route("api/user/get")]
        public IEnumerable<User> Get()
        {
            return _userManager.GetAllUser();
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/user/get/{id}")]
        public User Get(int id)
        {
            return _userManager.GetUserById(id);
        }

        // POST api/values
        [HttpPost]
        [Route("api/user/create")]
        public bool Post([FromBody] User user)
        {
            return _userManager.AddUser(user);
        }

        // PUT api/values/5
        [HttpPut]
        [Route("api/user/update")]
        public bool Put([FromBody] User user)
        {
            return _userManager.UpdateUser(user);
        }

        // DELETE api/values/5
        [HttpDelete]
        [Route("api/user/delete/{id}")]
        public bool Delete(int id)
        {
            return _userManager.DeleteUser(id);
        }
    }
}
