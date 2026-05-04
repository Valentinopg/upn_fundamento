Console.WriteLine("=== Menú de operaciones ===");
Console.WriteLine("1. Calcular área de un círculo");
Console.WriteLine("2. Calcular área de un cuadrado");
Console.WriteLine("3. Calcular área de un triáunglo");
Console.WriteLine("4. Salir");
Console.WriteLine("Seleccione una opción (1-4): ");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Área círculo = p x r²");
        break;

    case 2:
        Console.WriteLine("Área cuadrado = lado²");
        break;

    case 3:
        Console.WriteLine("Área triángulo = (base x altura) / 2");
        break;

    case 4:
        Console.WriteLine("Saliendo del programa...");
        break;

    default:
        Console.WriteLine("Opción invalida. Ingresa un número del 1 al 4.");
        break;
}

