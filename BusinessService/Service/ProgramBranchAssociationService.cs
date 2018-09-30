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
    public class ProgramBranchAssociationService : IProgramBranchAssociationService
    {
        public List<ProgramBranchAssociation> GetProgramBranchNotMapped(int BranchId)
        {
            return ProgramBranchAssociationDS.GetProgramBranchNotMapped(BranchId);
        }

        public List<ProgramBranchAssociation> GetProgramByBranch(int BranchId)
        {
            return ProgramBranchAssociationDS.GetProgramByBranch(BranchId);
        }

        public List<ProgramBranchAssociation> UpdateProgramBranchAssociation(ProgramBranchAssociation programBranchAssociation)
        {
            return ProgramBranchAssociationDS.UpdateProgramBranchAssociation(programBranchAssociation);
        }
    }
}
