namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    // Adicione este método:
    private async void AbrirSobre_Clicked(object sender, EventArgs e)
    {
        // Força a navegação direta para a sua tela Sobre
        await Shell.Current.GoToAsync("Sobre");
    }
}