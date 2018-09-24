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
   public static class DegreeCategoryDS
    {
        public static List<DegreeCategory> GetAllDegreeCategory()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("Gkl_USP_GetDegreeCategory");

            List<DegreeCategory> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new DegreeCategory
            {
                DegreeCategoryId = row.Field<int>("DegreeCategoryId"),
                DegreeCategoryCode = Common.ConvertFromDBVal<string>(row["DegreeCategoryCode"]),
                DegreeCategoryName = Common.ConvertFromDBVal<string>(row["DegreeCategoryName"]),
                Active = row.Field<bool>("Active")


            }).ToList();

            return objlm;
        }

        public static string UpdateDegreeCategory(DegreeCategory degreeCategory)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@GetAction", degreeCategory.GetAction.ToUpper()),
                            new SqlParameter("@DegreeCategoryId", degreeCategory.DegreeCategoryId),
                            new SqlParameter("@DegreeCategoryCode", degreeCategory.DegreeCategoryCode),
                            new SqlParameter("@DegreeCategoryName ", degreeCategory.DegreeCategoryName)
                         
            };

            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateDegreeCategory", sqlParameter);
            string status = "updated";
            objHelper.Dispose();
            return status;
        }

    }
}
