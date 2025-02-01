namespace ShopingApp.MVVM.View;

public partial class SizePage : ContentPage
{
	public SizePage()
	{
		InitializeComponent();
		NavigationPage.SetHasNavigationBar(this, false);
	}

    private async void BackBtn(object sender, EventArgs e)
    {
		await Application.Current.MainPage.Navigation.PopAsync();
    }
}