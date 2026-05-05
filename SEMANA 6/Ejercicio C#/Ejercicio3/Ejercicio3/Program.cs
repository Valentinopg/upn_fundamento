using System.Xml;

int stock = 500;
int totalVendido = 0;

Console.WriteLine("Unidades vendidas (0 para salir): ");
int venta = int.Parse(Console.ReadLine());

while (venta != 0)
{
    if (venta < 0)
    {
        Console.WriteLine("Error: canidad no puede ser negativa");
    }
    else if (stock < venta)
    {
        Console.WriteLine($"Error: stock insuficiente. Queda {stock}");
    }
    else
    {
        stock -= venta;
        totalVendido += 1;
        Console.WriteLine($"Venta registrada. Stock: {stock}");
    }

    Console.WriteLine("Unidades vendidas (0 para salir): ");
    venta = int.Parse(Console.ReadLine());

}
Console.WriteLine($"Stock restante: {stock} ");
Console.WriteLine($"Total vendido: {totalVendido} ");
