using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = (dtpck_checkin.Date ?? DateTime.Now).AddDays(1);
        dtpck_checkout.MaximumDate = (dtpck_checkin.Date ?? DateTime.Now).AddMonths(6);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Hospedagem h = new Hospedagem
            {
                QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                QntAdultos = Convert.ToInt32(stp_adultos.Value),
                QntCriancas = Convert.ToInt32(stp_criancas.Value),
                DataCheckIn = (DateTime) dtpck_checkin.Date,
                DataCheckOut = (DateTime) dtpck_checkout.Date,
            };

            if (h.QntAdultos == 0 && h.QntCriancas == 0)
            {
                await DisplayAlert("Nenhum hóspede selecionado", "Selecione pelo menos 1 hóspede!", "OK");
                return;
            }

            if (h.QuartoSelecionado == null)
            {
                await DisplayAlert("Nenhum quarto selecionado", "Selecione o quarto desejado!", "OK");
                return;
            }

            await Navigation.PushAsync(new HospedagemContratada()
            {
                BindingContext = h
            });

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
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
    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = (DateTime)elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}