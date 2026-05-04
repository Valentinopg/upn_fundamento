Console.WriteLine("Categoria: ");
string cat = Console.ReadLine().ToUpper();
Console.WriteLine("Horas: ");
double horas = double.Parse(Console.ReadLine());
Console.WriteLine("Años: ");
int años = int.Parse(Console.ReadLine());

double tarifa = 0;

if (cat == "A") tarifa = 33.50;
else if (cat == "B") tarifa = 29.80;
else if (cat == "C") tarifa = 25.70;
else
{
    Console.WriteLine("Categoria Invalida");
        return;
}

double bono = 0;

if (años >= 0 && años <= 3) bono = 0.00;
else if (años >= 4 && años <= 10) bono = 0.10;
else if (años >= 11 && años <= 17) bono = 0.20;
else bono = 0.30;

double sueldoFinal = tarifa * horas * (1 + bono);

Console.WriteLine($"Sueldo: S/. {sueldoFinal:F2}");