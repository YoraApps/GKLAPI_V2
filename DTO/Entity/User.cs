using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class User
    {
        public User()
        {

        }

        private string _SetAction;
        private int _UserId;
        private string _UserName;
        private string _EmailAddress;
        private string _PhoneNumber;
        private string _Gender;
        private string _password;
        private int _RoleId;
        private bool _active;


        public string SetAction
        {
            get { return _SetAction; }
            set { _SetAction = value; }
        }

        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string EmailAddress
        {
            get { return _EmailAddress; }
            set { _EmailAddress = value; }
        }

        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }

        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int RoleId
        {
            get { return _RoleId; }
            set { _RoleId = value; }
        }

        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }
    }
}
