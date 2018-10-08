using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface ICourseService
    {
        List<Course> GetCourse();
        List<Course> GetCourseType();
        string UpdateCourse(Course course);
        List<Course> GetActiveCourse();
        List<Course> GetCourseBySemester(int SemesterId);
    }
}
