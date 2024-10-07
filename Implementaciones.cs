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
            CargarDatosDesdeArchivo(); // Carga datos al Empezar
        }

        public void CargarDatosDesdeArchivo()        // Carga datos desde JSON
        {
            if (File.Exists(PeliculasFilePath))
            {
                var json = File.ReadAllText(PeliculasFilePath);
                peliculas = JsonSerializer.Deserialize<List<Pelicula>>(json) ?? new List<Pelicula>();
                Console.WriteLine($"Películas cargadas: {peliculas.Count}");
            }

            if (File.Exists(SeriesFilePath))
            {
                var json = File.ReadAllText(SeriesFilePath);
                series = JsonSerializer.Deserialize<List<Serie>>(json) ?? new List<Serie>();
                Console.WriteLine($"Series cargadas: {series.Count}");
            }
        }

        public void GuardarDatosEnArchivo()        // Guarda datos en JSON
        {
            var peliculasJson = JsonSerializer.Serialize(peliculas);
            File.WriteAllText(PeliculasFilePath, peliculasJson);
            Console.WriteLine("Películas guardadas correctamente en el archivo.");

            var seriesJson = JsonSerializer.Serialize(series);
            File.WriteAllText(SeriesFilePath, seriesJson);
            Console.WriteLine("Series guardadas correctamente en el archivo.");
        }

        public List<Pelicula> ListarPeliculas()   // Lista todas las películas
        {
            List<Pelicula> listaDePeliculas = ObtenerPeliculas();
            if (peliculas.Count == 0)
            {
                Console.WriteLine("No hay películas disponibles.");
            }
            else
            {
                foreach (var pelicula in peliculas)
                {
                    Console.WriteLine($"Título: {pelicula.Titulo}, Stock: {pelicula.CantidadStock}");
                }
            }
            return listaDePeliculas;
        }

        public List<Serie> ListarSeries()        // Lista todas las series
        {
            List<Serie> listaDeSeries = ObtenerSeries();
            if (series.Count == 0)
            {
                Console.WriteLine("No hay series disponibles.");
            }
            else
            {
                foreach (var serie in series)
                {
                    Console.WriteLine($"Título: {serie.Titulo}, Stock: {serie.CantidadStock}");
                }
            }
            return listaDeSeries;
        }

        public bool AlquilarPelicula(string titulo)        // Alquila una película
        {
            var pelicula = peliculas.Find(p => p.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (pelicula != null && pelicula.CantidadStock > 0)
            {
                pelicula.CantidadStock--;
                return true; // Alquiler exitoso
            }
            return false; // Alquiler fallido
        }

        public bool AlquilarSerie(string titulo)        // Alquila una serie
        {
            var serie = series.Find(s => s.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (serie != null && serie.CantidadStock > 0)
            {
                serie.CantidadStock--;
                return true; // Alquiler exitoso
            }
            return false; // Alquiler fallido
        }

        public bool DevolverPelicula(string titulo)        // Devuelve una película
        {
            var pelicula = peliculas.Find(p => p.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (pelicula != null)
            {
                pelicula.CantidadStock++;
                return true; // Devolución exitosa
            }
            return false; // Devolución fallida
        }

        public bool DevolverSerie(string titulo)        // Devuelve una serie
        {
            var serie = series.Find(s => s.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
            if (serie != null)
            {
                serie.CantidadStock++;
                return true; // Devolución exitosa
            }
            return false; // Devolución fallida
        }

        public bool AgregarPelicula(Pelicula pelicula)        // Agrega una nueva película
        {
            peliculas.Add(pelicula);
            return true; // Película agregada exitosamente
        }

        public bool AgregarSerie(Serie serie)        // Agrega una nueva serie
        {
            series.Add(serie);
            return true; // Serie agregada exitosamente
        }

        public List<Pelicula> ObtenerPeliculas()        // De da la lista de películas
        {
            return peliculas;
        }

        public List<Serie> ObtenerSeries()        // Te da la lista de series
        {
            return series;
        }

        public void AgregarPelicula(string titulo, string actorPrincipal, string director, string genero, int duracion, int cantidadStock, double precioAlquiler, DateTime fechaIngreso)
        {
            throw new NotImplementedException();
        }

        public void AgregarSerie(string titulo, string actorPrincipal, string director, string genero, int duracion, int cantidadStock, double precioAlquiler, DateTime fechaIngreso, int numeroEpisodios)
        {
            throw new NotImplementedException();
        }
    }
}
