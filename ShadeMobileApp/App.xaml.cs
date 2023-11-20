namespace ShadeMobileApp;

public partial class App : Application
{
	public App()
	{
        //Register Syncfusion license
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjgwOTE3OEAzMjMzMmUzMDJlMzBMR3UzRDMwdzZPaUpiNTVlcno1RFJ1TEx5Q1IydlJYWWIzczEya3BreFd3PQ==");
        InitializeComponent();

		MainPage = new AppShell();
	}
}
