using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface ICourseChapterAssociationService 
    {
        List<CourseChapterAssociation> GetChapterByCourse(int CourseId);
        List<CourseChapterAssociation> UpdateCourseChapterAssociation(CourseChapterAssociation courseChapterAssociation);
        List<CourseChapterAssociation> GetCourseChapterNotMapped(int CourseId);
    }
}
