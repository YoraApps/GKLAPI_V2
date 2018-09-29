using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
   public  class SemesterCourseAssociation
    {
        public int SemesterCourseAssociationId { get; set; }
        public int CourseId { get; set; }
        public int SemesterId { get; set; }
        public string SetAction { get; set; }
        public string CourseIds { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public bool Active { get; set; }
    }
}
