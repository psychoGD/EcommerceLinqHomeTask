using ECommerce.Commands;
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
		
		public AdminSignInViewModel()
		{
			LoginCommand = new RelayCommand(o =>
			{
				MessageBox.Show("Login command yazilmayib");
				///Admin Menu Yazilacaq bu hisseye
			}); 
		}
	}
}
