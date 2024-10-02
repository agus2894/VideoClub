using System;
using VideoClubApp.Implementaciones;

class Program
{
    static void Main(string[] args)
    {
        VideoClubManager gestor = new VideoClubManager();

        // Cargamos los datos al iniciar el programa
        gestor.CargarDatosDesdeArchivo();

        // Menú interactivo para el usuario
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n===== VIDEO CLUB MENU =====");
            Console.WriteLine("1. Listar Películas");
            Console.WriteLine("2. Listar Series");
            Console.WriteLine("3. Alquilar Película");
            Console.WriteLine("4. Alquilar Serie");
            Console.WriteLine("5. Devolver Película");
            Console.WriteLine("6. Devolver Serie");
            Console.WriteLine("7. Agregar Película");
            Console.WriteLine("8. Agregar Serie");
            Console.WriteLine("9. Guardar y Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    gestor.ListarPeliculas();
                    break;
                case "2":
                    gestor.ListarSeries();
                    break;
                case "3":
                    Console.Write("Introduce el título de la película que quieres alquilar: ");
                    string tituloPelicula = Console.ReadLine();
                    gestor.AlquilarPelicula(tituloPelicula);
                    break;
                case "4":
                    Console.Write("Introduce el título de la serie que quieres alquilar: ");
                    string tituloSerie = Console.ReadLine();
                    gestor.AlquilarSerie(tituloSerie);
                    break;
                case "5":
                    Console.Write("Introduce el título de la película que quieres devolver: ");
                    tituloPelicula = Console.ReadLine();
                    gestor.DevolverPelicula(tituloPelicula);
                    break;
                case "6":
                    Console.Write("Introduce el título de la serie que quieres devolver: ");
                    tituloSerie = Console.ReadLine();
                    gestor.DevolverSerie(tituloSerie);
                    break;
                case "7":
                    AgregarNuevaPelicula(gestor);
                    break;
                case "8":
                    AgregarNuevaSerie(gestor);
                    break;
                case "9":
                    gestor.GuardarDatosEnArchivo();
                    Console.WriteLine("Datos guardados. Gracias por usar el Video Club. ¡Hasta luego!");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, intenta de nuevo.");
                    break;
            }
        }
    }

    static void AgregarNuevaPelicula(VideoClubManager gestor)
    {
        Console.WriteLine("Agregar nueva película:");
        Console.Write("Título: ");
        string titulo = Console.ReadLine();
        Console.Write("Actor Principal: ");
        string actor = Console.ReadLine();
        Console.Write("Director: ");
        string director = Console.ReadLine();
        Console.Write("Género: ");
        string genero = Console.ReadLine();
        Console.Write("Duración (en minutos): ");
        int duracion = int.Parse(Console.ReadLine());
        Console.Write("Cantidad en stock: ");
        int cantidadStock = int.Parse(Console.ReadLine());
        Console.Write("Precio de alquiler: ");
        decimal precioAlquiler = decimal.Parse(Console.ReadLine());
        DateTime fechaIngreso = DateTime.Now;

        Pelicula nuevaPelicula = new Pelicula(titulo, actor, director, genero, duracion, cantidadStock, precioAlquiler, fechaIngreso);
        gestor.AgregarPelicula(nuevaPelicula);
    }

    static void AgregarNuevaSerie(VideoClubManager gestor)
    {
        Console.WriteLine("Agregar nueva serie:");
        Console.Write("Título: ");
        string titulo = Console.ReadLine();
        Console.Write("Actor Principal: ");
        string actor = Console.ReadLine();
        Console.Write("Director: ");
        string director = Console.ReadLine();
        Console.Write("Género: ");
        string genero = Console.ReadLine();
        Console.Write("Duración (en minutos): ");
        int duracion = int.Parse(Console.ReadLine());
        Console.Write("Cantidad en stock: ");
        int cantidadStock = int.Parse(Console.ReadLine());
        Console.Write("Precio de alquiler: ");
        decimal precioAlquiler = decimal.Parse(Console.ReadLine());
        Console.Write("Número de episodios: ");
        int numEpisodios = int.Parse(Console.ReadLine());
        DateTime fechaIngreso = DateTime.Now;

        Serie nuevaSerie = new Serie(titulo, actor, director, genero, duracion, cantidadStock, precioAlquiler, fechaIngreso, numEpisodios);
        gestor.AgregarSerie(nuevaSerie);
    }
}
