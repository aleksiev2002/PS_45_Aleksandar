using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private string _name;
        public string Names
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _password;
        public string Password 
        {
            get { return _password; }
            set { _password = value; }
        }

        private UserRolesEnum role;
        public UserRolesEnum Role { 
            get { return role; }
            set {  role = value; }
        }

        public virtual int Id { get; set; }

        public DateTime? Expires { get; set; }

        public User(string name, string password, UserRolesEnum role)
        {
            _name = name;
            _password = password;
            this.role = role;
        }

        public User()
        {
        }
    }
}
