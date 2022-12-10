namespace CourseWork;

public partial class App : Application
{
	public App()
	{
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Nzc3MTY4QDMyMzAyZTMzMmUzMGlNdVNSNE9WVUhRNTFzNVNrMUV4V1NFQ21ieVI3V2tOUzk2S21rdmx3Szg9");
        InitializeComponent();
		MainPage = new AppShell();
	}
}
