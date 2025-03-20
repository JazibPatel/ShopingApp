using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShopingApp.MVVM.Models
{
    public class Order : INotifyPropertyChanged
    {
        public Product Product { get; set; }

        public int TotalQuantity { get; set; }

        public double TotalPrice { get; set; }

        private bool _pending;
        public bool Pending
        {
            get => _pending;
            set
            {
                if (_pending != value)
                {
                    _pending = value;
                    OnPropertyChanged(nameof(Pending));
                    OnPropertyChanged(nameof(PendingImage));
                }
            }
        }

        private bool _shipped;
        public bool Shipped
        {
            get => _shipped;
            set
            {
                if (_shipped != value)
                {
                    _shipped = value;
                    OnPropertyChanged(nameof(Shipped));
                    OnPropertyChanged(nameof(ShippedImage));
                }
            }
        }

        private bool _delivered;
        public bool Delivered
        {
            get => _delivered;
            set
            {
                if (_delivered != value)
                {
                    _delivered = value;
                    OnPropertyChanged(nameof(Delivered));
                    OnPropertyChanged(nameof(DeliveredImage));
                }
            }
        }

        private string _statusImage;
        public string StatusImage
        {
            get => _statusImage;
            set
            {
                if (_statusImage != value)
                {
                    _statusImage = value;
                    OnPropertyChanged(nameof(StatusImage));
                }
            }
        }

        public string PendingImage => Pending ? "green.png" : "gray.png";
        public string ShippedImage => Shipped ? "green.png" : "gray.png";
        public string DeliveredImage => Delivered ? "green.png" : "gray.png";

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
