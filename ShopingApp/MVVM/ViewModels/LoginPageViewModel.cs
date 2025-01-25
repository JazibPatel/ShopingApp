using ShopingApp.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShopingApp.MVVM.ViewModels
{
    class LoginPageViewModel
    {
        public ICommand RegisterBtn { get; }
        public ICommand OnImageTap { get; }


        public LoginPageViewModel()
        {
            RegisterBtn = new Command(RegisterPage);
            OnImageTap = new Command(HomePage);
        }
        private async void RegisterPage()
        {
            //await Shell.Current.GoToAsync("RegistrationPage");
            await Application.Current.MainPage.Navigation.PushAsync(new RegistrationPage());
        }

        private void HomePage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new HomePage());

        }
    }
    
}
