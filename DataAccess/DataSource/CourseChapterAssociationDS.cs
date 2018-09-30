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
    public class CourseChapterAssociationDS
    {
        public static List<CourseChapterAssociation> GetChapterByCourse(int CourseId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            SqlParameter[] sqlParameter = {
                            new SqlParameter("@CourseId",CourseId)
            };
            ds = objHelper.ExecDataSetProc("Gkl_USP_GetChapterByCourse", sqlParameter);

            List<CourseChapterAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new CourseChapterAssociation
            {
                CourseId = row.Field<int>("CourseId"),
                ChapterId = row.Field<int>("ChapterId"),
                ChapterCode = Common.ConvertFromDBVal<string>(row["ChapterCode"]),
                ChapterName = Common.ConvertFromDBVal<string>(row["ChapterName"])

            }).ToList();

            return objlm;
        }
        public static List<CourseChapterAssociation> UpdateCourseChapterAssociation(CourseChapterAssociation chapterCourseAssociation)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", chapterCourseAssociation.SetAction.ToUpper()),
                            new SqlParameter("@ChapterIds", chapterCourseAssociation.ChapterIds),
                            new SqlParameter("@CourseId", chapterCourseAssociation.CourseId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_UpdateCourseChapterAssociation", sqlParameter);

            List<CourseChapterAssociation> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new CourseChapterAssociation
            {
                CourseId = row.Field<int>("CourseId"),
                ChapterId = row.Field<int>("ChapterId"),
                ChapterCode = Common.ConvertFromDBVal<string>(row["ChapterCode"]),
                ChapterName = Common.ConvertFromDBVal<string>(row["ChapterName"])

            }).ToList();

            return objlm;
        }
        public static List<CourseChapterAssociation> GetCourseChapterNotMapped(int CourseId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@CourseId",CourseId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetCourseChapterNotMapped", sqlParameter);

            List<CourseChapterAssociation> objlm = null;

            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new CourseChapterAssociation
            {
                ChapterId = row.Field<int>("ChapterId"),
                ChapterCode = Common.ConvertFromDBVal<string>(row["ChapterCode"]),
                ChapterName = Common.ConvertFromDBVal<string>(row["ChapterName"]),

            }).ToList();

            return objlm;
        }
    }
}
