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
    public class BranchController : ApiController
    {
        private IBranchService branchService = new BranchService();
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new { results = branchService.GetBranch() });
        }

        [HttpPost]
        public IHttpActionResult UpdateBranch(Branch branch)
        {
            return Ok(new { results = branchService.InUpBranch(branch) });
        }
    }
}
