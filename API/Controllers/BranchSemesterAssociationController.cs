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
    public class BranchSemesterAssociationController : ApiController
    {
        private IBranchSemesterAssociationService branchSemesterAssociationService = new BranchSemesterAssociationService();

        [HttpGet]
        public IHttpActionResult GetSemesterByBranch(int BranchId)
        {
            return Ok(new { results = branchSemesterAssociationService.GetSemesterByBranch(BranchId) });
        }
        public IHttpActionResult GetBranchSemesterNotMapped(int BranchId)
        {
            return Ok(new { results = branchSemesterAssociationService.GetBranchSemesterNotMapped(BranchId) });
        }
        [HttpPost]
        public IHttpActionResult UpdateBranchSemesterAssociation(BranchSemesterAssociation branchSemesterAssociation)
        {
            return Ok(new { results = branchSemesterAssociationService.UpdateBranchSemesterAssociation(branchSemesterAssociation) });
        }
    }
}
