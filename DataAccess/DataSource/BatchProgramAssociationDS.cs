using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Entity;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess.DataSource
{
    public class BatchProgramAssociationDS
    {
       public static List<BatchProgramAssociation> GetProgramByBatch(int BatchId)
       {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            SqlParameter[] sqlParameter = {
                            new SqlParameter("@BatchId",BatchId)
            };
            ds = objHelper.ExecDataSetProc("Gkl_USP_GetProgramByBatch", sqlParameter);

            List<BatchProgramAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new BatchProgramAssociation
            {
                BatchId = row.Field<int>("BatchId"),
                ProgramId = row.Field<int>("ProgramId"),
                ProgramCode = Common.ConvertFromDBVal<string>(row["ProgramCode"]),
                ProgramName = Common.ConvertFromDBVal<string>(row["ProgramName"])

            }).ToList();

            return objlm;
        }
        public static List<BatchProgramAssociation> UpdateProgramBatchAssociation(BatchProgramAssociation batchProgramAssociation)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", batchProgramAssociation.SetAction.ToUpper()),
                            new SqlParameter("@ProgramIds", batchProgramAssociation.ProgramIds),
                            new SqlParameter("@BatchId", batchProgramAssociation.BatchId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_UpdateBatchProgramAssociation", sqlParameter);

            List<BatchProgramAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new BatchProgramAssociation
            {
                BatchId = row.Field<int>("BatchId"),
                ProgramId = row.Field<int>("ProgramId"),
                ProgramCode = Common.ConvertFromDBVal<string>(row["ProgramCode"]),
                ProgramName = Common.ConvertFromDBVal<string>(row["ProgramName"])

            }).ToList();

            return objlm;
        }
        public static List<BatchProgramAssociation> GetProgramBatchNotMapped(int BatchId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@BatchId",BatchId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetProgramBatchNotMapped", sqlParameter);

            List<BatchProgramAssociation> objlm = null;

            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new BatchProgramAssociation
            {
                ProgramId = row.Field<int>("ProgramId"),
                ProgramCode = Common.ConvertFromDBVal<string>(row["ProgramCode"]),
                ProgramName = Common.ConvertFromDBVal<string>(row["ProgramName"]),

            }).ToList();

            return objlm;
        }
    }
}
