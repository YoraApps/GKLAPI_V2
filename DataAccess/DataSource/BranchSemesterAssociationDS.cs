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
    public class BranchSemesterAssociationDS
    {
        public static List<BranchSemesterAssociation> GetSemesterByBranch(int BranchId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            SqlParameter[] sqlParameter = {
                new SqlParameter("@BranchId",BranchId)
            };
            ds = objHelper.ExecDataSetProc("Gkl_USP_GetSemesterByBranch", sqlParameter);

            List<BranchSemesterAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new BranchSemesterAssociation
            {
                BranchId = row.Field<int>("BranchId"),
                SemesterId = row.Field<int>("SemesterId"),
                SemesterCode = Common.ConvertFromDBVal<string>(row["SemesterCode"]),
                SemesterName = Common.ConvertFromDBVal<string>(row["SemesterName"])

            }).ToList();

            return objlm;
        }
        public static string UpdateBranchSemesterAssociation(BranchSemesterAssociation branchSemesterAssociation)
        {
            var Programs = branchSemesterAssociation.ProgramIds.TrimEnd(',');

            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", branchSemesterAssociation.SetAction.ToUpper()),
                            new SqlParameter("@ProgramIds", Programs),
                            new SqlParameter("@BranchId", branchSemesterAssociation.BranchId),
                            new SqlParameter("@SemesterId", branchSemesterAssociation.SemesterId)
            };

            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateBranchSemesterAssociation", sqlParameter);
            string status = "updated";
            objHelper.Dispose();
            return status;
        }
        public static List<BranchSemesterAssociation> GetBranchSemesterNotMapped(int BranchId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            SqlParameter[] sqlParameter = {
                new SqlParameter("@BranchId",BranchId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetBranchSemesterNotMapped",sqlParameter);

            List<BranchSemesterAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new BranchSemesterAssociation
            {
                SemesterId = row.Field<int>("SemesterId"),
                SemesterCode = Common.ConvertFromDBVal<string>(row["SemesterCode"]),
                SemesterName = Common.ConvertFromDBVal<string>(row["SemesterName"]),

            }).ToList();

            return objlm;
        }
    }
}
