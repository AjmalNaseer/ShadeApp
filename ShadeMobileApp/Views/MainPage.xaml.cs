using ShadeMobileApp.ViewModel;
using ShadeMobileApp.Views;
using Syncfusion.Maui.Charts;

namespace ShadeMobileApp;


public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        
    }

    private async void NavigateToAddProduct(object sender, EventArgs e)
    {
        // delay of 100 milliseconds
        await Task.Delay(10);

        // Navigate to the main page
        await this.Navigation.PushAsync(new AddProductPage());
    }
}

