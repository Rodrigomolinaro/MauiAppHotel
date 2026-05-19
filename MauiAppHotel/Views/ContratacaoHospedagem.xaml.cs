using System; // Força o VS a carregar as extensões de Data (AddDays, AddMonths)
using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;
        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        // 1. Configuração inicial do Check-in
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);
        dtpck_checkin.MinimumDate = DateTime.Now;

        // 2. Configuração inicial do Check-out
        dtpck_checkout.MaximumDate = DateTime.Now.AddMonths(6);
        dtpck_checkout.MinimumDate = DateTime.Now.AddDays(1);
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        // Forçando o C# a reconhecer o tipo correto armazenando em uma variável explícita
        DateTime dataSelecionada = e.NewDate.Value;

        // 3. Atualização do Check-out usando a variável limpa
        dtpck_checkout.MaximumDate = dataSelecionada.AddMonths(6);
        dtpck_checkout.MinimumDate = dataSelecionada.AddDays(1);
    }

    private async void Avancar_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}