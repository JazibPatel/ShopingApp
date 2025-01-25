using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ShopingApp.MVVM.View;

namespace ShopingApp.MVVM.ViewModels
{
    class NavbarPageViewModel
    {

        public ICommand NavbarTab { get; }

        public NavbarPageViewModel()
        {
            NavbarTab = new Command(OpenNewPage);
        }
        private async void OpenNewPage()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new FlyoutNavbar());
        }

        //private bool _flyoutNavbar;
        //public bool FlyoutNavbar
        //{
        //    get => _flyoutNavbar;
        //    set
        //    {
        //        _flyoutNavbar = value;
        //    }
        //}

        //public ICommand NavbarTab { get; }
        
        //public NavbarPageViewModel()
        //{

        //    NavbarTab = new Command(ToggleNavbarFlyout);

        //}

        //private void ToggleNavbarFlyout()
        //{
        //    FlyoutNavbar = !FlyoutNavbar;
        //}

    }
}
