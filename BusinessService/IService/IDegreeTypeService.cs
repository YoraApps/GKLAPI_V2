using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface IDegreeTypeService
    {
        List<DegreeType> GetDegreeType();
        List<DegreeType> GetDegreeTypeByCategory(int? id);
        string InUpDegreeType(DegreeType degreetype);
    }
}
