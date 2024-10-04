using System.Text.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoClubApp.Implementaciones
{
    public class VideoClubManager
    {
        private List<Pelicula> peliculas;
        private List<Serie> series;
        private const string archivoJson = "videoclub.json";

        public VideoClubManager()
        {
            peliculas = new List<Pelicula>();
            series = new List<Serie>();
        }

        public void AgregarPelicula(Pelicula pelicula)  // Métodos para agregar películas y series

        {
            peliculas.Add(pelicula);
        }

        public void AgregarSerie(Serie serie)
        {
            series.Add(serie);
        }

        public void ListarPeliculas()                    // Métodos para listar

        {
            Console.WriteLine("\nPelículas en stock:");
            foreach (var pelicula in peliculas)
            {
                Console.WriteLine($"- {pelicula.Titulo} ({pelicula.CantidadStock} en stock)");
            }
        }

        public void ListarSeries()
        {
            Console.WriteLine("\nSeries en stock:");
            foreach (var serie in series)
            {
                Console.WriteLine($"- {serie.Titulo} ({serie.CantidadStock} en stock)");
            }
        }

        public void AlquilarPelicula(string titulo)     // Métodos para alquilar y devolver
        {
            var pelicula = peliculas.FirstOrDefault(p => p.Titulo == titulo);
            if (pelicula != null && pelicula.CantidadStock > 0)
            {
                pelicula.CantidadStock--;
                Console.WriteLine($"Has alquilado {pelicula.Titulo}");
            }
            else
            {
                Console.WriteLine("Película no disponible.");
            }
        }

        public void AlquilarSerie(string titulo)
        {
            var serie = series.FirstOrDefault(s => s.Titulo == titulo);
            if (serie != null && serie.CantidadStock > 0)
            {
                serie.CantidadStock--;
                Console.WriteLine($"Has alquilado {serie.Titulo}");
            }
            else
            {
                Console.WriteLine("Serie no disponible.");
            }
        }

        public void DevolverPelicula(string titulo)
        {
            var pelicula = peliculas.FirstOrDefault(p => p.Titulo == titulo);
            if (pelicula != null)
            {
                pelicula.CantidadStock++;
                Console.WriteLine($"Has devuelto {pelicula.Titulo}");
            }
        }

        public void DevolverSerie(string titulo)
        {
            var serie = series.FirstOrDefault(s => s.Titulo == titulo);
            if (serie != null)
            {
                serie.CantidadStock++;
                Console.WriteLine($"Has devuelto {serie.Titulo}");
            }
        }

        public void GuardarDatosEnArchivo()                 // Guardar datos en archivo JSON

        {
            var datos = new
            {
                peliculas = peliculas,
                series = series
            };

            string jsonString = JsonSerializer.Serialize(datos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(archivoJson, jsonString);
        }

        public void CargarDatosDesdeArchivo()               // Cargar datos desde archivo JSON

        {
            if (File.Exists(archivoJson))
            {
                string jsonString = File.ReadAllText(archivoJson);
                var datos = JsonSerializer.Deserialize<Dictionary<string, List<dynamic>>>(jsonString);

                peliculas = JsonSerializer.Deserialize<List<Pelicula>>(JsonSerializer.Serialize(datos["peliculas"]));
                series = JsonSerializer.Deserialize<List<Serie>>(JsonSerializer.Serialize(datos["series"]));
            }
        }
    }
}

//Esta Class es EL COMO del programa. Como se comportan nuestros Objetos
//Usamos JSON para que se vaya guardo la informacion de las peliculas y series
//Asi el usuario no tiene que estar iniciando todo desde cero
