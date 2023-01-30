using BedonAppModelado.Models;

namespace BedonAppModelado.Views;

public partial class AgregarFrase : ContentPage
{
    Frase frase = new Frase();
	public AgregarFrase()
	{
		InitializeComponent();
	}

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        frase.TextoFrase = Frase.Text;
        frase.Author = Autor.Text;

        App.FrasesRepo.AddNewFrase(frase);
        FrasesFavoritas frasef = new FrasesFavoritas();
        frasef.frasef = frase.Id;
        frasef.isFavorite = false;
        App.FrasesRepo.AddNewFraseFavorita(frasef);

        await Shell.Current.GoToAsync("..");
    }

    private async void CancelButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}