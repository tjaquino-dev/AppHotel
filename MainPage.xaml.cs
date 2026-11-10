namespace AppHotel;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lblHospedes.Text =
            $"{stepHospedes.Value:F0} hóspede(s)";
    }

    private async void Reservar_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert(
            "Reserva",
            $"Reserva realizada para {stepHospedes.Value:F0} hóspede(s).",
            "OK");
    }

    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }
}