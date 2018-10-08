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
    public class BranchService : IBranchService
    {
        public List<Branch> GetBranch()
        {
            return BranchDS.GetAllBranch();
        }

        public List<Branch> GetBranchByProgram(int ProgramId)
        {
            return BranchDS.GetBranchByProgram(ProgramId);
        }

        public string InUpBranch(Branch branch)
        {
            return BranchDS.UpdateBranch(branch);
        }
    }
}
