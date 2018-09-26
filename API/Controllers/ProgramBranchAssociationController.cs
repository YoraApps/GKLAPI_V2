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
        public IHttpActionResult GetProgramByBranch(int ProgramId)
        {
            return Ok(new { results = programBranchAssociationService.GetProgramByBranch(ProgramId) });
        }

        public IHttpActionResult GetProgramBranchNotMapped(int ProgramId)
        {
            return Ok(new { results = programBranchAssociationService.GetProgramBranchNotMapped(ProgramId) });
        }

        [HttpPost]
        public IHttpActionResult UpdateProgramBranchAssociation(ProgramBranchAssociation programBranchAssociation)
        {
            return Ok(new { results = programBranchAssociationService.UpdateProgramBranchAssociation(programBranchAssociation) });
        }
    }
}
