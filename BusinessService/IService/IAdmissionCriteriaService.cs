using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface IAdmissionCriteriaService
    {
        List<AdmissionCriteria> GetAdmissionCriteria ();
        string UpdateAdmissionCriteria (AdmissionCriteria admissionCriteria);
    }
}
