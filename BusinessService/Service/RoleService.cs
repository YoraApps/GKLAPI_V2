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
    public class RoleService : IRoleService
    {
        public List<Role> GetAllRole()
        {
            return RoleDS.GetAllRole();
        }

        public List<Role> GetRoleById(int roleid)
        {
            return RoleDS.GetRoleById(roleid);
        }

        public string InUpDeRole(Role role)
        {
            return RoleDS.InsUpdDelRole(role);
        }
    }

}
