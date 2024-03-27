using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Welcome.Others;
using Welcome.Model;

namespace DataLayer.Model
{
    public class DatabaseUser : User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }

        public DatabaseUser() : base()
        {
        }

        public DatabaseUser(string name, string password, UserRolesEnum role) : base(name, password, role)
        {
        }
    }
}
