namespace ShadeMobileApp.Views;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}

    private async void NavigateToMainPage(object sender, EventArgs e)
    {
        // delay of 100 milliseconds
        await Task.Delay(10);

        // Navigate to the main page
        await this.Navigation.PushAsync(new MainPage());
    }
}