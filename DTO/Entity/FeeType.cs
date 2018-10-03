using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class FeeType
    {
        public string SetAction { get; set; }
        public int FeeTypeId { get; set; }
        public string FeeTypeName { get; set; }
        public string FeeTypeDescription { get; set; }
        public bool Active { get; set; }
    }
}
