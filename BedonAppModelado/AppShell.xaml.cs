namespace BedonAppModelado;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(Views.AgregarFrase), typeof(Views.AgregarFrase));
	}
}
