using ShopingApp.MVVM.Models;
using ShopingApp.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShopingApp.MVVM.ViewModels
{
    class ProductPageViewModel
    {
       
        public ICommand BackBtn { get; }
        public ICommand ProductClickedCommand { get; }

        public ProductPageViewModel()
        {

            BackBtn = new Command(OpenHomePage);
            
            ProductClickedCommand = new Command(OnProductClicked);
        }

        private void OpenHomePage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
        private void OnProductClicked()
        {
            
            Application.Current.MainPage.Navigation.PushAsync(new ProductDetailPage());

        }
    }
}