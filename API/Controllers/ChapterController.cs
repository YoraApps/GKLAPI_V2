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
    public class ChapterController : ApiController
    {
        private IChapterService chapterService = new ChapterService();
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(new { results = chapterService.GetChapter() });
        }

        [HttpPost]
        public IHttpActionResult UpdateChapter(Chapter chapter)
        {
            return Ok(new { results = chapterService.UpdateChapter(chapter) });
        }
    }
}
