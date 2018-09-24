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
        public static int InsertBatchProgramAssociationDS(BatchProgramAssociation batchProgramAssociation)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            batchProgramAssociation.SetAction = "INSERT";
            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", batchProgramAssociation.SetAction.ToUpper()),
                            new SqlParameter("@BatchProgramAssociationId", batchProgramAssociation.BatchProgramAssociationId),
                            new SqlParameter("@BatchId", batchProgramAssociation.BatchId),
                            new SqlParameter("@ProgramId ", batchProgramAssociation.ProgramId)
            };
            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateBatchProgramAssociation", sqlParameter);
            int strRes = (int)obj;
            objHelper.Dispose();
            return strRes;
        }

        public static int UpdateBatchProgramAssociationDS(BatchProgramAssociation batchProgramAssociation)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            batchProgramAssociation.SetAction = "UPDATE";
            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", batchProgramAssociation.SetAction.ToUpper()),
                            new SqlParameter("@BatchProgramAssociationId", batchProgramAssociation.BatchProgramAssociationId),
                            new SqlParameter("@BatchId", batchProgramAssociation.BatchId),
                            new SqlParameter("@ProgramId ", batchProgramAssociation.ProgramId)
            };
            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateBatchProgramAssociation", sqlParameter);
            int strRes = (int)obj;
            objHelper.Dispose();
            return strRes;
        }

        public static int DeleteBatchProgramAssociationDS(BatchProgramAssociation batchProgramAssociation)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            batchProgramAssociation.SetAction = "DELETE";
            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", batchProgramAssociation.SetAction.ToUpper()),
                            new SqlParameter("@BatchProgramAssociationId", batchProgramAssociation.BatchProgramAssociationId),
                            new SqlParameter("@BatchId", batchProgramAssociation.BatchId),
                            new SqlParameter("@ProgramId ", batchProgramAssociation.ProgramId)
            };
            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateBatchProgramAssociation", sqlParameter);
            int strRes = (int)obj;
            objHelper.Dispose();
            return strRes;
        }

        public static List <BatchProgramAssociation> SelectIdByBatchProgramAssociationDS(BatchProgramAssociation batchProgramAssociation)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            batchProgramAssociation.SetAction = "SELECTBYID";
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("GKL_USP_GetBatchProgramAssociation");

            List<BatchProgramAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new BatchProgramAssociation
            {
                BatchProgramAssociationId = row.Field<int>("BatchProgramAssociationId"),
                BatchId = Common.ConvertFromDBVal<string>(row["BatchId"]),
                ProgramId = Common.ConvertFromDBVal<string>(row["ProgramId"]),
                SetAction = row.Field<string>("SetAction")
            }).ToList();
            return objlm;
        }

        public static List<BatchProgramAssociation> SelectAllProgramAssociationDS(BatchProgramAssociation batchProgramAssociation)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            batchProgramAssociation.SetAction = "SELECTALL";
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("GKL_USP_GetBatchProgramAssociation");
            List<BatchProgramAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new BatchProgramAssociation
            {
                BatchProgramAssociationId = row.Field<int>("BatchProgramAssociationId"),
                BatchId = Common.ConvertFromDBVal<string>(row["BatchId"]),
                ProgramId = Common.ConvertFromDBVal<string>(row["ProgramId"]),
                SetAction = row.Field<string>("SetAction")
            }).ToList();
            return objlm;
        }
    }
}
