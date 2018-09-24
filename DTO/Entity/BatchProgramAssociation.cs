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
        public string BatchId { get; set; }
        public string ProgramId { get; set; }
        public string SetAction { get; set; }
    }
}
