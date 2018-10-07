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
    public static class FeeCategoryDS
    {

        public static List<FeeCategory> GetActiveFeeCategory()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("GKL_USP_GetActiveFeeCategory");

            List<FeeCategory> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new FeeCategory
            {
                FeeCategoryId = row.Field<int>("FeeCategoryId"),
                FeeCategoryName = Common.ConvertFromDBVal<string>(row["FeeCategoryName"]),
                FeeCategoryDescription = Common.ConvertFromDBVal<string>(row["FeeCategoryDescription"]),


            }).ToList();

            return objlm;
        }

        public static List<FeeCategory> GetAllFeeCategory()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("GKL_USP_GetFeeCategory");

            List<FeeCategory> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new FeeCategory
            {
                FeeCategoryId = row.Field<int>("FeeCategoryId"),
                FeeCategoryName = Common.ConvertFromDBVal<string>(row["FeeCategoryName"]),
                FeeCategoryDescription = Common.ConvertFromDBVal<string>(row["FeeCategoryDescription"]),
                Active = row.Field<bool>("Active")


            }).ToList();

            return objlm;
        }

        public static FeeCategory UpdateFeeCategory(FeeCategory feeCategory)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", feeCategory.SetAction.ToUpper()),
                            new SqlParameter("@FeeCategoryId", feeCategory.FeeCategoryId),
                            new SqlParameter("@FeeCategoryName", feeCategory.FeeCategoryName),
                            new SqlParameter("@FeeCategoryDescription ", feeCategory.FeeCategoryDescription)

            };
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("GKL_USP_UpdateFeeCategory", sqlParameter);

            List<FeeCategory> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new FeeCategory
            {
                FeeCategoryId = row.Field<int>("FeeCategoryId"),
                FeeCategoryName = Common.ConvertFromDBVal<string>(row["FeeCategoryName"]),
                FeeCategoryDescription = Common.ConvertFromDBVal<string>(row["FeeCategoryDescription"]),
                Active = row.Field<bool>("Active")


            }).ToList();
            return objlm[0];
        }
    }
}
