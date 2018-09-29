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
    public class ChapterDS
    {
        public static List<Chapter> GetAllChapter()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("Gkl_USP_GetChapter");

            List<Chapter> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Chapter
            {
                ChapterId = row.Field<int>("ChapterId"),
                ChapterCode = Common.ConvertFromDBVal<string>(row["ChapterCode"]),
                ChapterName = Common.ConvertFromDBVal<string>(row["ChapterName"]),
                Active = row.Field<bool>("Active")


            }).ToList();

            return objlm;
        }
        public static string UpdateChapter(Chapter chapter)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", chapter.SetAction.ToUpper()),
                            new SqlParameter("@ChapterId", chapter.ChapterId),
                            new SqlParameter("@ChapterCode", chapter.ChapterCode),
                            new SqlParameter("@ChapterName ", chapter.ChapterName)

            };

            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateChapter", sqlParameter);
            string status = "updated";
            objHelper.Dispose();
            return status;
        }
    }
}
