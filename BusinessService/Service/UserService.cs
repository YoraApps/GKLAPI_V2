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
    public class UserService :IUserService
    {
        public List<User> GetAllUser()
        {
            return UserDS.GetAllUsers();
        }

        public List<User> GetUserById(int userid)
        {
            return UserDS.GetUserById(userid);
        }

        public string InUpDeUser(User user)
        {
            return UserDS.InsUpdDelUser(user);
        }
    }

}

