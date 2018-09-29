using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface ISemesterCourseAssociationService
    {
        List<SemesterCourseAssociation> GetCourseBySemester(int SemesterId);
        List<SemesterCourseAssociation> UpdateSemesterCourseAssociation(SemesterCourseAssociation semesterCourseAssociation);
        List<SemesterCourseAssociation> GetSemesterCourseNotMapped(int SemesterId);
    }
}
