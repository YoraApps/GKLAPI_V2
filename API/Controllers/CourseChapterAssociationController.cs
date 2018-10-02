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
    public class CourseChapterAssociationController : ApiController
    {
        private ICourseChapterAssociationService courseChapterAssociationService = new CourseChapterAssociationService();

        [HttpGet]
        public IHttpActionResult GetChapterByCourse(int CourseId)
        {
            return Ok(new { results = courseChapterAssociationService.GetChapterByCourse(CourseId) });
        }
        public IHttpActionResult GetProgramBatchNotMapped(int CourseId)
        {
            return Ok(new { results = courseChapterAssociationService.GetCourseChapterNotMapped(CourseId) });
        }
        [HttpPost]
        public IHttpActionResult UpdateCourseChapterAssociation(CourseChapterAssociation courseChapterAssociation)
        {
            return Ok(new { results = courseChapterAssociationService.UpdateCourseChapterAssociation(courseChapterAssociation) });
        }
    }
}
