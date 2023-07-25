namespace Aplicaciones;

public partial class Numeros_Pares : ContentPage
{
    private int currentNumber = 0;
    private Label currentLabel;
    public Numeros_Pares()
	{
        BackgroundColor = Colors.MediumOrchid;
        InitializeComponent();

    
    }
    private void OnShowNumbersClicked(object sender, EventArgs e)
    {
        if (currentNumber > 100)
        {
            currentNumber = 0;
            numberStackLayout.Children.Clear();
        }

        if (currentLabel != null)
        {
            numberStackLayout.Children.Remove(currentLabel);
        }

        currentLabel = new Label()
        {
            Text = currentNumber.ToString(),
            HorizontalOptions = LayoutOptions.Center
        };

        numberStackLayout.Children.Add(currentLabel);
        currentNumber += 2;
    }
}