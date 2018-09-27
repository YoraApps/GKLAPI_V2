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
    public class ProgramBranchAssociationDS
    {
        public static List<ProgramBranchAssociation> GetProgramByBranch(int BranchId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            SqlParameter[] sqlParameter = {
                            new SqlParameter("@BranchId",BranchId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetProgramByBranch", sqlParameter);

            List<ProgramBranchAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new ProgramBranchAssociation
            {
                ProgramId = row.Field<int>("ProgramId"),
                BranchId = row.Field<int>("BranchId"),
                BranchCode = Common.ConvertFromDBVal<string>(row["BranchCode"]),
                BranchName = Common.ConvertFromDBVal<string>(row["BranchName"]),
                Active = row.Field<bool>("Active")

            }).ToList();

            return objlm;
        }

        public static string UpdateProgramBranchAssociation(ProgramBranchAssociation programBranchAssociation)
        {
            var Programs = programBranchAssociation.ProgramIds.TrimEnd(',');

            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", programBranchAssociation.SetAction.ToUpper()),
                            new SqlParameter("@ProgramIds", Programs),
                            new SqlParameter("@BranchId", programBranchAssociation.BranchId)
            };

            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateProgramBranchAssociation", sqlParameter);
            string status = "updated";
            objHelper.Dispose();
            return status;
        }

        public static List<ProgramBranchAssociation> GetProgramBranchNotMapped(int BranchId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@BranchId",BranchId)
            };
            
            ds = objHelper.ExecDataSetProc("Gkl_USP_GetProgramBranchNotMapped");

            List<ProgramBranchAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new ProgramBranchAssociation
            {
                BranchId = row.Field<int>("BranchId"),
                BranchCode = Common.ConvertFromDBVal<string>(row["BranchCode"]),
                BranchName = Common.ConvertFromDBVal<string>(row["BranchName"]),

            }).ToList();

            return objlm;
        }
    }
}
