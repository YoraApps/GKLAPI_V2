using BusinessService.IService;
using DataAccess.DataSource;
using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Service
{
    public class MenuService : IMenuService
    {
        public List<Menu> GetAllMenu()
        {
            return MenuDS.GetAllMenu();
        }

        public List<Menu> GetMenuById(int menuid)
        {
            return MenuDS.GetMenuById(menuid);
        }

        public string InUpDeMenu(Menu menu)
        {
            return MenuDS.InsUpdDelMenu(menu);
        }
    }

}

