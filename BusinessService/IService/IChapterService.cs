﻿using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface IChapterService
    {
        List<Chapter> GetChapter();
        string UpdateChapter(Chapter chapter);
    }
}
