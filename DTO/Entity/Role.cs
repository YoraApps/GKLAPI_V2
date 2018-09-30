using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class Role
    {
        public Role()
        {

        }
        private string _SetAction;
        private int _RoleId;
        private string _RoleName;
        private bool _Active;

        public string SetAction
        {
            get { return _SetAction; }
            set { _SetAction = value; }
        }

        public int RoleId
        {
            get { return _RoleId; }
            set { _RoleId = value; }
        }

        public string RoleName
        {
            get { return _RoleName; }
            set { _RoleName = value; }
        }

        public bool Active
        {
            get { return _Active; }
            set { _Active = value; }
        }
    }
}
