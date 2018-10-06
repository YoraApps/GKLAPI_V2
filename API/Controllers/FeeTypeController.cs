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
    public class FeeTypeController : ApiController
    {
        private IFeeTypeService feeTypeService = new FeeTypeService();
        [HttpGet]
        public IHttpActionResult GetActiveFeeType()
        {
            return Ok(new { results = feeTypeService.GetAllActiveFeeType() });
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new { results = feeTypeService.GetFeeType() });
        }

        [HttpPost]
        public IHttpActionResult UpdateFeeType(FeeType feeType)
        {
            return Ok(new { results = feeTypeService.UpdateFeeType(feeType) });
        }
    }
}
