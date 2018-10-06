using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface IFeeTypeService
    {
        List<FeeType> GetFeeType();
        string UpdateFeeType(FeeType feeType);
        List<FeeType> GetAllActiveFeeType();
    }
}
