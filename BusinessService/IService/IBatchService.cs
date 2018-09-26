using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface IBatchService
    {
        List<Batch> GetBatch();
        List<Batch> GetAcademicYear();
        string InUpBatch(Batch batch);
        List<Batch> GetActiveBatch();
    }
}
