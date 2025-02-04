namespace ShopingApp.MVVM.View;

public partial class OrderPage : ContentPage
{
    public OrderPage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        BindingContext = CheckOutList.checkouts;
        
    }

    private async void BackBtn(object sender, EventArgs e)
    {
        await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
    }
}
