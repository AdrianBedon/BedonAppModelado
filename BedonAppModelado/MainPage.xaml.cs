using BedonAppModelado.Models;
using BedonAppModelado.Views;

namespace BedonAppModelado;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        LoadFrases();
	}

    public void LoadFrases()
    {
        List<Frase> frase = App.FrasesRepo.GetAllFrases();
        Frases.ItemsSource = frase;
    }

    protected override void OnAppearing()
    {
        LoadFrases();
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AgregarFrase));
    }

    private async void frasesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            var frase = (Models.Frase)e.CurrentSelection[0];

            string action = await DisplayActionSheet("Seleccione la acción que desea realizar:", "Cancel", null, "Favorito", "Borrar");

            if (action == "Favorito")
            {
                FrasesFavoritas FraseF = new FrasesFavoritas();
                FraseF.toggleFavorite(frase);
            }
            else if (action == "Borrar")
            {
                App.FrasesRepo.DeleteFrase(frase);
                LoadFrases();
            }
            else
            {
                LoadFrases();
            }

            Frases.SelectedItem = null;
        }

    }
}

