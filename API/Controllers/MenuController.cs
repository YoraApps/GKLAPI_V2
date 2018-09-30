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
    public class MenuController : ApiController
    {
        public MenuController()
        {
        }

        private IMenuService menuService = new MenuService();
        [HttpGet]
        public IHttpActionResult GetMenus()
        {
            return Ok(new { results = menuService.GetAllMenu() });
        }

        [HttpGet]
        public IHttpActionResult GetMenuById(int menuid)
        {
            return Ok(new { results = menuService.GetMenuById(menuid) });
        }

        [HttpPost]
        public IHttpActionResult InsertUpdateDeleteMenus(Menu menu)
        {
            return Ok(new { results = menuService.InUpDeMenu(menu) });
        }
    }
}


