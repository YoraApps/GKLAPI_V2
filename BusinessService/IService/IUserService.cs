using DTO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.IService
{
    public interface IUserService
    {
        List<User> GetAllUser();
        List<User> GetUserById(int userid);
        string InUpDeUser(User user);
    }
}


