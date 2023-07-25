namespace Aplicaciones;

public partial class Empresa : ContentPage
{
	public Empresa()
	{
		InitializeComponent();
	}
    private void ConvertirClicked(object sender, EventArgs e)
    {
        decimal cantidadPesos;
        if (decimal.TryParse(txtCantidad.Text, out cantidadPesos))
        {
            // Tipo de cambio actual (ejemplo)
            decimal tipoCambio = 0.05m;

            decimal cantidadDolares = cantidadPesos * tipoCambio;
            lblCantidadDolares.Text = cantidadDolares.ToString("C");
        }
        else
        {
            DisplayAlert("Error", "Ingresa una cantidad válida en pesos mexicanos.", "Aceptar");
        }
    }
    }