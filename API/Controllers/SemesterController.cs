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
    public class SemesterController : ApiController
    {
        private ISemesterService semesterService = new SemesterService();
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new { results = semesterService.GetSemester() });
        }
        public IHttpActionResult GetSeesterByBranch(int BranchId)
        {
            return Ok(new { results = semesterService.GetSemesterByBranch(BranchId) });
        }
        [HttpPost]
        public IHttpActionResult UpdateSemester(Semester semester)
        {
            return Ok(new { results = semesterService.UpdateSemester(semester) });
        }
    }
}
