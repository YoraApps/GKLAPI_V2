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
    public class RoleDS
    {
        public RoleDS()
        {
        }

        public static List<Role> GetAllRole()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("Gkl_USP_GETRoleMaster");
            List<Role> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Role
            {
                RoleId = row.Field<int>("RoleId"),
                RoleName = row.Field<string>("RoleName"),
                Active = row.Field<bool>("Active")
            }).ToList();
            return objlm;
        }

        public static List<Role> GetRoleById(int roleid)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@RoleId", roleid)
            };
            ds = objHelper.ExecDataSetProc("Gkl_USP_GETRoleMaster", sqlParameter);

            List<Role> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Role
            {
                RoleId = row.Field<int>("RoleId"),
                RoleName = row.Field<string>("RoleName"),
                Active = row.Field<bool>("Active")
            }).ToList();

            return objlm;
        }

        public static string InsUpdDelRole(Role role)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", role.SetAction.ToUpper()),
                            new SqlParameter("@RoleId", role.RoleId),
                            new SqlParameter("@RoleName", role.RoleName),
                               new SqlParameter("@Active", role.Active)
            };
            Object obj = objHelper.ExecScalarProc("GKL_USP_UpdateRoleMaster", sqlParameter);
            string status;
            status = "updated";
            objHelper.Dispose();
            return status;
        }
    }

}
