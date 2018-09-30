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
    public class BranchSemesterAssociationService : IBranchSemesterAssociationService
    {
        public List<BranchSemesterAssociation> GetBranchSemesterNotMapped(int BranchId)
        {
            return BranchSemesterAssociationDS.GetBranchSemesterNotMapped(BranchId);
        }

        public List<BranchSemesterAssociation> GetSemesterByBranch(int BranchId)
        {
            return BranchSemesterAssociationDS.GetSemesterByBranch(BranchId);
        }

        public List<BranchSemesterAssociation> UpdateBranchSemesterAssociation(BranchSemesterAssociation branchSemesterAssociation)
        {
            return BranchSemesterAssociationDS.UpdateBranchSemesterAssociation(branchSemesterAssociation);
        }
    }
}
