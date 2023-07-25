namespace Aplicaciones;

public partial class Langosta_Ahumada : ContentPage
{
	public Langosta_Ahumada()
	{
		InitializeComponent();
	}
    private void CalcularClicked(object sender, EventArgs e)
    {
        int numeroPersonas;
        if (int.TryParse(txtNumeroPersonas.Text, out numeroPersonas))
        {
            double costoPorPersona;
            if (numeroPersonas > 200 && numeroPersonas <= 300)
            {
                costoPorPersona = 85.00;
            }
            else if (numeroPersonas > 300)
            {
                costoPorPersona = 75.00;
            }
            else
            {
                costoPorPersona = 95.00;
            }

            double presupuestoTotal = numeroPersonas * costoPorPersona;
            lblPresupuestoTotal.Text = presupuestoTotal.ToString("C");
        }
        else
        {
            DisplayAlert("Error", "Ingresa un número válido de personas.", "Aceptar");
        }
    }
}