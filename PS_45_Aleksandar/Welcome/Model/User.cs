using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace Welcome.Model
{
    internal class User
    {
        private string name;
        public string Names
        {
            get { return name; }
            set { name = value; }
        }

        private string password;
        public string Password 
        { get => password; set => password = value; }

        private UserRolesEnum role;
        public UserRolesEnum Role { get => role; set => role = value; }






    }
}
