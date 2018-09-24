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
        
        [HttpPut]
        public IHttpActionResult InsertbatchProgramAssociation(BatchProgramAssociation batchProgramAssociation)
        {
            return Ok(new { results = batchProgramAssociationService.InsertBatchProgramAssociation(batchProgramAssociation) });
        }

        [HttpPost]
        public IHttpActionResult UpdatebatchProgramAssociation(BatchProgramAssociation batchProgramAssociation)
        {
            return Ok(new { results = batchProgramAssociationService.InsertBatchProgramAssociation(batchProgramAssociation) });
        }

        [HttpDelete]
        public IHttpActionResult DeletebatchProgramAssociation(BatchProgramAssociation batchProgramAssociation)
        {
            return Ok(new { results = batchProgramAssociationService.InsertBatchProgramAssociation(batchProgramAssociation) });
        }

        [HttpGet]
        public IHttpActionResult GetById(BatchProgramAssociation batchProgramAssociation)
        {
            return Ok(new { results = batchProgramAssociationService.GetAllBatchProgramAssociation(batchProgramAssociation) });
        }

        [HttpGet]
        public IHttpActionResult GetAll(BatchProgramAssociation batchProgramAssociation)
        {
            return Ok(new { results = batchProgramAssociationService.GetByIdBatchProgramAssociation(batchProgramAssociation) });
        }
    }
}
