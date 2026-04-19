Console.WriteLine("Escriba su promedio (0-20):");
double promedio = double.Parse(Console.ReadLine());

string cali;

if (promedio < 0 || promedio > 20)
{
    cali = "Valor inválido";
}
else if (promedio <= 5)
{
    cali = "Deficiente";
}
else if (promedio <= 10)
{
    cali = "Regular";
}
else if (promedio <= 14)
{
    cali = "Bueno";
}
else
{
    cali = "Excelente";
}

Console.WriteLine($"Tu calificacion es: {cali}");