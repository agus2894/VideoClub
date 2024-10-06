using Contructor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace VideoClubApp.Implementaciones
{
    public class VideoClubManager
    {
        private List<Pelicula> peliculas;
        private List<Serie> series;
        private const string PeliculasFilePath = "peliculas.json"; // Ruta del archivo JSON de películas
        private const string SeriesFilePath = "series.json";       // Ruta del archivo JSON de series

        public VideoClubManager()
        {
            peliculas = new List<Pelicula>();
            series = new List<Serie>();
            CargarDatosDesdeArchivo(); // Carga datos al inicializar
        }

        // Carga datos desde archivos JSON
        public void CargarDatosDesdeArchivo()
        {
            if (File.Exists(PeliculasFilePath))
            {
                var json = File.ReadAllText(PeliculasFilePath);
                peliculas = JsonSerializer.Deserialize<List<Pelicula>>(json) ?? new List<Pelicula>();
            }

            if (File.Exists(SeriesFilePath))
            {
                var json = File.ReadAllText(SeriesFilePath);
                series = JsonSerializer.Deserialize<List<Serie>>(json) ?? new List<Serie>();
            }
        }

        // Guarda datos en archivos JSON
        public void GuardarDatosEnArchivo()
        {
            var peliculasJson = JsonSerializer.Serialize(peliculas);
            File.WriteAllText(PeliculasFilePath, peliculasJson);

            var seriesJson = JsonSerializer.Serialize(series);
            File.WriteAllText(SeriesFilePath, seriesJson);
        }

        // Lista todas las películas
        public void ListarPeliculas()
        {
            if (peliculas.Count == 0)
            {
                Console.WriteLine("No hay películas disponibles.");
                return;
            }

            foreach (var pelicula in peliculas)
            {
                Console.WriteLine(pelicula.ToString()); // Asegúrate de que Pelicula tenga un ToString() definido
            }
        }

        // Lista todas las series
        public void ListarSeries()
        {
            if (series.Count == 0)
            {
                Console.WriteLine("No hay series disponibles.");
                return;
            }

            foreach (var serie in series)
            {
                Console.WriteLine(serie.ToString()); // Asegúrate de que Serie tenga un ToString() definido
            }
        }

        // Alquila una película
        public bool AlquilarPelicula(string titulo)
        {
            var pelicula = peliculas.Find(p => p.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (pelicula != null && pelicula.CantidadStock > 0)
            {
                pelicula.CantidadStock--;
                return true; // Alquiler exitoso
            }
            return false; // Alquiler fallido
        }

        // Alquila una serie
        public bool AlquilarSerie(string titulo)
        {
            var serie = series.Find(s => s.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (serie != null && serie.CantidadStock > 0)
            {
                serie.CantidadStock--;
                return true; // Alquiler exitoso
            }
            return false; // Alquiler fallido
        }

        // Devuelve una película
        public bool DevolverPelicula(string titulo)
        {
            var pelicula = peliculas.Find(p => p.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (pelicula != null)
            {
                pelicula.CantidadStock++;
                return true; // Devolución exitosa
            }
            return false; // Devolución fallida
        }

        // Devuelve una serie
        public bool DevolverSerie(string titulo)
        {
            var serie = series.Find(s => s.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (serie != null)
            {
                serie.CantidadStock++;
                return true; // Devolución exitosa
            }
            return false; // Devolución fallida
        }

        // Agrega una nueva película
        public bool AgregarPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
            return true; // Película agregada exitosamente
        }

        // Agrega una nueva serie
        public bool AgregarSerie(Serie serie)
        {
            series.Add(serie);
            return true; // Serie agregada exitosamente
        }

        // Obtiene la lista de películas
        public List<Pelicula> ObtenerPeliculas()
        {
            return peliculas; // Retorna la lista de películas
        }

        // Obtiene la lista de series
        public List<Serie> ObtenerSeries()
        {
            return series; // Retorna la lista de series
        }

        public void AgregarPelicula(string titulo, string actorPrincipal, string director, string genero, int duracion, int cantidadStock, double precioAlquiler, DateTime fechaIngreso)
        {
            throw new NotImplementedException();
        }
    }
}
