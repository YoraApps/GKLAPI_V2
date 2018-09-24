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
    public class DegreeTypeController : ApiController
    {
        private IDegreeTypeService degreetypeService = new DegreeTypeService();
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new { results = degreetypeService.GetDegreeType() });
        }

        [HttpPost]
        public IHttpActionResult UpdateDegreeType(DegreeType degreetype)
        {
            return Ok(new { results = degreetypeService.InUpDegreeType(degreetype) });
        }
    }
}
