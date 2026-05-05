Random rand = new Random();
int secreto = rand.Next(1, 51);

int intentos = 0;
int maxIntentos = 7;
bool adivino = false;

Console.WriteLine("Adivina el número entre 1 y 50. Tienes 7 intentos.");

while (intentos < maxIntentos && !adivino)
{
    intentos++;

    Console.Write($"Intento {intentos} : ");
    int intento = int.Parse(Console.ReadLine());

    if (intento == secreto)
    {
        adivino = true;
    }
    else if (secreto > intento)
    {
        Console.WriteLine("El número secreto es MAYOR.");
    }
    else
    {
        Console.WriteLine("El número secreto es MENOR.");
    }
}

if (adivino = true)
{
    Console.WriteLine($"Ganaste en {intentos} intentos.");
}
else
{
    Console.WriteLine($"Perdiste. El número era {secreto} .");
}
