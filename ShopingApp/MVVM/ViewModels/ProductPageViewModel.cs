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
        public List<Product> FilteredProducts { get; set; }

        public ProductPageViewModel(string category)
        {

            var allProducts = new HomePageViewModel().Products;
            FilteredProducts = allProducts.Where(p => p.Category == category).ToList();

        }

       
    }
}