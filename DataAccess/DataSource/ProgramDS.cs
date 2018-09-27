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
    public static class ProgramDS
    {
        public static List<Program> GetAllProgram()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("Gkl_USP_GetProgram");

            List<Program> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Program
            {
                ProgramId = row.Field<int>("ProgramId"),
                ProgramCode = Common.ConvertFromDBVal<string>(row["ProgramCode"]),
                ProgramName = Common.ConvertFromDBVal<string>(row["ProgramName"]),
                Active = row.Field<bool>("Active"),
                DegreeTypeId = row.Field<int>("DegreeTypeId"),
                DegreeTypeCode = Common.ConvertFromDBVal<string>(row["DegreeTypeCode"]),
                DegreeTypeName = Common.ConvertFromDBVal<string>(row["DegreeTypeName"]),

            }).ToList();

            return objlm;
        }
        public static List<Program> GetProgramByDegree(int DegreeTypeId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@DegreeTypeId", DegreeTypeId)
            };

            ds = objHelper.ExecDataSetProc("Gkl_USP_GetProgramByDegree", sqlParameter);

            List<Program> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Program
            {
                ProgramId = row.Field<int>("ProgramId"),
                ProgramCode = Common.ConvertFromDBVal<string>(row["ProgramCode"]),
                ProgramName = Common.ConvertFromDBVal<string>(row["ProgramName"]),
                Active = row.Field<bool>("Active"),
                DegreeTypeId = row.Field<int>("DegreeTypeId"),
                DegreeTypeCode = Common.ConvertFromDBVal<string>(row["DegreeTypeCode"]),
                DegreeTypeName = Common.ConvertFromDBVal<string>(row["DegreeTypeName"]),

            }).ToList();

            return objlm;
        }

        public static string UpdateProgram(Program program)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", program.SetAction.ToUpper()),
                            new SqlParameter("@ProgramId", program.ProgramId),
                            new SqlParameter("@ProgramCode", program.ProgramCode),
                            new SqlParameter("@ProgramName", program.ProgramName),
                            new SqlParameter("@DegreeTypeId", program.DegreeTypeId),
            };

            Object obj = objHelper.ExecScalarProc("Gkl_USP_UpdateProgram", sqlParameter);
            string strRes = (String)obj;
            objHelper.Dispose();
            return strRes;
        }

    }
}
