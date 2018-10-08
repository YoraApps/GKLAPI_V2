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
    public class SemesterService : ISemesterService
    {
        public List<Semester> GetSemester()
        {
            return SemesterDS.GetAllSemester();
        }

        public List<Semester> GetSemesterByBranch(int BranchId)
        {
            return SemesterDS.GetSemesterByBranch(BranchId);
        }

        public string UpdateSemester(Semester semester)
        {
            return SemesterDS.UpdateSemester(semester);
        }
    }
}
