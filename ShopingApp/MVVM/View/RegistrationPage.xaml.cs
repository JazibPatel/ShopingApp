using ShopingApp.MVVM.ViewModels;

namespace ShopingApp.MVVM.View;

public partial class RegistrationPage : ContentPage
{

	int count = 1;
	public RegistrationPage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        BindingContext = new RegistrationPageViewModel();
    
	}

    private void MoreDetilClick(object sender, EventArgs e)
    {
		if(count == 1)
		{
            MoreDetailGrid.IsVisible = true;
            MoreDetailBtn.TextColor = Colors.Red;
            MoreDetailImg.Source = "minus.png";
            count = 0;
        }
		else
		{
            MoreDetailGrid.IsVisible = false;
            MoreDetailBtn.TextColor = Colors.Black;
            MoreDetailImg.Source = "plus.png";
            count = 1;
        }
        
    }
}