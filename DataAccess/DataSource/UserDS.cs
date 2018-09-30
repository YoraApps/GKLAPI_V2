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
    public class UserDS
    {
        public UserDS()
        {
        }

        public static List<User> GetAllUsers()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("Gkl_USP_GETUserMaster");
            List<User> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new User
            {
                UserId = row.Field<int>("UserId"),
                UserName = row.Field<string>("UserName"),
                EmailAddress = row.Field<string>("EmailAddress"),
                PhoneNumber = row.Field<string>("PhoneNumber"),
                Gender = row.Field<string>("Gender"),
                password = row.Field<string>("password"),
                RoleId = row.Field<int>("RoleId"),
                Active = row.Field<bool>("active")
            }).ToList();
            return objlm;
        }

        public static List<User> GetUserById(int userId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@UserId", userId)
            };
            ds = objHelper.ExecDataSetProc("Gkl_USP_GETUserMaster", sqlParameter);

            List<User> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new User
            {
                UserId = row.Field<int>("UserId"),
                UserName = row.Field<string>("UserName"),
                EmailAddress = row.Field<string>("EmailAddress"),
                PhoneNumber = row.Field<string>("PhoneNumber"),
                Gender = row.Field<string>("Gender"),
                password = row.Field<string>("password"),
                RoleId = row.Field<int>("RoleId"),
                Active = row.Field<bool>("active")
            }).ToList();

            return objlm;
        }

        public static string InsUpdDelUser(User user)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", user.SetAction.ToUpper()),
                            new SqlParameter("@UserId", user.UserId),
                            new SqlParameter("@UserName", user.UserName),
                             new SqlParameter("@EmailAddress", user.EmailAddress),
                              new SqlParameter("@PhoneNumber", user.PhoneNumber),
                            new SqlParameter("@Gender", user.Gender),
                             new SqlParameter("@password", user.password),
                              new SqlParameter("@RoleId", user.RoleId),
                               new SqlParameter("@Active", user.Active)
            };
            Object obj = objHelper.ExecScalarProc("GKL_USP_UpdateUserMaster", sqlParameter);
            string status;
            status = "updated";
            objHelper.Dispose();
            return status;
        }
    }
}
