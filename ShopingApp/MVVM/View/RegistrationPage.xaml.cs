using ShopingApp.MVVM.Models;
using ShopingApp.MVVM.View;
using ShopingApp.MVVM.ViewModels;

namespace ShopingApp.MVVM.View;

public partial class RegistrationPage : ContentPage
{
    int count = 1;
    int pass = 1;

    public RegistrationPage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        BindingContext = new RegistrationPageViewModel();
    }

    private void MoreDetilClick(object sender, EventArgs e)
    {
        if (count == 1)
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

    private async void AddUser()
    {
        if (
            string.IsNullOrWhiteSpace(email.Text)
            || string.IsNullOrWhiteSpace(password.Text)
            || DOB.Date == DateTime.MinValue
            || check.IsChecked == false
        )
        {
            await DisplayAlert("Error", "Please fill in all fields before submitting.", "OK");
            return;
        }

        var existingUser = UserList.Users.FirstOrDefault(u =>
            u.Email == email.Text && u.Password == password.Text
        );

        if (existingUser != null)
        {
            await DisplayAlert(
                "Error",
                "Email is already in use. Please choose a different email.",
                "OK"
            );
            //await Navigation.PushAsync(new RegistrationPage());
            email.Text = string.Empty;
            return;
        }

        UserList.Users.Add(
            new User
            {
                Email = email.Text,
                Password = password.Text,
                DOB = DOB.Date.ToString("yyyy-MM-dd"),
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Gender = gender.SelectedItem?.ToString(),
                PostalCode = postalCode.Text,
            }
        );

        await DisplayAlert("Success", "User added successfully!", "OK");
        await Navigation.PushAsync(new HomePage());
    }

    private void OnSubmit(object sender, EventArgs e)
    {
        AddUser();

        //await Navigation.PushAsync(new LoginPage());
    }

    //private async void ReloadPage()
    //{

    //    await Navigation.PopAsync();
    //    await Navigation.PushAsync(new RegistrationPage());
    //}
}
