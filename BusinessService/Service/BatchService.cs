﻿using BusinessService.IService;
using DataAccess.DataSource;
using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Service
{
    public class BatchService : IBatchService
    {
        public List<Batch> GetAcademicYear()
        {
            return BatchDS.GetAllAcademicYear();
        }

        public List<Batch> GetActiveBatch()
        {
            return BatchDS.GetActiveBatch();
        }

        public List<Batch> GetBatch()
        {
            return BatchDS.GetAllBatch();
        }

        public List<Batch> InUpBatch(Batch batch)
        {
            return BatchDS.UpdateBatch(batch);
        }
    }
}
