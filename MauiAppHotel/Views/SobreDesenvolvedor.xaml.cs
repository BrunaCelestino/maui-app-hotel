namespace MauiAppHotel.Views;

public partial class SobreDesenvolvedor : ContentPage
{
	public SobreDesenvolvedor()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}