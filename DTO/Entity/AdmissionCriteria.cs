using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class AdmissionCriteria
    {
        public string SetAction { get; set; }
        public int CriteriaId { get; set; }
        public string CriteriaDescription { get; set; }
        public bool Active { get; set; }
    }
}
