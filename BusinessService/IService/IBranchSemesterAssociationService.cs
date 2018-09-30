using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface IBranchSemesterAssociationService
    {
        List<BranchSemesterAssociation> GetSemesterByBranch(int BranchId);
        List<BranchSemesterAssociation> UpdateBranchSemesterAssociation(BranchSemesterAssociation branchSemesterAssociation);
        List<BranchSemesterAssociation> GetBranchSemesterNotMapped(int BranchId);
    }
}
