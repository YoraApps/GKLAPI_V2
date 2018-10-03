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
    public class FeeTypeService : IFeeTypeService
    {
        public List<FeeType> GetFeeType()
        {
            return FeeTypeDS.GetAllFeeType();
        }

        public string UpdateFeeType(FeeType feeType)
        {
            return FeeTypeDS.UpdateFeeType(feeType);
        }
    }
}
