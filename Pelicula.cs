using System;
public class Pelicula
{
    public string Titulo { get; set; }
    public string ActorPrincipal { get; set; }
    public string Director { get; set; }
    public string Genero { get; set; }
    public int Duracion { get; set; }
    public int CantidadStock { get; set; }
    public decimal PrecioAlquiler { get; set; }
    public DateTime FechaIngreso { get; set; }

    public Pelicula() { }

    public Pelicula(string titulo, string actorPrincipal, string director, string genero, int duracion, int cantidadStock, decimal precioAlquiler, DateTime fechaIngreso)
    {
        Titulo = titulo;
        ActorPrincipal = actorPrincipal;
        Director = director;
        Genero = genero;
        Duracion = duracion;
        CantidadStock = cantidadStock;
        PrecioAlquiler = precioAlquiler;
        FechaIngreso = fechaIngreso;
    }
}
