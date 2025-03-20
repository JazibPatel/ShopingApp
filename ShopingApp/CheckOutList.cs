using ShopingApp.MVVM.Models;
using System.Collections.ObjectModel;

public static class CheckOutList
{
    public static ObservableCollection<CheckOut> checkouts { get; set; } = new ObservableCollection<CheckOut>();
}
