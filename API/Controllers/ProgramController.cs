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
    public class ProgramController : ApiController
    {
        private IProgramService programService = new ProgramService();
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new { results = programService.GetProgram() });
        }

        [HttpPost]
        public IHttpActionResult InUpPrograms(Program program)
        {
            return Ok(new { results = programService.InUpProgram(program) });
        }
    }
}
