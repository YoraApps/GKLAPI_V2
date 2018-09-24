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
    public class DegreeCategoryService : IDegreeCategoryService
    {
        public List<DegreeCategory> GetDegreeCategories()
        {
            return DegreeCategoryDS.GetAllDegreeCategory();
        }

        public string InUpDegreeCategories(DegreeCategory degreeCategory)
        {
            return DegreeCategoryDS.UpdateDegreeCategory(degreeCategory);
        }
    }
}
