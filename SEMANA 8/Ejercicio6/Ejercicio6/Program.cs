class Program
{
    static double CalcularCostoAgua(double m3)
    {
        if (m3 <= 20) 
        {
            return 20 * 1.80;
        }
        else
        {
            return 20 * 1.80 + (m3 - 20) * 2.50;
        }
        
    }
    static void MostrarRecibo(double m3, double costo)
    {
        Console.WriteLine($"Consumo: {m3} m3 ");
        Console.WriteLine($"Costo Total: S/. {costo:F2} ");

    }
    static void Main()
    {
        Console.WriteLine("Cuantos m3 de agua consumio: ");
        double consumo = double.Parse(Console.ReadLine());
        double costo = CalcularCostoAgua(consumo);

        MostrarRecibo(consumo, costo);

    }
    
}