using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {

        public UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display()
        {
            Console.WriteLine(_viewModel.Names);
            Console.WriteLine(_viewModel.Role);
        }

        public void DisplayError()
        {
            throw new Exception("Error");
        }
    }
}
