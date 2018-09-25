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
    public class ProgramBranchAssociationController : ApiController
    {
        private IProgramBranchAssociationService programBranchAssociationService = new ProgramBranchAssociationService();

        [HttpGet]
        public IHttpActionResult GetProgramByBranch(int BranchId)
        {
            return Ok(new { results = programBranchAssociationService.GetProgramByBranch(BranchId) });
        }

        public IHttpActionResult GetProgramBranchNotMapped(int BranchId)
        {
            return Ok(new { results = programBranchAssociationService.GetProgramBranchNotMapped(BranchId) });
        }

        [HttpPost]
        public IHttpActionResult UpdateProgramBranchAssociation(ProgramBranchAssociation programBranchAssociation)
        {
            return Ok(new { results = programBranchAssociationService.UpdateProgramBranchAssociation(programBranchAssociation) });
        }
    }
}
