using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessService.IService;
using BusinessService.Service;
using DTO.Entity;

namespace API.Controllers
{
    public class BatchProgramAssociationController : ApiController
    {
        private IBatchProgramAssociation batchProgramAssociationService = new BatchProgramAssociationService();

        [HttpGet]
        public IHttpActionResult GetProgramByBatch(int BatchId)
        {
            return Ok(new { results = batchProgramAssociationService.GetProgramByBatch(BatchId) });
        }
        public IHttpActionResult GetProgramBatchNotMapped(int BatchId)
        {
            return Ok(new { results = batchProgramAssociationService.GetProgramBatchNotMapped(BatchId) });
        }
        [HttpPost]
        public IHttpActionResult UpdateProgramBatchAssociation(BatchProgramAssociation batchProgramAssociation)
        {
            return Ok(new { results = batchProgramAssociationService.UpdateProgramBatchAssociation(batchProgramAssociation) });
        }
    }
}
