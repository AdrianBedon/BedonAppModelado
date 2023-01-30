using BedonAppModelado.Models;

namespace BedonAppModelado.Views;

public partial class Favoritas : ContentPage
{
	public Favoritas()
	{
		InitializeComponent();
        LoadFrasesF();
	}

    protected override void OnAppearing()
    {
        LoadFrasesF();
    }

    public void LoadFrasesF()
    {
        List<FrasesFavoritas> frase = App.FrasesRepo.GetFavorites();
        List<Frase> frasesf = new List<Frase>();
        foreach (FrasesFavoritas fraseU in frase)
        {
            frasesf.Add(App.FrasesRepo.GetFrase(fraseU.frasef));
        }    
        FrasesF.ItemsSource = frasesf;
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AgregarFrase));
    }
}