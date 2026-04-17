Console.WriteLine("Ingrese el monto de la compra (S/): ");
double monto = double.Parse(Console.ReadLine());

double descuento = 0;

if (monto >=100)
{
    descuento = monto * 0.10;
}

double total = monto - descuento;

Console.WriteLine($"Descuento aplicado: S/ {descuento:F2}");
Console.WriteLine($"Total a pagar:      S/ {total:F2}");