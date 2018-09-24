﻿using DTO.Entity;
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
    public class BatchDS
    {
        public static List<Batch> GetAllBatch()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("GKL_USP_GetBatch");

            List<Batch> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Batch
            {
                BatchId = row.Field<int>("BatchId"),
                AcademicYearId = row.Field<int>("AcademicYearId")
                
            }).ToList();

            return objlm;
        }
        public static List<Batch> GetAllAcademicYear()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("GKL_USP_GetAcademicYear");

            List<Batch> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Batch
            {
                AcademicYear = Common.ConvertFromDBVal<string>(row["AcademicYear"]),
                AcademicYearId = row.Field<int>("AcademicYearId")
                
            }).ToList();

            return objlm;
        }
        public static string UpdateBatch(Batch batch)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", batch.SetAction.ToUpper()),
                            new SqlParameter("@BatchId", batch.BatchId),
                            new SqlParameter("@AcademicYearId", batch.AcademicYearId)

            };

            Object obj = objHelper.ExecScalarProc("GKL_USP_UpdateBatch", sqlParameter);
            string status;
            status = "updated";
            objHelper.Dispose();
            return status;
        }
    }
}
