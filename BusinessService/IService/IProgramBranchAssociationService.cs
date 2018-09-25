using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface IProgramBranchAssociationService
    {
        List<ProgramBranchAssociation> GetProgramByBranch(int BranchId);
        string UpdateProgramBranchAssociation(ProgramBranchAssociation programBranchAssociation);
        List<ProgramBranchAssociation> GetProgramBranchNotMapped(int BranchId);
    }
}
