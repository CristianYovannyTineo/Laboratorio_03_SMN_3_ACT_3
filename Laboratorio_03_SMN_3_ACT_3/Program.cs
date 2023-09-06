

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la edad : ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese adivinanzas acertadas (0-5): ");
        int adivinanzas = int.Parse(Console.ReadLine());

        double montoInicial = CalcularMontoInicial(edad, adivinanzas);
        double montoExtra = MontoExtra(edad, adivinanzas);
        double montoFinal = montoInicial + montoExtra;

        Console.WriteLine($"El monto Total del premio es: S/ {montoFinal:F2}");
    }
    static double CalcularMontoInicial(int edad, int adivinanzas)
    {
        if (edad >= 18)
        {
            if (adivinanzas >= 3)
            {
                return 50.0;
            }
            else
            {
                return 30.0;
            }
        }
        else
        {
            if (adivinanzas >= 3)
            {
                return 80.0;
            }
            else
            {
                return 50.0;
            }
        }
    }
    static double MontoExtra(int edad, int adivinanzas)
    {
        double montoExtra = (edad * 5.0) + (adivinanzas * 2.0);
        return montoExtra;
    }
}