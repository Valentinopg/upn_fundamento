Console.WriteLine("Promedio final");
Console.WriteLine("Ingrese su examen parcial:");
double exa_parc = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su examen final:");
double exa_fin = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su practica 1:");
double p1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su practica 2:");
double p2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese su practica 3:");
double p3 = double.Parse(Console.ReadLine());

if (exa_parc < 0 || exa_parc > 20 ||
    exa_fin < 0 || exa_fin > 20 ||
    p1 < 0 || p1 > 20 ||
    p2 < 0 || p2 > 20 ||
    p3 < 0 || p3 > 20)
{
    Console.WriteLine("Hay una nota invalida");
    return;
}

double prom_prac = (p1 + p2 + p3 - Math.Min(p1, Math.Min(p2, p3))) / 2;
double prom_final = (exa_parc + exa_fin + prom_prac) / 3;

string dese;

if (prom_final >= 18)
{
    dese = "Excelente";
}
else if (prom_final >= 14)
{
    dese = "Bueno";
}
else if (prom_final >= 10)
{
    dese = "Regular";
}
else
{
    dese = "Deficiente";
}

// Salida
Console.WriteLine($"Promedio de practicas: {Math.Round(prom_prac, 2)}");
Console.WriteLine($"Promedio final: {Math.Round(prom_final, 2)} | Su desempeño fue {dese}");
