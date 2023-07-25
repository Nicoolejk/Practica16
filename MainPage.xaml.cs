namespace Aplicaciones;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	
    private void Cuenta_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Cuenta_Regresiva());
    }

    private void Numeros_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Numeros_Pares());
    }

    private void Tabla_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Tabla_Multiplicar());
    }

    private void Langosta_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Langosta_Ahumada());
    }

    private void Sueldo_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Sueldo_Semanal());
    }

    private void Empresa_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Empresa());
    }

    private void Nosotros_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Nosotros());
    }
}

