using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class CourseChapterAssociation
    {
        public int CourseChapterAssociationId { get; set; }
        public int CourseId { get; set; }
        public int ChapterId { get; set; }
        public string SetAction { get; set; }
        public string ChapterCode { get; set; }
        public string ChapterName { get; set; }
        public bool Active { get; set; }
        public string ChapterIds { get; set; }
    }
}
