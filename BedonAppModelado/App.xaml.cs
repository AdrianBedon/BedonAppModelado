using BedonAppModelado.Data;

namespace BedonAppModelado;

public partial class App : Application
{
	public static Database FrasesRepo { get; set; }
	public App(Database repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
		FrasesRepo = repo;
	}
}
