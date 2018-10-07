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
    public class FeeCategoryService : IFeeCategoryService
    {
        public List<FeeCategory> GetAllActiveFeeCategory()
        {
            return FeeCategoryDS.GetActiveFeeCategory();
        }

        public List<FeeCategory> GetFeeCategory()
        {
            return FeeCategoryDS.GetAllFeeCategory();
        }

        public FeeCategory UpdateFeeCategory(FeeCategory feeCategory)
        {
            return FeeCategoryDS.UpdateFeeCategory(feeCategory);
        }
    }
}
