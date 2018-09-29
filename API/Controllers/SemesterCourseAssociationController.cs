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
    public class SemesterCourseAssociationController : ApiController
    {
        private ISemesterCourseAssociationService semesterCourseAssociationService = new SemesterCourseAssociationService();

        [HttpGet]
        public IHttpActionResult GetCourseBySemester(int SemesterId)
        {
            return Ok(new { results = semesterCourseAssociationService.GetCourseBySemester(SemesterId) });
        }
        public IHttpActionResult GetSemesterCourseNotMapped(int SemesterId)
        {
            return Ok(new { results = semesterCourseAssociationService.GetSemesterCourseNotMapped(SemesterId) });
        }
        [HttpPost]
        public IHttpActionResult UpdateSemesterCourseAssociation(SemesterCourseAssociation semesterCourseAssociation)
        {
            return Ok(new { results = semesterCourseAssociationService.UpdateSemesterCourseAssociation(semesterCourseAssociation) });
        }
    }
}
