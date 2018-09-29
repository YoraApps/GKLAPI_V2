using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessService.IService;
using DTO.Entity;
using DataAccess.DataSource;
namespace BusinessService.Service
{
    public class BatchProgramAssociationService : IBatchProgramAssociation
    {
        public List<BatchProgramAssociation> GetProgramBatchNotMapped(int BatchId)
        {
           return BatchProgramAssociationDS.GetProgramBatchNotMapped(BatchId);
        }

        public List<BatchProgramAssociation> GetProgramByBatch(int BatchId)
        {
            return BatchProgramAssociationDS.GetProgramByBatch(BatchId);
        }

        public List<BatchProgramAssociation> UpdateProgramBatchAssociation(BatchProgramAssociation batchProgramAssociation)
        {
            return BatchProgramAssociationDS.UpdateProgramBatchAssociation(batchProgramAssociation);
        }
    }
}
