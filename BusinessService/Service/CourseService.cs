using BusinessService.IService;
using DataAccess.DataSource;
using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Service
{
    public class CourseService : ICourseService
    {
        public List<Course> GetActiveCourse()
        {
            return CourseDS.GetActiveCourse();
        }

        public List<Course> GetCourse()
        {
            return CourseDS.GetAllCourse();
        }

        public List<Course> GetCourseBySemester(int SemesterId)
        {
            return CourseDS.GetCourseBySemester(SemesterId);
        }

        public List<Course> GetCourseType()
        {
            return CourseDS.GetAllCourseType();
        }

        public string UpdateCourse(Course course)
        {
            return CourseDS.UpdateCourse(course);
        }
    }
}
