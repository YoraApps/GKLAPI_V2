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
    public class AdmissionCriteriaAssociationService : IAdmissionCriteriaAssociationService
    {
        public List<AdmissionCriteriaAssociation> GetAdmissionCriteriaAssociation(int ProgramId, int BatchId)
        {
            return AdmissionCriteriaAssociationDS.GetAdmissionCriteriaAssociation(ProgramId,BatchId);
        }

        public List<AdmissionCriteriaAssociation> UpdateAdmissionCriteriaAssociation(AdmissionCriteriaAssociation admissionCriteriaAssociation)
        {
            return AdmissionCriteriaAssociationDS.UpdateAdmissionCriteriaAssociation(admissionCriteriaAssociation);
        }
    }
}
