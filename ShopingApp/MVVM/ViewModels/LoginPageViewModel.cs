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
        public ICommand Register { get; }


        public LoginPageViewModel()
        {
               Register = new Command(OpenNewPage);
        }
        private async void OpenNewPage()
        {
            //await Shell.Current.GoToAsync("RegistrationPage");
            await Application.Current.MainPage.Navigation.PushAsync(new RegistrationPage());
        }
    }
    
}
