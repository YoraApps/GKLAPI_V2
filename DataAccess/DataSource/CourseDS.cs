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
    public class CourseDS
    {
         public static List<Course> GetAllCourse()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("Gkl_Usp_GetCourse");

            List<Course> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Course
            {
                CourseId = row.Field<int>("CourseId"),
                CourseCode = Common.ConvertFromDBVal<string>(row["CourseCode"]),
                CourseName = Common.ConvertFromDBVal<string>(row["CourseName"]),
                Active = row.Field<bool>("Active"),
                CourseTypeId = row.Field<int>("CourseTypeId"),

            }).ToList();

            return objlm;
        }

        public static List<Course> GetAllCourseType()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("GKL_USP_GetCourseType");

            List<Course> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Course
            {
                CourseType = Common.ConvertFromDBVal<string>(row["CourseType"]),
                CourseTypeId = row.Field<int>("CourseTypeId")

            }).ToList();

            return objlm;
        }

        public static string UpdateCourse(Course course)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", course.SetAction.ToUpper()),
                            new SqlParameter("@CourseId", course.CourseId),
                            new SqlParameter("@CourseCode", course.CourseCode),
                            new SqlParameter("@CourseName ", course.CourseName),
                            new SqlParameter("@CourseTypeId", course.CourseTypeId),
                            new SqlParameter("@SemesterId", course.@SemesterId)


            };

            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateCourse", sqlParameter);
            string status;
            status = "updated";
            objHelper.Dispose();
            return status;
        }

        public static List<Course> GetActiveCourse()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("Gkl_USP_ActiveCourseList");

            List<Course> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Course
            {
                CourseId = row.Field<int>("CourseId"),
                CourseTypeId = row.Field<int>("CourseTypeId"),
                CourseType = Common.ConvertFromDBVal<string>(row["CourseType"])

            }).ToList();

            return objlm;
        }
        public static List<Course> GetCourseBySemester(int SemesterId )
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SemesterId", SemesterId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetCourseBySemester", sqlParameter);
            List<Course> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Course
            {
                CourseId = row.Field<int>("CourseId"),
                CourseCode = Common.ConvertFromDBVal<string>(row["CourseCode"]),
                CourseName = Common.ConvertFromDBVal<string>(row["CourseName"]),
                CourseType = Common.ConvertFromDBVal<string>(row["CourseType"]),
                Active = row.Field<bool>("Active"),
                CourseTypeId = row.Field<int>("CourseTypeId"),
                SemesterId = row.Field<int>("SemesterId"),

            }).ToList();

            return objlm;
        }
    }
    
}
