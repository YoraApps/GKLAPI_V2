using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Entity
{
    public class Menu
    {
        public Menu()
        {

        }

        private string _SetAction;
        private int _MenuId;
        private string _MenuName;
        private string _MenuType;
        private string _MenuOrder;
        private string _MenuIcon;
        private string _Menu_Uri;
        private string _ParentId;
        private bool _Active;

        public string SetAction
        {
            get { return _SetAction; }
            set { _SetAction = value; }
        }

        public int MenuId
        {
            get { return _MenuId; }
            set { _MenuId = value; }
        }

        public string MenuName
        {
            get { return _MenuName; }
            set { _MenuName = value; }
        }

        public string MenuType
        {
            get { return _MenuType; }
            set { _MenuType = value; }
        }

        public string MenuOrder
        {
            get { return _MenuOrder; }
            set { _MenuOrder = value; }
        }

        public string MenuIcon
        {
            get { return _MenuIcon; }
            set { _MenuIcon = value; }
        }

        public string Menu_Uri
        {
            get { return _Menu_Uri; }
            set { _Menu_Uri = value; }
        }

        public string ParentId
        {
            get { return _ParentId; }
            set { _ParentId = value; }
        }

        public bool Active
        {
            get { return _Active; }
            set { _Active = value; }
        }
    }
}

