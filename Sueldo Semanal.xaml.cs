namespace Aplicaciones;

public partial class Sueldo_Semanal : ContentPage
{
	public Sueldo_Semanal()
	{
        BackgroundColor = Colors.BlueViolet;
        InitializeComponent();
	}
    private void ButtonCalcular_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(entryHorasTrabajadas.Text, out double horasTrabajadas) &&
            double.TryParse(entryPagoPorHora.Text, out double pagoPorHora))
        {
            double sueldoSemanal = horasTrabajadas * pagoPorHora * 7; // Multiplicar por 7 días de trabajo
            labelSueldoSemanal.Text = sueldoSemanal.ToString("C");
        }
        else
        {
            labelSueldoSemanal.Text = "Ingrese valores numéricos válidos";
        }
    }
    }