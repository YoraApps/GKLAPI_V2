using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class Batch
    {
        public string SetAction { get; set; }
        public int BatchId { get; set; }
        public int AcademicYearId { get; set; }
        public string AcademicYear { get; set; }
    }
}
