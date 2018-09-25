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
        List<BatchProgramAssociation> GetProgramByBatch(int BatchId);
        string UpdateProgramBatchAssociation(BatchProgramAssociation batchProgramAssociation);
        List<BatchProgramAssociation> GetProgramBatchNotMapped(int BatchId);
    }
}
