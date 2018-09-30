using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface IRoleService
    {
        List<Role> GetAllRole();
        List<Role> GetRoleById(int roleid);
        string InUpDeRole(Role role);
    }
}

