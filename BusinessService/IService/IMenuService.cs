using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Entity;

namespace BusinessService.IService
{
    public interface IMenuService
    {
        List<Menu> GetAllMenu();
        List<Menu> GetMenuById(int menuid);
        string InUpDeMenu(Menu menu);
    }
}
