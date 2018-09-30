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
        public static List<ProgramBranchAssociation> GetProgramByBranch(int ProgramId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                new SqlParameter("@ProgramId",ProgramId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetProgramByBranch", sqlParameter);

            List<ProgramBranchAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new ProgramBranchAssociation
            {
                ProgramId = row.Field<int>("ProgramId"),
                BranchId = row.Field<int>("BranchId"),
                BranchCode = Common.ConvertFromDBVal<string>(row["BranchCode"]),
                BranchName = Common.ConvertFromDBVal<string>(row["BranchName"])

            }).ToList();

            return objlm;
        }

        public static List<ProgramBranchAssociation> UpdateProgramBranchAssociation(ProgramBranchAssociation programBranchAssociation)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", programBranchAssociation.SetAction.ToUpper()),
                            new SqlParameter("@BranchIds", programBranchAssociation.BranchIds),
                            new SqlParameter("@ProgramId", programBranchAssociation.ProgramId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_UpdateProgramBranchAssociation", sqlParameter);

            List<ProgramBranchAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new ProgramBranchAssociation
            {
                ProgramId = row.Field<int>("ProgramId"),
                BranchId = row.Field<int>("BranchId"),
                BranchCode = Common.ConvertFromDBVal<string>(row["BranchCode"]),
                BranchName = Common.ConvertFromDBVal<string>(row["BranchName"])

            }).ToList();

            return objlm;
        }

        public static List<ProgramBranchAssociation> GetProgramBranchNotMapped(int ProgramId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@ProgramId",ProgramId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetProgramBranchNotMapped", sqlParameter);

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
