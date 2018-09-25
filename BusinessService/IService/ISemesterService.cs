using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface ISemesterService
    {
        List<Semester> GetSemester();
        string UpdateSemester(Semester semester);
    }
}
