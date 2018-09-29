using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
  public  class DegreeCategory
    {
        public string SetAction { get; set; }
        public int DegreeCategoryId { get; set; }
        public string DegreeCategoryCode { get; set; }
        public string DegreeCategoryName { get; set; }
        public bool Active { get; set; }

    }
}
