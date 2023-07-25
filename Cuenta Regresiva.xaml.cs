namespace Aplicaciones;

public partial class Cuenta_Regresiva : ContentPage
{
    private int countdownValue = 10;
    private bool isCounting = false;

    public Cuenta_Regresiva()
	{
		InitializeComponent();
        BackgroundColor = Colors.MediumPurple; // Cambiar el color de fondo de la página a azul claro
        startButton.Clicked += StartButton_Clicked;
        resetButton.Clicked += ResetButton_Clicked;
    }

    private async void StartButton_Clicked(object sender, EventArgs e)
    {
        if (!isCounting)
        {
            isCounting = true;
            startButton.IsEnabled = false;

            while (countdownValue > 0)
            {
                countdownLabel.Text = countdownValue.ToString();
                await Task.Delay(1000); // Espera 1 segundo
                countdownValue--;

                if (!isCounting)
                    break;
            }

            if (isCounting)
            {
                countdownLabel.Text = "¡Tiempo agotado!";
                startButton.IsEnabled = true;
            }
        }
    }

    private void ResetButton_Clicked(object sender, EventArgs e)
    {
        isCounting = false;
        countdownValue = 10;
        countdownLabel.Text = string.Empty;
        startButton.IsEnabled = true;
    }

}
