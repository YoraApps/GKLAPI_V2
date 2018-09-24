using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Entity;

namespace BusinessService.IService
{
   public interface IBatchProgramAssociation
    {
        int InsertBatchProgramAssociation(BatchProgramAssociation InsertBatchProgramAssociation);
        int UpdateBatchProgramAssociation(BatchProgramAssociation UpdateBatchProgramAssociation);
        int DeleteBatchProgramAssociation(BatchProgramAssociation DeleteBatchProgramAssociation);
        List<BatchProgramAssociation> GetByIdBatchProgramAssociation(BatchProgramAssociation DeleteBatchProgramAssociation);
        List<BatchProgramAssociation> GetAllBatchProgramAssociation(BatchProgramAssociation DeleteBatchProgramAssociation);
    }
}
