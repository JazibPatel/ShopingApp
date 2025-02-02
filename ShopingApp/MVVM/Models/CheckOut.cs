using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingApp.MVVM.Models
{
    internal class CheckOut
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public double Total { get; set; }

        public bool Pending { get; set; }

        public bool InProcess { get; set; }

        public bool OutForDelivery { get; set; }

        public bool Delivered { get; set; }
    }
}
