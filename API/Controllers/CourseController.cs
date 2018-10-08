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
    public class CourseController : ApiController
    {
        private ICourseService courseService = new CourseService();
        [HttpGet]
        public IHttpActionResult GetCourseType()
        {
            return Ok(new { results = courseService.GetCourseType() });
        }
        [HttpGet]
        public IHttpActionResult GetCourse()
        {
            return Ok(new { results = courseService.GetCourse() });
        }

        [HttpPost]
        public IHttpActionResult UpdateCourse(Course course)
        {
            return Ok(new { results = courseService.UpdateCourse(course) });
        }
        //Active Batch
        [HttpGet]
        public IHttpActionResult GetActiveCourse()
        {
            return Ok(new { results = courseService.GetActiveCourse() });
        }
        [HttpGet]
        public IHttpActionResult GetCourseBySemester(int SemesterId)
        {
            return Ok(new { results = courseService.GetCourseBySemester(SemesterId) });
        }

    }
}
