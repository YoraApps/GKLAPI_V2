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
    public class CourseChapterAssociationService : ICourseChapterAssociationService
    {
        public List<CourseChapterAssociation> GetChapterByCourse(int CourseId)
        {
            return CourseChapterAssociationDS.GetChapterByCourse(CourseId);
        }

        public List<CourseChapterAssociation> GetCourseChapterNotMapped(int CourseId)
        {
            return CourseChapterAssociationDS.GetCourseChapterNotMapped(CourseId);
        }

        public List<CourseChapterAssociation> UpdateCourseChapterAssociation(CourseChapterAssociation courseChapterAssociation)
        {
            return CourseChapterAssociationDS.UpdateCourseChapterAssociation(courseChapterAssociation);
        }
    }
}
