namespace MauiAppHotel.Views;

public partial class Inicio : ContentPage
{
    public Inicio()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Navega de forma segura para o ecrã de cálculo de hospedagem
        await Navigation.PushAsync(new ContratacaoHospedagem());
    }
}