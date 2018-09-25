using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class ProgramBranchAssociation
    {
        public int ProgramBranchAssociationId { get; set; }
        public int BranchId { get; set; }
        public int ProgramId { get; set; }
        public string SetAction { get; set; }
        public string ProgramIds { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public bool Active { get; set; }

    }
}
