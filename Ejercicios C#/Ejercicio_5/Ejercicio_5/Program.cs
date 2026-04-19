Console.WriteLine("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());

if (edad >= 18)
{
    Console.WriteLine("Acceso perminito. Bienvenido");
}
else
{
    Console.WriteLine("Acceso denegado");
    Console.WriteLine($"Te faltan {Math.Abs(18 - edad)} año(S) para registrarte");
}
