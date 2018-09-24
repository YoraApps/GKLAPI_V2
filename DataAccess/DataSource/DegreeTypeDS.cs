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
    public class DegreeTypeDS
    {
        public static List<DegreeType> GetAllDegreeType()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("Gkl_USP_GetDegreeType");

            List<DegreeType> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new DegreeType
            {
                DegreeTypeId = row.Field<int>("DegreeTypeId"),
                DegreeTypeCode = Common.ConvertFromDBVal<string>(row["DegreeTypeCode"]),
                DegreeTypeName = Common.ConvertFromDBVal<string>(row["DegreeTypeName"]),
                Active = row.Field<bool>("Active"),
                DegreeCategoryId = row.Field<int>("DegreeCategoryId")


            }).ToList();

            return objlm;
        }
        public static string UpdateDegreeType(DegreeType degreetype)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", degreetype.SetAction.ToUpper()),
                            new SqlParameter("@DegreeTypeId", degreetype.DegreeTypeId),
                            new SqlParameter("@DegreeTypeCode", degreetype.DegreeTypeCode),
                            new SqlParameter("@DegreeTypeName ", degreetype.DegreeTypeName),
                            new SqlParameter("@DegreeCategoryId", degreetype.DegreeCategoryId)

            };

            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateDegreeType", sqlParameter);
            string status;
            status = "updated";
            objHelper.Dispose();
            return status;
        }
    }
}
