using System.Diagnostics.SymbolStore;

double saldo = 1000.00;
int retiros = 0;

Console.WriteLine("=== CAJERO AUTOMATICO ===");
Console.WriteLine($"Saldo disponible: S/{saldo:F2}");

Console.WriteLine("Monto a retirar (0 para salir): ");
double monto = double.Parse(Console.ReadLine());

while (monto != 0)
{
    if (monto < 0)
    {
        Console.WriteLine("Error: monto invalido.");
    }
    else if (monto > saldo)
    {
        Console.WriteLine("Error: saldo insuficiente.");
    }
    else
    {
        saldo -= monto;
        retiros += 1;

        Console.WriteLine($"Retiro exitoso. Saldo: S/{saldo:F2}");
    }
    Console.WriteLine("Monto a retirar (0 para salir): ");
    monto = double.Parse(Console.ReadLine());
}

Console.WriteLine("---RESUMEN---");
Console.WriteLine($"Retiros realidazos: {retiros}");
Console.WriteLine($"Saldo final: S/{saldo:F2}");