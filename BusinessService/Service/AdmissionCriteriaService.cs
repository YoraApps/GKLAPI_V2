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
    public class AdmissionCriteriaService : IAdmissionCriteriaService
    {
        public List<AdmissionCriteria> GetAdmissionCriteria()
        {
            return AdmissionCriteriaDS.GetAllAdmissionCriteria();
        }

        public string UpdateAdmissionCriteria(AdmissionCriteria admissionCriteria)
        {
            return AdmissionCriteriaDS.UpdateAdmissionCriteria(admissionCriteria);
        }
    }
}
