using BusinessService.IService;
using DataAccess.DataSource;
using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Service
{
    public class DegreeTypeService : IDegreeTypeService
    {
        public List<DegreeType> GetDegreeType()
        {
            return DegreeTypeDS.GetAllDegreeType();
        }

        public List<DegreeType> GetDegreeTypeByCategory(int? id)
        {
            return DegreeTypeDS.GetDegreeTypeByCategory(id);
        }

        public string InUpDegreeType(DegreeType degreetype)
        {
            return DegreeTypeDS.UpdateDegreeType(degreetype);
        }
    }
}
