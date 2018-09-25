using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class BatchProgramAssociation
    {
        public int BatchProgramAssociationId { get; set; }
        public int BatchId { get; set; }
        public int ProgramId { get; set; }
        public string SetAction { get; set; }
        public string ProgramIds { get; set; }
        public string ProgramCode { get; set; }
        public string ProgramName { get; set; }
        public bool Active { get; set; }

    }
}
