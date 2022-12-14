using Android.App;
using Android.Runtime;
using Java.Lang;

namespace M0glan.Maui.NativeLibraryBinding;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
		
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
