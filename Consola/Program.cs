using Consola.Class;

public class Program
{
    private static void Main(string[] args)
    {
        //CreamosVariables();
        //CreamosMatricesYVectores();

        //Console.WriteLine("Probando imprimir algo en la pantalla");

        //ImprisionDeParametros(args);

        //CapturaDeValoresDelUsuario();
        //CreamosAlumnosEImprimimosSuFichaDeDatos();

        //CreamosEstudantesEImprimimosSuSaludo();
        // ProbamosMetodosConDiferentesValoresDeRetorno();

        //Ejercicio de la clase persona
        Ejercicio1();

        

    }

    private static void Ejercicio1()
    {
        Persona persona1 = new();
        persona1.nombre = "Tobias";
        persona1.edad = 30;
        Console.WriteLine($"Nombre: {persona1.nombre}, Edad: {persona1.edad}");

    }

    private static void ProbamosMetodosConDiferentesValoresDeRetorno()
    {
        AlumnoCurso alumno1 = new AlumnoCurso("Lucía", "Gómez", 19);

        alumno1.AgregarNota(8);
        alumno1.AgregarNota(7.5);
        alumno1.AgregarNota(9);
        alumno1.AgregarNota(3);
        alumno1.AgregarNota(4);

        string nombreCompleto = alumno1.ObtenerNombreCompleto();
        int cantidadNotas = alumno1.ObtenerCantidadDeNotas();
        double promedio = alumno1.CalcularPromedio();
        bool aprobado = alumno1.EstaAprobado();
        char inicial = alumno1.ObtenerInicial();
        int materiasDesaprobadas = alumno1.ContarMateriasDesaprobadas();   
        DateTime fechaConsulta = alumno1.ObtenerFechaConsulta();
        List<double> notas = alumno1.ObtenerNotas();

        Console.WriteLine("Nombre completo: " + nombreCompleto);
        Console.WriteLine("Cantidad de notas: " + cantidadNotas);
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("¿Está aprobado?: " + aprobado);
        Console.WriteLine("Inicial: " + inicial);
        Console.WriteLine("Fecha de consulta: " + fechaConsulta);
        Console.WriteLine("Materias desaprobadas: "+ materiasDesaprobadas);


    }

    private static void CreamosEstudantesEImprimimosSuSaludo()
    {
        Estudiante estudiante1 = new Estudiante();
        estudiante1.Nombre = "Tobias Longoni";
        estudiante1.Edad = 30;
        estudiante1.Domicilio = "Calle Falsa 123";
        Console.WriteLine(estudiante1.DatosPersonales);
        //estudiante1.Saludar();
    }

    private static void CreamosAlumnosEImprimimosSuFichaDeDatos()
    {
       Alumno alumno = new Alumno("Tobias", "Orecchia", 12345678, new DateOnly(1990, 5, 15));
        Console.WriteLine(alumno.ImpresionFichaDeDatos());

        Alumno alumno2 = new Alumno("Sofia", "Gomez", 87654321, new DateOnly(1995, 10, 20));
        Console.WriteLine(alumno.ImpresionFichaDeDatos());

        Alumno alumno3 = new Alumno("Federico", "Perez", 11223344, new DateOnly(1985, 3, 10));
        Console.WriteLine(alumno.ImpresionFichaDeDatos());

        //imprimimos la cantidad de instancias de alumnos creadas utilizando el metodo estatico de la clase alumno
        Console.WriteLine(Alumno.ImprimirCantidadDeInstancias());
    }

    private static void CreamosMatricesYVectores()
    {
        //creamos un vertor de tipo string con 12 posiciones para los meses del año
        string[] meses = new string[12] {
            "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
        };
        meses[0] = "ENERO";
        meses[11] = "DICIEMBRE";

        //creamos una matriz de 3 filas y 2 columnas para guardar el nombre y apellido de 3 personas
        string[,] nosotros = new string[3, 2] { { "Majo", "Longoni" }, { "Juan", "Agüero" }, { "Marcelo", "Albertissi" } };
        nosotros[0, 0] = "Loana";
        nosotros[2, 1] = "Nicolas";
        int[] edades = new int[3] { 25, 30, 35 };
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
        //declaramos una variable de tipo entera 
        int numero = 10;
        //declaracion de una variable de tipo string
        int numero2 = 20;
        //asignamos un valor a la variable numero2
        numero2 = 20;
        int numero3 = 30;
    }
}