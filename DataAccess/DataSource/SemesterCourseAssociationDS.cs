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
   public class SemesterCourseAssociationDS
    {
        public static List<SemesterCourseAssociation> GetCourseBySemester(int SemesterId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                new SqlParameter("@SemesterId",SemesterId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetCourseBySemester", sqlParameter);

            List<SemesterCourseAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new SemesterCourseAssociation
            {
                SemesterId = row.Field<int>("SemesterId"),
                CourseId = row.Field<int>("CourseId"),
                CourseCode = Common.ConvertFromDBVal<string>(row["CourseCode"]),
                CourseName = Common.ConvertFromDBVal<string>(row["CourseName"])

            }).ToList();

            return objlm;
        }

        public static List<SemesterCourseAssociation> UpdateSemesterCourseAssociation(SemesterCourseAssociation semesterCourseAssociation)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", semesterCourseAssociation.SetAction.ToUpper()),
                            new SqlParameter("@SemesterId", semesterCourseAssociation.SemesterId),
                            new SqlParameter("@CourseIds", semesterCourseAssociation.CourseIds)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_UpdateSemesterCourseAssociation", sqlParameter);
            List<SemesterCourseAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new SemesterCourseAssociation
            {
                SemesterId = row.Field<int>("SemesterId"),
                CourseId = row.Field<int>("CourseId"),
                CourseCode = Common.ConvertFromDBVal<string>(row["CourseCode"]),
                CourseName = Common.ConvertFromDBVal<string>(row["CourseName"])

            }).ToList();

            return objlm;
        }

        public static List<SemesterCourseAssociation> GetSemesterCourseNotMapped(int SemesterId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                new SqlParameter("@SemesterId",SemesterId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetSemesterCourseNotMapped", sqlParameter);

            List<SemesterCourseAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new SemesterCourseAssociation
            {
                CourseId = row.Field<int>("CourseId"),
                CourseCode = Common.ConvertFromDBVal<string>(row["CourseCode"]),
                CourseName = Common.ConvertFromDBVal<string>(row["CourseName"]),

            }).ToList();

            return objlm;
        }

    }
}
