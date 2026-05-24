using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class PaginaInicial : ContentPage

{

    List<Quarto> quartos = new();

    public PaginaInicial()
	{
		InitializeComponent();

        quartos = ((App)Application.Current).lista_quartos;
        cv_quartos.ItemsSource = quartos;

    }

    private async void ContratarHospedagem_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContratacaoHospedagem());
    }
    private async void SaibaMais_Clicked(object sender, EventArgs e)
    {
        Button botao = sender as Button;

        Quarto quartoSelecionado =
            botao.CommandParameter as Quarto;

        await Navigation.PushAsync(
            new QuartoPage(quartoSelecionado));
    }

    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new SobreDesenvolvedor());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}