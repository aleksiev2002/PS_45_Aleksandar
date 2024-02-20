using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User
            {
                Names = "Gosho",
                Password = "0000",
                Role = Others.UserRolesEnum.ADMIN

            };

            UserViewModel userViewModel = new UserViewModel(user);

            UserView userView = new UserView(userViewModel);

            userView.Display();

      
            

        }
    }
}