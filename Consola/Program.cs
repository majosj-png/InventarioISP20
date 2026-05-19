public class Program
{
    private static void Main(string[] args)
    {
        CreamosVariables();

        Console.WriteLine("Probando imprimir algo en la pantalla");
        ImprisionDeParametros(args);

        CapturaDeValoresDelUsuario();
    }

    private static void CapturaDeValoresDelUsuario()
    {
        Console.WriteLine("Ingrese el año de su nacimiento: ");
        string anio_nacimiento = Console.ReadLine();
        int anio = Convert.ToInt32(anio_nacimiento);
        int edad = DateTime.Now.Year - anio;
        Console.WriteLine($"Su edad es aproximada es: {edad}");
    }


    private static void ImprisionDeParametros(string[] args)
    {
        if (args.Length >1)
            Console.WriteLine($"Hola: {args[0]} {args[1]}");
    }

    
    private static void CreamosVariables()
    {
        int numero = 10;
        int numero2 = 20;

        numero2 = 20;
        int numero3 = 30;
    }
}