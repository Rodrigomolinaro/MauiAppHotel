using System;
using Microsoft.Maui.Controls;
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

        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);
        dtpck_checkin.MinimumDate = DateTime.Now;

        dtpck_checkout.MaximumDate = DateTime.Now.AddMonths(6);
        dtpck_checkout.MinimumDate = DateTime.Now.AddDays(1);
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        
        DateTime dataSelecionada = (DateTime)e.NewDate;

        dtpck_checkout.MaximumDate = dataSelecionada.AddMonths(6);
        dtpck_checkout.MinimumDate = dataSelecionada.AddDays(1);
    }

    private async void Avancar_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (pck_quarto.SelectedItem == null)
                throw new Exception("Por favor, selecione uma suíte.");

            if (stp_adultos.Value == 0 && stp_criancas.Value == 0)
                throw new Exception("Por favor, informe a quantidade de hóspedes.");

            Hospedagem h = new Hospedagem
            {
                QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                QtdAdultos = (int)stp_adultos.Value,
                QtdCriancas = (int)stp_criancas.Value,
                
                DataCheckIn = (DateTime)dtpck_checkin.Date,
                DataCheckOut = (DateTime)dtpck_checkout.Date
            };

            await Navigation.PushAsync(new HospedagemContratada(h));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}