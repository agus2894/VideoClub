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

        // Métodos para agregar películas y series
        public void AgregarPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }

        public void AgregarSerie(Serie serie)
        {
            series.Add(serie);
        }

        // Métodos para listar
        public void ListarPeliculas()
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

        // Métodos para alquilar y devolver
        public void AlquilarPelicula(string titulo)
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

        // Guardar datos en archivo JSON
        public void GuardarDatosEnArchivo()
        {
            var datos = new
            {
                peliculas = peliculas,
                series = series
            };

            string jsonString = JsonSerializer.Serialize(datos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(archivoJson, jsonString);
        }

        // Cargar datos desde archivo JSON
        public void CargarDatosDesdeArchivo()
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