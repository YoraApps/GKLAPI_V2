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
    public class FeeCategoryController : ApiController
    {
        private IFeeCategoryService feeCategoryService = new FeeCategoryService();
        [HttpGet]
        public IHttpActionResult GetActiveFeeCategory()
        {
            return Ok(new { results = feeCategoryService.GetAllActiveFeeCategory() });
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new { results = feeCategoryService.GetFeeCategory() });
        }

        [HttpPost]
        public IHttpActionResult UpdateFeeCategory(FeeCategory feeCategory)
        {
            return Ok(new { results = feeCategoryService.UpdateFeeCategory(feeCategory) });
        }
    }
}
