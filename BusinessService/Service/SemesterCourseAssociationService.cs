using BusinessService.IService;
using DTO.Entity;
using System;
using System.Collections.Generic;
using DataAccess.DataSource;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Service
{
    public class SemesterCourseAssociationService : ISemesterCourseAssociationService
    {
        public List<SemesterCourseAssociation> GetCourseBySemester(int SemesterId)
        {
            return SemesterCourseAssociationDS.GetCourseBySemester(SemesterId);
        }

        public List<SemesterCourseAssociation> GetSemesterCourseNotMapped(int SemesterId)
        {
            return SemesterCourseAssociationDS.GetSemesterCourseNotMapped(SemesterId);
        }

        public List<SemesterCourseAssociation> UpdateSemesterCourseAssociation(SemesterCourseAssociation semesterCourseAssociation)
        {
            return SemesterCourseAssociationDS.UpdateSemesterCourseAssociation(semesterCourseAssociation);
        }
    }
}
