using ECommerce.Commands;
using ECommerce.DataAccess.SqlServer;
using ECommerce.Domain.Services;
using ECommerce.Domain.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ECommerce.Domain.ViewModels
{
    public class AdminSignInViewModel:BaseViewModel
    {
        private readonly AdminService _adminService;
        private string username;

		public string Username
		{
			get { return username; }
			set { username = value;OnPropertyChanged(); }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value;OnPropertyChanged(); }
		}

		public RelayCommand LoginCommand { get; set; }
		public RelayCommand BackCommand { get; set; }
		public AdminSignInViewModel()
		{
            _adminService= new AdminService();
            LoginCommand = new RelayCommand(o =>
            {
                Admin admin = _adminService.GetAdminByUsername(username);
                if (admin != null)
                {
                    if (admin.Password == Password)
                    {
                        App.DeleteLastView();
                        var view = new AdminMenuUC();
                        view.DataContext = new AdminMenuViewModel();
                        App.MainGrid.Children.Add(view);
                    }
                    else
                    {
                        MessageBox.Show("Password Or Username Incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Password Or Username Incorrect");
                }

            });
            BackCommand = new RelayCommand(o =>
			{
				App.MainGrid.Children.RemoveAt(App.MainGrid.Children.Count-1);
			});
		}
	}
}
