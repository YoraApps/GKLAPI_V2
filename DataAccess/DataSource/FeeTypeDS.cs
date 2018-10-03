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
    public static class FeeTypeDS
    {
        public static List<FeeType> GetAllFeeType()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("GKL_USP_GetFeeType");

            List<FeeType> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new FeeType
            {
                FeeTypeId = row.Field<int>("FeeTypeId"),
                FeeTypeName = Common.ConvertFromDBVal<string>(row["FeeTypeName"]),
                FeeTypeDescription = Common.ConvertFromDBVal<string>(row["FeeTypeDescription"]),
                Active = row.Field<bool>("Active")


            }).ToList();

            return objlm;
        }

        public static string UpdateFeeType(FeeType feeType)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", feeType.SetAction.ToUpper()),
                            new SqlParameter("@FeeTypeId", feeType.FeeTypeId),
                            new SqlParameter("@FeeTypeName", feeType.FeeTypeName),
                            new SqlParameter("@FeeTypeDescription ", feeType.FeeTypeDescription)

            };

            Object obj = objHelper.ExecScalarProc("GKL_USP_UpdateFeeType", sqlParameter);
            string status = "updated";
            objHelper.Dispose();
            return status;
        }
    }
}
