using System;
using Microsoft.Maui.Controls;
using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    
    public HospedagemContratada(Hospedagem hospedagem)
    {
        InitializeComponent();

        
        BindingContext = hospedagem;
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        try
        {
            
            await Navigation.PopToRootAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}