using System;
using System.Collections.Generic;

namespace VideoClubApp.Implementaciones
{
    public class VideoClubManager : IVideoClubManager
    {
        private List<Pelicula> peliculas; // Lista que contendrá las películas
        private List<Serie> series;        // Lista que contendrá las series

        public VideoClubManager()
        {
            peliculas = new List<Pelicula>();
            series = new List<Serie>(); // Inicializamos la lista de series
        }

        public void AgregarPelicula(Pelicula pelicula) // Método para agregar una película a la lista
        {
            peliculas.Add(pelicula);
            Console.WriteLine($"La película {pelicula.Titulo} fue agregada.");
        }

        public void AgregarSerie(Serie serie) // Método para agregar una serie a la lista
        {
            series.Add(serie);
            Console.WriteLine($"La serie {serie.Titulo} fue agregada.");
        }

        public void ListarPeliculas() // Método para listar todas las películas
        {
            Console.WriteLine("Películas en el Video Club:");
            foreach (var pelicula in peliculas)
            {
                Console.WriteLine($"Título: {pelicula.Titulo}, Director: {pelicula.Director}");
            }
        }

        public void ListarSeries() // Método para listar todas las series
        {
            Console.WriteLine("Series en el Video Club:");
            foreach (var serie in series)
            {
                Console.WriteLine($"Título: {serie.Titulo}, Director: {serie.Director}");
            }
        }

        public bool AlquilarPelicula(string titulo) // Método para alquilar una película
        {
            // Implementación del alquiler de película
            // Añadir lógica de negocio aquí
            return true;
        }

        public bool AlquilarSerie(string titulo) // Método para alquilar una serie
        {
            // Implementación del alquiler de serie
            return true;
        }

        public bool DevolverPelicula(string titulo) // Método para devolver una película
        {
            // Implementación de devolución de película
            return true;
        }

        public bool DevolverSerie(string titulo) // Método para devolver una serie
        {
            // Implementación de devolución de serie
            return true;
        }
    }
}
