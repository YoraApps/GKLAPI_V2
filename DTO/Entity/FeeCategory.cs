using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class FeeCategory
    {
        public string SetAction { get; set; }
        public int FeeCategoryId { get; set; }
        public string FeeCategoryName { get; set; }
        public string FeeCategoryDescription { get; set; }
        public bool Active { get; set; }
    }
}
