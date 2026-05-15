class Program
{
    static bool EsNotaValida(double nota)
    {
        return  nota >= 0 && nota <= 20;
    } 
    static string ClasificarNota(double nota)
    {
        if (nota >= 18)
        {
            return "Excelente";
        }
        else if (nota >= 14)
        {
            return "Bueno";
        }
        else if (nota >= 11)
        {
            return "Regular";
        }
        else
        {
            return "Desaprobado";
        }
    }
    static void MostrarReporte(double nota, string clasificacion) { 
        Console.WriteLine($"Nota ingresada: {nota} ");
        Console.WriteLine($"Clasificacion: {clasificacion}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la nota: ");
        double nota = double.Parse(Console.ReadLine());

        if (EsNotaValida(nota))
        {
            string clasificacion = ClasificarNota(nota);

            MostrarReporte(nota, clasificacion);
        }
        else
        {
            Console.WriteLine("Error: la nota debe estar entre 0 y 20");
        }
    }
}
