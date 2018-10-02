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
    public class AdmissionCriteriaController : ApiController
    {
        private IAdmissionCriteriaService admissionCriteriaService = new AdmissionCriteriaService();
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new { results = admissionCriteriaService.GetAdmissionCriteria() });
        }

        [HttpPost]
        public IHttpActionResult UpdateAdmissionCriteria (AdmissionCriteria admissionCriteria)
        {
            return Ok(new { results = admissionCriteriaService.UpdateAdmissionCriteria(admissionCriteria) });
        }
    }
}

