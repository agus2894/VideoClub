using System;
using System.Collections.Generic;
using System.IO;

namespace implementaciones
{
    public class VideoClubManager
    {
        // Listas para almacenar películas y series
        private List<Pelicula> peliculas;
        private List<Serie> series;

        public VideoClubManager()
        {
            peliculas = new List<Pelicula>();
            series = new List<Serie>();
        }

        // Método para cargar datos desde un archivo
        public void CargarDatosDesdeArchivo()
        {
            // Ejemplo de carga de datos desde archivo
            if (File.Exists("datos.txt"))
            {
                string[] lineas = File.ReadAllLines("datos.txt");
                foreach (var linea in lineas)
                {
                    // Suponiendo que las películas están separadas por comas
                    var datos = linea.Split(',');
                    if (datos.Length > 0)
                    {
                        // Crear una nueva película y agregarla a la lista
                        peliculas.Add(new Pelicula { Titulo = datos[0] });
                    }
                }
            }
        }

        // Método para listar todas las películas
        public void ListarPeliculas()
        {
            Console.Clear(); // Limpiar la consola para mostrar nuevas entradas
            Console.WriteLine("Listado de Películas:");
            foreach (var pelicula in peliculas)
            {
                Console.WriteLine(pelicula.Titulo); // Aquí puedes mostrar en la UI
            }
        }

        // Método para listar todas las series
        public void ListarSeries()
        {
            Console.Clear(); // Limpiar la consola para mostrar nuevas entradas
            Console.WriteLine("Listado de Series:");
            foreach (var serie in series)
            {
                Console.WriteLine(serie.Titulo); // Aquí puedes mostrar en la UI
            }
        }

        // Método para alquilar una película
        public void AlquilarPelicula()
        {
            // Lógica para alquilar una película (ejemplo simplificado)
            Console.WriteLine("Ingrese el título de la película a alquilar:");
            string titulo = Console.ReadLine();

            var pelicula = peliculas.Find(p => p.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (pelicula != null)
            {
                Console.WriteLine($"Película '{pelicula.Titulo}' alquilada.");
            }
            else
            {
                Console.WriteLine("Película no encontrada.");
            }
        }

        // Método para devolver una película
        public void DevolverPelicula()
        {
            // Lógica para devolver una película (ejemplo simplificado)
            Console.WriteLine("Ingrese el título de la película a devolver:");
            string titulo = Console.ReadLine();

            // Aquí podrías añadir lógica para confirmar que la película fue alquilada
            Console.WriteLine($"Película '{titulo}' devuelta.");
        }

        // Método para agregar una película
        public void AgregarPelicula()
        {
            Console.WriteLine("Ingrese el título de la nueva película:");
            string titulo = Console.ReadLine();

            // Agregar la nueva película a la lista
            peliculas.Add(new Pelicula { Titulo = titulo });
            Console.WriteLine($"Película '{titulo}' agregada.");
        }

        // Método para guardar datos en un archivo
        public void GuardarDatosEnArchivo()
        {
            using (StreamWriter writer = new StreamWriter("datos.txt"))
            {
                foreach (var pelicula in peliculas)
                {
                    writer.WriteLine(pelicula.Titulo); // Puedes añadir más datos separados por comas
                }
            }
            Console.WriteLine("Datos guardados en el archivo.");
        }
    }

    // Clase para representar una película
    public class Pelicula
    {
        public string Titulo { get; set; }
        // Puedes agregar más propiedades como Director, Duración, etc.
    }

    // Clase para representar una serie (si es necesaria)
    public class Serie
    {
        public string Titulo { get; set; }
        // Puedes agregar más propiedades como Temporadas, Episodios, etc.
    }
}
