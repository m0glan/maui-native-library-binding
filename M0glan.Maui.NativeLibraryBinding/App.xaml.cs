namespace M0glan.Maui.NativeLibraryBinding;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
