using Microsoft.Maui.ApplicationModel.Communication;
using ShopingApp.MVVM.ViewModels;

namespace ShopingApp.MVVM.View;

public partial class LoginPage : ContentPage
{
    int pass = 1;

    public LoginPage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        BindingContext = new LoginPageViewModel();
    }

    private void ShowPassword(object sender, EventArgs e)
    {
        if (pass == 1)
        {
            password.IsPassword = false;
            passwordImage.Source = "openeye.png";
            pass = 0;
        }
        else
        {
            password.IsPassword = true;
            passwordImage.Source = "closeeye.png";
            pass = 1;
        }
    }

    private async void UserCheck()
    {
        if (string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(password.Text))
        {
            await DisplayAlert("Error", "Please fill in all fields before submitting.", "OK");
            
            return;
        }

        var existingUser = UserList.Users
         .FirstOrDefault(u => u.Email == email.Text && u.Password == password.Text);

        if (existingUser != null)
        {
            await DisplayAlert("Message", "Sing Up Successfull :)", "OK");
            await Navigation.PushAsync(new HomePage());
        }
        else
        {
            await DisplayAlert("Error", "Invalid Credential !!!", "ok");
            email.Text = string.Empty;
            password.Text = string.Empty;
        }
    }

    private void OnSubmit(object sender, EventArgs e)
    {
        UserCheck();
    }
}
