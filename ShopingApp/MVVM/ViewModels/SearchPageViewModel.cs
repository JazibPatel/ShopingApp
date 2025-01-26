using ShopingApp.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShopingApp.MVVM.ViewModels
{
    internal class SearchPageViewModel
    {
        public ICommand BackBtn { get; }

        public SearchPageViewModel()
        {
            BackBtn = new Command(HomePage);
        }

        private async void HomePage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
    }
}
