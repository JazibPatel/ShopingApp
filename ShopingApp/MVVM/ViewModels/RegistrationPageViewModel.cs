using ShopingApp.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShopingApp.MVVM.ViewModels
{
    class RegistrationPageViewModel
    {
        public ICommand OnImageTap {get;}

        public RegistrationPageViewModel() {

            OnImageTap = new Command(OpenNewPage);

        }

        private void OpenNewPage()
        {
            //await App.Current.MainPage.DisplayAlert("jdkj", "sjacb", "kjsb");
            //await Shell.Current.GoToAsync("RegistrationPage");
            Application.Current.MainPage = new AppShell();

        }
    }
}
