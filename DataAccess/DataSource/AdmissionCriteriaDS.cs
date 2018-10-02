using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataSource
{
    public static class AdmissionCriteriaDS
    {
        public static List<AdmissionCriteria> GetAllAdmissionCriteria()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("Gkl_USP_GetAdmissionCriteria");

            List<AdmissionCriteria> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new AdmissionCriteria
            {
                CriteriaId = row.Field<int>("CriteriaId"),
                CriteriaDescription = Common.ConvertFromDBVal<string>(row["CriteriaDescription"]),
                Active = row.Field<bool>("Active")


            }).ToList();

            return objlm;
        }
        public static string UpdateAdmissionCriteria(AdmissionCriteria admissionCriteria)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", admissionCriteria.SetAction.ToUpper()),
                            new SqlParameter("@CriteriaId", admissionCriteria.CriteriaId),
                            new SqlParameter("@CriteriaDescription", admissionCriteria .CriteriaDescription)

            };

            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateAdmissionCriteria", sqlParameter);
            string status = "updated";
            objHelper.Dispose();
            return status;
        }
    }
}
