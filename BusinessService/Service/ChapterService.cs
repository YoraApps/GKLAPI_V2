using BusinessService.IService;
using DataAccess.DataSource;
using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Service
{
    public class ChapterService : IChapterService
    {
        public List<Chapter> GetChapter()
        {
            return ChapterDS.GetAllChapter();
        }

        public string UpdateChapter(Chapter chapter)
        {
            return ChapterDS.UpdateChapter(chapter);
        }
    }
}
