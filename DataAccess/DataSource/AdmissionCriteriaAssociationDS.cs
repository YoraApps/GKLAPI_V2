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
    public class AdmissionCriteriaAssociationDS
    {
        public static List<AdmissionCriteriaAssociation> GetAdmissionCriteriaAssociation (int ProgramId, int BatchId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                new SqlParameter("@ProgramId",ProgramId),
                new SqlParameter("@BatchId",BatchId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetAdmissionCriteriaAssociation", sqlParameter);

            List<AdmissionCriteriaAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new AdmissionCriteriaAssociation
            {
                BatchId = row.Field<int>("BatchId"),
                ProgramId = row.Field<int>("ProgramId"),
                CriteriaId = row.Field<int>("CriteriaId"),
                CriteriaDescription = Common.ConvertFromDBVal<string>(row["CriteriaDescription"])

            }).ToList();

            return objlm;
        }
        public static List<AdmissionCriteriaAssociation> UpdateAdmissionCriteriaAssociation (AdmissionCriteriaAssociation admissionCriteriaAssociation)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", admissionCriteriaAssociation.SetAction.ToUpper()),
                            new SqlParameter("@CriteriaIds", admissionCriteriaAssociation.CriteriaIds),
                            new SqlParameter("@ProgramId", admissionCriteriaAssociation.ProgramId),
                            new SqlParameter("@BatchId", admissionCriteriaAssociation.BatchId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_UpdateAdmissionCriteriaAssociation", sqlParameter);

            List<AdmissionCriteriaAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new AdmissionCriteriaAssociation
            {
                BatchId = row.Field<int>("BatchId"),
                ProgramId = row.Field<int>("ProgramId"),
                CriteriaId = row.Field<int>("CriteriaId"),
                CriteriaDescription = Common.ConvertFromDBVal<string>(row["CriteriaDescription"])

            }).ToList();

            return objlm;
        }
    }
}
