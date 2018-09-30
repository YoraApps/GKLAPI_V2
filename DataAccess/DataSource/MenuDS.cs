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
    public class MenuDS
    {
        public MenuDS()
        {
        }

        public static List<Menu> GetAllMenu()
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();
            ds = objHelper.ExecDataSetProc("GKL_USP_GETMenuMaster");
            List<Menu> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Menu
            {
                MenuId = row.Field<int>("MenuId"),
                MenuName = row.Field<string>("MenuName"),
                MenuType = row.Field<string>("MenuType"),
                MenuOrder = row.Field<string>("MenuOrder"),
                MenuIcon = row.Field<string>("MenuIcon"),
                Menu_Uri = row.Field<string>("Menu_Uri"),
                ParentId = row.Field<string>("ParentId"),
                Active = row.Field<bool>("Active")
            }).ToList();
            return objlm;
        }

        public static List<Menu> GetMenuById(int menuId)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            DataSet ds = new DataSet();

            SqlParameter[] sqlParameter = {
                            new SqlParameter("@MenuId", menuId)
            };
            ds = objHelper.ExecDataSetProc("GKL_USP_GETMenuMaster", sqlParameter);

            List<Menu> objlm = null;
            objlm = ds.Tables[0].AsEnumerable()
            .Select(row => new Menu
            {
                MenuId = row.Field<int>("MenuId"),
                MenuName = row.Field<string>("MenuName"),
                MenuType = row.Field<string>("MenuType"),
                MenuOrder = row.Field<string>("MenuOrder"),
                MenuIcon = row.Field<string>("MenuIcon"),
                Menu_Uri = row.Field<string>("Menu_Uri"),
                ParentId = row.Field<string>("ParentId"),
                Active = row.Field<bool>("Active")
            }).ToList();

            return objlm;
        }

        public static string InsUpdDelMenu(Menu menu)
        {
            AdoHelper objHelper = new AdoHelper(ConfigurationManager.ConnectionStrings["con"].ToString());
            SqlParameter[] sqlParameter = {
                            new SqlParameter("@SetAction", menu.SetAction.ToUpper()),
                            new SqlParameter("@MenuId", menu.MenuId),
                            new SqlParameter("@MenuName", menu.MenuName),
                            new SqlParameter("@MenuType", menu.MenuType),
                            new SqlParameter("@MenuOrder", menu.MenuOrder),
                            new SqlParameter("@MenuIcon", menu.MenuIcon),
                            new SqlParameter("@Menu_Uri", menu.Menu_Uri),
                            new SqlParameter("@ParentId", menu.ParentId),
                               new SqlParameter("@Active", menu.Active)
            };
            Object obj = objHelper.ExecScalarProc("GKL_USP_UpateMenuMaster", sqlParameter);
            string status;
            status = "updated";
            objHelper.Dispose();
            return status;
        }
    }

}

