using System;
using Microsoft.Maui.Controls;
using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    // Este construtor agora pede o objeto Hospedagem (Isto resolve o erro CS1729!)
    public HospedagemContratada(Hospedagem hospedagem)
    {
        InitializeComponent();

        // Liga os dados recebidos à interface visual
        BindingContext = hospedagem;
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Retorna diretamente para a primeira página do aplicativo (Tela de Início)
            await Navigation.PopToRootAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}