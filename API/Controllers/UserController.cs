using BusinessService.IService;
using BusinessService.Service;
using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class UserController : ApiController
    {
        public UserController()
        {
        }

        private IUserService userService = new UserService();
        [HttpGet]
        public IHttpActionResult GetUsers()
        {
            return Ok(new { results = userService.GetAllUser() });
        }

        [HttpGet]
        public IHttpActionResult GetUserById(int userid)
        {
            return Ok(new { results = userService.GetUserById(userid) });
        }

        [HttpPost]
        public IHttpActionResult InsertUpdateDeleteUser(User user)
        {
            return Ok(new { results = userService.InUpDeUser(user) });
        }
    }
}

