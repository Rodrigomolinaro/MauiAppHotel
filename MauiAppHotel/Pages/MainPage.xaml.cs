using MauiAppHotel.Models;
using MauiAppHotel.PageModels;

namespace MauiAppHotel.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}