namespace M0glan.Maui.NativeLibraryBinding;

public partial class MainPage : ContentPage
{
	private readonly MathFuncs.MathFuncs _svc = new();

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		double addition = _svc.Add(2, 2);

		CounterBtn.Text = $"The result is {addition}.";
	}
}

