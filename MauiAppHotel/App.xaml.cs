namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // AQUI ESTÁ A CORREÇÃO: Dizer ao app para usar o AppShell (o menu lateral)
            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;
            return window;
        }

    }
}