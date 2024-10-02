using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace VideoClubApp.Implementaciones
{
    public class VideoClubManager
    {
        private List<Pelicula> peliculas;
        private List<Serie> series;
        private const string archivoPeliculas = "peliculas.json";
        private const string archivoSeries = "series.json";

        public VideoClubManager()
        {
            peliculas = new List<Pelicula>();
            series = new List<Serie>();
        }

        // Método para agregar una película
        public void AgregarPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }

        // Método para agregar una serie
        public void AgregarSerie(Serie serie)
        {
            series.Add(serie);
        }

        // Método para listar las películas
        public void ListarPeliculas()
        {
            Console.WriteLine("\n===== Películas disponibles =====");
            foreach (var pelicula in peliculas)
            {
                Console.WriteLine($"{pelicula.Titulo} - Dirigida por {pelicula.Director} - Protagonizada por {pelicula.Actor} - Género: {pelicula.Genero}");
            }
        }

        // Método para listar las series
        public void ListarSeries()
        {
            Console.WriteLine("\n===== Series disponibles =====");
            foreach (var serie in series)
            {
                Console.WriteLine($"{serie.Titulo} - Dirigida por {serie.Director} - Protagonizada por {serie.Actor} - Género: {serie.Genero} - Episodios: {serie.NumeroEpisodios}");
            }
        }

        // Método para alquilar una película
        public void AlquilarPelicula(string titulo)
        {
            var pelicula = peliculas.FirstOrDefault(p => p.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (pelicula != null)
            {
                if (pelicula.CantidadStock > 0)
                {
                    pelicula.CantidadStock--;
                    Console.WriteLine($"Has alquilado: {pelicula.Titulo}");
                }
                else
                {
                    Console.WriteLine("Lo sentimos, no hay stock disponible para esta película.");
                }
            }
            else
            {
                Console.WriteLine("Película no encontrada.");
            }
        }

        // Método para alquilar una serie
        public void AlquilarSerie(string titulo)
        {
            var serie = series.FirstOrDefault(s => s.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (serie != null)
            {
                if (serie.CantidadStock > 0)
                {
                    serie.CantidadStock--;
                    Console.WriteLine($"Has alquilado: {serie.Titulo}");
                }
                else
                {
                    Console.WriteLine("Lo sentimos, no hay stock disponible para esta serie.");
                }
            }
            else
            {
                Console.WriteLine("Serie no encontrada.");
            }
        }

        // Método para devolver una película
        public void DevolverPelicula(string titulo)
        {
            var pelicula = peliculas.FirstOrDefault(p => p.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (pelicula != null)
            {
                pelicula.CantidadStock++;
                Console.WriteLine($"Has devuelto: {pelicula.Titulo}");
            }
            else
            {
                Console.WriteLine("Película no encontrada.");
            }
        }

        // Método para devolver una serie
        public void DevolverSerie(string titulo)
        {
            var serie = series.FirstOrDefault(s => s.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (serie != null)
            {
                serie.CantidadStock++;
                Console.WriteLine($"Has devuelto: {serie.Titulo}");
            }
            else
            {
                Console.WriteLine("Serie no encontrada.");
            }
        }

        // Cargar los datos desde el archivo
        public void CargarDatosDesdeArchivo()
        {
            if (File.Exists(archivoPeliculas))
            {
                var jsonPeliculas = File.ReadAllText(archivoPeliculas);
                peliculas = JsonSerializer.Deserialize<List<Pelicula>>(jsonPeliculas);
            }

            if (File.Exists(archivoSeries))
            {
                var jsonSeries = File.ReadAllText(archivoSeries);
                series = JsonSerializer.Deserialize<List<Serie>>(jsonSeries);
            }
        }

        // Guardar los datos en el archivo
        public void GuardarDatosEnArchivo()
        {
            var jsonPeliculas = JsonSerializer.Serialize(peliculas);
            File.WriteAllText(archivoPeliculas, jsonPeliculas);

            var jsonSeries = JsonSerializer.Serialize(series);
            File.WriteAllText(archivoSeries, jsonSeries);
        }
    }
}
