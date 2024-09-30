using System;
using VideoClubApp;

public class Serie : Pelicula                    //Practicamos Herencia entre Pelicula y Series
{
    public int NumeroEpisodios { get; set; }    //Lo que suma Series

                                                //Lo que tenia Peliculas
    public Serie(string titulo, string actor, string director, string genero, int duracion, int cantidadStock, decimal precioAlquiler, DateTime fechaIngreso, int numeroEpisodios)
        : base(titulo, actor, director, genero, duracion, cantidadStock, precioAlquiler, fechaIngreso)
    {
        NumeroEpisodios = numeroEpisodios;
    }
}
//La clase Serie agrega el comportamiento específico de las series al sistema de videoclub.
//A través de la herencia, reaprovecha toda la funcionalidad de Pelicula (como título, director, etc.)
//y añade su propia característica (número de episodios)