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
    public class BranchDS
    {
        public static List<Branch> GetAllBranch()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("Gkl_USP_GetActiveBranch");

            List<Branch> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Branch
            {
                BranchId = row.Field<int>("BranchId"),
                BranchCode = Common.ConvertFromDBVal<string>(row["BranchCode"]),
                BranchName = Common.ConvertFromDBVal<string>(row["BranchName"]),
                Active = row.Field<bool>("Active"),
                ProgramId = row.Field<int>("ProgramId"),


            }).ToList();

            return objlm;
        }
        public static List<Branch> GetBranchByProgram(int ProgramId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@ProgramId", ProgramId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetBranchByProgram", sqlParameter);

            List<Branch> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Branch
            {
                BranchId = row.Field<int>("BranchId"),
                BranchCode = Common.ConvertFromDBVal<string>(row["BranchCode"]),
                BranchName = Common.ConvertFromDBVal<string>(row["BranchName"]),
                Active = row.Field<bool>("Active"),
                ProgramId = row.Field<int>("ProgramId"),

            }).ToList();

            return objlm;
        }
        public static string UpdateBranch(Branch branch)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", branch.SetAction.ToUpper()),
                            new SqlParameter("@BranchId", branch.BranchId),
                            new SqlParameter("@BranchCode", branch.BranchCode),
                            new SqlParameter("@BranchName ", branch.BranchName),
                            new SqlParameter("@ProgramId ", branch.ProgramId)

            };

            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateBranch", sqlParameter);
            string status;
            status = "updated";
            objHelper.Dispose();
            return status;
        }

    }
}
