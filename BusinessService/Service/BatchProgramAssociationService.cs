using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessService.IService;
using DTO.Entity;
using DataAccess.DataSource;
namespace BusinessService.Service
{
    public class BatchProgramAssociationService:IBatchProgramAssociation
    {
        public int InsertBatchProgramAssociation(BatchProgramAssociation batchProgramAssociation)
        {
            return BatchProgramAssociationDS.InsertBatchProgramAssociationDS(batchProgramAssociation);
        }

        public int UpdateBatchProgramAssociation(BatchProgramAssociation batchProgramAssociation)
        {
            return BatchProgramAssociationDS.UpdateBatchProgramAssociationDS(batchProgramAssociation);
        }

        public int DeleteBatchProgramAssociation(BatchProgramAssociation batchProgramAssociation)
        {
            return BatchProgramAssociationDS.DeleteBatchProgramAssociationDS(batchProgramAssociation);
        }

        public List<BatchProgramAssociation> GetByIdBatchProgramAssociation(BatchProgramAssociation batchProgramAssociation)
        {
            return BatchProgramAssociationDS.SelectIdByBatchProgramAssociationDS(batchProgramAssociation);
        }

        public List<BatchProgramAssociation> GetAllBatchProgramAssociation(BatchProgramAssociation batchProgramAssociation)
        {
            return BatchProgramAssociationDS.SelectAllProgramAssociationDS(batchProgramAssociation);
        }
    }
}
