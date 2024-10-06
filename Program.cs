using Contructor;
using System;
using VideoClubApp.Implementaciones;
class Program
{
    static void Main(string[] args)
    {
        VideoClubManager gestor = new VideoClubManager();

        gestor.CargarDatosDesdeArchivo();               // Cargamos los datos al iniciar el programa

        
        bool salir = false;                             // Menú interactivo para el usuario

        while (!salir)
        {
            Console.WriteLine("\n===== Bienvenido al VideoCLub EL CUDI =====");
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
                    Console.Write("Titulo de la pelicula que queres alquilar: ");
                    string tituloPelicula = Console.ReadLine();
                    gestor.AlquilarPelicula(tituloPelicula);
                    break;
                case "4":
                    Console.Write("Titulo de la serie que queres alquilar: ");
                    string tituloSerie = Console.ReadLine();
                    gestor.AlquilarSerie(tituloSerie);
                    break;
                case "5":
                    Console.Write("Titulo de la pelicula que queres devolver: ");
                    tituloPelicula = Console.ReadLine();
                    gestor.DevolverPelicula(tituloPelicula);
                    break;
                case "6":
                    Console.Write("Titulo de la serie que queres devolver: ");
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
                    Console.WriteLine("Datos guardados. Gracias por venir. Vuelva Pronto");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opcion no Valida. Por favor, intenta de nuevo.");
                    break;
            }
        }
    }

    static void AgregarNuevaPelicula(VideoClubManager gestor)
    {
        Console.WriteLine("Agregar nueva pelicula:");
        Console.Write("Titulo: ");
        string titulo = Console.ReadLine();
        Console.Write("Actor Principal: ");
        string actor = Console.ReadLine();
        Console.Write("Director: ");
        string director = Console.ReadLine();
        Console.Write("Genero: ");
        string genero = Console.ReadLine();
        Console.Write("Duracion (en minutos): ");
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
        Console.Write("Titulo: ");
        string titulo = Console.ReadLine();
        Console.Write("Actor Principal: ");
        string actor = Console.ReadLine();
        Console.Write("Director: ");
        string director = Console.ReadLine();
        Console.Write("Genero: ");
        string genero = Console.ReadLine();
        Console.Write("Duracion (en minutos): ");
        int duracion = int.Parse(Console.ReadLine());
        Console.Write("Cantidad en stock: ");
        int cantidadStock = int.Parse(Console.ReadLine());
        Console.Write("Precio de alquiler: ");
        decimal precioAlquiler = decimal.Parse(Console.ReadLine());
        Console.Write("Numero de episodios: ");
        int numEpisodios = int.Parse(Console.ReadLine());
        DateTime fechaIngreso = DateTime.Now;

        Serie nuevaSerie = new Serie(titulo, actor, director, genero, duracion, cantidadStock, precioAlquiler, fechaIngreso, numEpisodios);
        gestor.AgregarSerie(nuevaSerie);
    }
}
//Aca tenemos el menu que usaria el usuario
//Ademas que estan los metodos para cargar las peliculas
//De aca salen las interfaces y las implementaciones