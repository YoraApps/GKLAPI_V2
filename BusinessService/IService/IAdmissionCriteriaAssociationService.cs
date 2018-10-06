using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface IAdmissionCriteriaAssociationService
    {
        List<AdmissionCriteriaAssociation> GetAdmissionCriteriaAssociation (int ProgramId,int BatchId);
        List<AdmissionCriteriaAssociation> UpdateAdmissionCriteriaAssociation (AdmissionCriteriaAssociation admissionCriteriaAssociation);
    }
}
