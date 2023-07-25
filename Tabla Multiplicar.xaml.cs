namespace Aplicaciones;

public partial class Tabla_Multiplicar : ContentPage
{
	public Tabla_Multiplicar()
	{
        BackgroundColor = Colors.DarkViolet;
        InitializeComponent();

        var multiplicationTables = GenerateMultiplicationTables();

        multiplicationTablesListView.ItemsSource = multiplicationTables;
    }
    private List<string> GenerateMultiplicationTables()
    {
        var multiplicationTables = new List<string>();

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                var result = i * j;
                multiplicationTables.Add($"{i} x {j} = {result}");
            }
        }

        return multiplicationTables;
    }
}