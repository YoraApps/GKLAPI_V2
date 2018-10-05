using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface IFeeCategoryService
    {
        List<FeeCategory> GetFeeCategory();
        string UpdateFeeCategory(FeeCategory feeCategory);
        List<FeeCategory> GetAllActiveFeeCategory();
    }
}
