using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class BranchSemesterAssociation
    {
        public int BranchSemesterAssociationId { get; set; }
        public int BranchId { get; set; }
        public int SemesterId { get; set; }
        public string SetAction { get; set; }
        public string SemesterIds { get; set; }
        public string SemesterCode { get; set; }
        public string SemesterName { get; set; }
        public bool Active { get; set; }
    }
}
