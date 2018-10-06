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
    public class AdmissionCriteriaAssociationController : ApiController
    {
        private IAdmissionCriteriaAssociationService admissionCriteriaAssociationService  = new AdmissionCriteriaAssociationService();

        [HttpGet]
        public IHttpActionResult GetAdmissionCriteriaAssociation (int BatchId,int ProgramId)
        {
            return Ok(new { results = admissionCriteriaAssociationService.GetAdmissionCriteriaAssociation(BatchId, ProgramId) });
        }
        [HttpPost]
        public IHttpActionResult UpdateAdmissionCriteriaAssociation(AdmissionCriteriaAssociation admissionCriteriaAssociation )
        {
            return Ok(new { results = admissionCriteriaAssociationService.UpdateAdmissionCriteriaAssociation(admissionCriteriaAssociation) });
        }
    }
}
