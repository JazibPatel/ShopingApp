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
        public Color ViewAllBackground { get; set; }
        public Color ViewAllTextColor { get; set; }

        public Color AccessoriesBackground { get; set; }
        public Color AccessoriesTextColor { get; set; }

        public Color ClothesBackground { get; set; }
        public Color ClothesTextColor { get; set; }

        public ICommand CategoryBtn { get; }

        public ProductPageViewModel(string category)
        {
            ViewAllBackground = Color.FromRgb(255,255,255);
            ViewAllTextColor = Color.FromRgb(0,0,0);

            AccessoriesBackground = Color.FromRgb(255, 255, 255);
            AccessoriesTextColor = Color.FromRgb(0, 0, 0);

            ClothesBackground = Color.FromRgb(255, 255, 255);
            ClothesTextColor = Color.FromRgb(0, 0, 0);

            CategoryBtn = new Command<string>(OnCategoryTapped);
        }

        private void OnCategoryTapped(string category) {

            ViewAllBackground = Color.FromRgb(255, 255, 255);
            ViewAllTextColor = Color.FromRgb(0, 0, 0);

            AccessoriesBackground = Color.FromRgb(255, 255, 255);
            AccessoriesTextColor = Color.FromRgb(0, 0, 0);

            ClothesBackground = Color.FromRgb(255, 255, 255);
            ClothesTextColor = Color.FromRgb(0, 0, 0);

            switch (category) {

                case "ViewAll":
                    ViewAllBackground = Color.FromRgb(255, 0, 0);
                    ViewAllTextColor = Color.FromRgb(255, 255, 255);
                    break;

                case "Accessories":
                    AccessoriesBackground = Color.FromRgb(255, 0, 0);
                    AccessoriesTextColor = Color.FromRgb(255, 255, 255);
                    break;

                case "Clothes":
                    ClothesBackground = Color.FromRgb(255, 0, 0);
                    ClothesTextColor = Color.FromRgb(255, 255, 255);
                    break;

            }

        }
    }
}
