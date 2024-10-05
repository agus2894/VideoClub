using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; // Asegúrate de incluir el namespace correcto para tus modelos

namespace VideoClubApp.Implementaciones
{
    public class VideoClubManager
    {
        private List<Pelicula> peliculas;
        private List<Serie> series;

        public VideoClubManager()
        {
            peliculas = new List<Pelicula>();
            series = new List<Serie>();
            CargarDatosDesdeArchivo(); // Cargar datos al iniciar
        }

        public bool GuardarDatosEnArchivo()
        {
            try
            {
                // Serializa las listas a JSON
                string jsonPeliculas = JsonSerializer.Serialize(peliculas);
                string jsonSeries = JsonSerializer.Serialize(series);

                File.WriteAllText("peliculas.json", jsonPeliculas);
                File.WriteAllText("series.json", jsonSeries);

                return true; // Retornar true si el guardado fue exitoso
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar los datos: " + ex.Message);
                return false; // Retornar false si hubo un error
            }
        }

        public bool CargarDatosDesdeArchivo()
        {
            try
            {
                // Cargar películas
                if (File.Exists("peliculas.json"))
                {
                    string jsonPeliculas = File.ReadAllText("peliculas.json");
                    peliculas = JsonSerializer.Deserialize<List<Pelicula>>(jsonPeliculas) ?? new List<Pelicula>();
                }

                // Cargar series
                if (File.Exists("series.json"))
                {
                    string jsonSeries = File.ReadAllText("series.json");
                    series = JsonSerializer.Deserialize<List<Serie>>(jsonSeries) ?? new List<Serie>();
                }

                return true; // Retornar true si la carga fue exitosa
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los datos: " + ex.Message);
                return false; // Retornar false si hubo un error
            }
        }

        // Aquí irían otros métodos para agregar, alquilar, devolver, etc.
        // ...

        public List<Pelicula> ObtenerPeliculas()
        {
            return peliculas;
        }

        public List<Serie> ObtenerSeries()
        {
            return series;
        }

        // Métodos para agregar películas y series, alquilar, devolver, etc.
        // ...
    }
}
