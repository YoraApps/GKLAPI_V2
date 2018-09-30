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
        public static List<BranchSemesterAssociation> UpdateBranchSemesterAssociation(BranchSemesterAssociation branchSemesterAssociation)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", branchSemesterAssociation.SetAction.ToUpper()),
                            new SqlParameter("@SemesterIds", branchSemesterAssociation.SemesterIds),
                            new SqlParameter("@BranchId", branchSemesterAssociation.BranchId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_UpdateBranchSemesterAssociation", sqlParameter);

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
        public static List<BranchSemesterAssociation> GetBranchSemesterNotMapped(int BranchId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@BranchId",BranchId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetBranchSemesterNotMapped", sqlParameter);

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
