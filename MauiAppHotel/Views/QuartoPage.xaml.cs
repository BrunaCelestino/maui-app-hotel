using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class QuartoPage : ContentPage
{
    Quarto q_selecionado;

    public QuartoPage(Quarto q)
    {
        InitializeComponent();

        q_selecionado = q;

        img_quarto.Source = q.Imagem;

        lbl_titulo.Text = q.Descricao;

        lbl_descricao.Text = q.DescricaoCompleta;

        lbl_valorAdulto.Text =
            $"Diária Adulto: R$ {q.ValorDiariaAdulto:F2}";

        lbl_valorCrianca.Text =
            $"Diária Criança: R$ {q.ValorDiariaCrianca:F2}";
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContratacaoHospedagem(q_selecionado));
    }

    private void Button_Back_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}