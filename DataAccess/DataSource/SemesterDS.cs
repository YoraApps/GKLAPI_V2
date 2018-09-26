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
    public static class SemesterDS
    {
        public static List<Semester> GetAllSemester()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("Gkl_USP_GetSemester");

            List<Semester> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Semester
            {
                SemesterId = row.Field<int>("SemesterId"),
                SemesterCode = Common.ConvertFromDBVal<string>(row["SemesterCode"]),
                SemesterName = Common.ConvertFromDBVal<string>(row["SemesterName"]),
                Active = row.Field<bool>("Active")


            }).ToList();

            return objlm;
        }

        public static string UpdateSemester(Semester semester)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", semester.SetAction.ToUpper()),
                            new SqlParameter("@SemesterId", semester.SemesterId),
                            new SqlParameter("@SemesterCode", semester.SemesterCode),
                            new SqlParameter("@SemesterName ", semester.SemesterName)

            };

            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateSemester", sqlParameter);
            string status = "updated";
            objHelper.Dispose();
            return status;
        }

    }
}