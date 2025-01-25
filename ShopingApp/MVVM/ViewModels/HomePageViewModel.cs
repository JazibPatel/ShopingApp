using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ShopingApp.MVVM.Models;
using ShopingApp.MVVM.View;

namespace ShopingApp.MVVM.ViewModels
{
    internal class HomePageViewModel
    {
        public List<HomePageProduct> Product { get; set; }

        public ICommand LoginBtn { get; }

        public HomePageViewModel()
        {
            Product = new List<HomePageProduct>()
            {
                new HomePageProduct
                {
                    ImageUrl = "p11",
                    Name = "Flared High Jeans",
                    Price = 1499.00F,
                },
                new HomePageProduct
                {
                    ImageUrl = "p7",
                    Name = "Patterned resort shirt",
                    Price = 1299.00F,
                },
                new HomePageProduct
                {
                    ImageUrl = "p4",
                    Name = "Regular Fit T-shirt",
                    Price = 1299.00F,
                },
                new HomePageProduct
                {
                    ImageUrl = "p10",
                    Name = "Slim Fit Dressy Joggers",
                    Price = 2699.00F,
                },
                new HomePageProduct
                {
                    ImageUrl = "p9",
                    Name = "Sleeves Printed Top",
                    Price = 799.00F,
                },
                new HomePageProduct
                {
                    ImageUrl = "p5",
                    Name = "Full Sleeve Sweatshirt",
                    Price = 1499.00F,
                },
                new HomePageProduct
                {
                    ImageUrl = "p8",
                    Name = "Green T-Shirt",
                    Price = 1099.00F,
                },
                new HomePageProduct
                {
                    ImageUrl = "p1",
                    Name = "Printed Round Neck",
                    Price = 1499.00F,
                },
                new HomePageProduct
                {
                    ImageUrl = "p6",
                    Name = "Fit Solid Spread Collar",
                    Price = 2499.00F,
                },
                new HomePageProduct
                {
                    ImageUrl = "p2",
                    Name = "Light Blue Jeans",
                    Price = 999.00F,
                },
                new HomePageProduct
                {
                    ImageUrl = "p3",
                    Name = "Casual Crop Top",
                    Price = 999.00F,
                },
            };

            LoginBtn = new Command(OpenNewPage);
        }

        private void OpenNewPage()
        {
            Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
    }
}
