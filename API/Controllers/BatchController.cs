using BusinessService.IService;
using BusinessService.Service;
using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class BatchController : ApiController
    {
        private IBatchService batchService = new BatchService();
        [HttpGet]
        public IHttpActionResult GetAcademicYear()
        {
            return Ok(new { results = batchService.GetAcademicYear() });
        }

        [HttpGet]
        public IHttpActionResult GetBatch()
        {
            return Ok(new { results = batchService.GetBatch() });
        }

        [HttpPost]
        public IHttpActionResult UpdateBatch(Batch batch)
        {
            return Ok(new { results = batchService.InUpBatch(batch) });
        }

        //Active Batch
        [HttpGet]
        public IHttpActionResult GetActiveBatch()
        {
            return Ok(new { results = batchService.GetActiveBatch() });
        }
    }
}
