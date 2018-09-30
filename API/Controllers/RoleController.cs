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
    public class RoleController : ApiController
    {
        public RoleController()
        {
        }

        private IRoleService roleService = new RoleService();
        [HttpGet]
        public IHttpActionResult GetRole()
        {
            return Ok(new { results = roleService.GetAllRole() });
        }

        [HttpGet]
        public IHttpActionResult GetRoleById(int RoleId)
        {
            return Ok(new { results = roleService.GetRoleById(RoleId) });
        }

        [HttpPost]
        public IHttpActionResult InsertUpdateDeleteRole(Role role)
        {
            return Ok(new { results = roleService.InUpDeRole(role) });
        }
    }
}
