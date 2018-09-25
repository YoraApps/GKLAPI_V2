using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class Program
    {
        public string SetAction { get; set; }
        public int ProgramId { get; set; }
        public string ProgramCode { get; set; }
        public string ProgramName { get; set; }
        public bool Active { get; set; }
        public int DegreeTypeId { get; set; }
        public string DegreeTypeCode { get; set; }
        public string DegreeTypeName { get; set; }
    }
}
