namespace WeatherClient;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new Models.WeatherData(); // Inicializar BindingContext para evitar errores de enlace
    }

    private async void btnRefresh_Clicked(object sender, EventArgs e)
    {
        btnRefresh.IsEnabled = false;
        actIsBusy.IsRunning = true;

        BindingContext = await Services.WeatherServer.GetWeather(txtPostalCode.Text);

        btnRefresh.IsEnabled = true;
        actIsBusy.IsRunning = false;
    }
}
