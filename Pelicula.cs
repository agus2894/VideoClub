using System;
namespace VideoClubApp
{

    public class Pelicula           //Carga de datos
    {
        public int Cantidad_Depositvo;
        public int Cantidad_Alquilada;
        public DateTime Fecha_Ingreso;
        public decimal Precio_Alquiler;

        //Se usa get y set para encapsular nuestra informacion y no CW ni Read que es modificable y no queremos eso
        public string Titulo { get; set; }
        public string Actor_Principal { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public int Duracion { get; set; }
        public int CantidadStock { get; set; }
        public int CantidadAlquilada { get; set; }
        public decimal PrecioAlquiler { get; set; }
        public DateTime FechaIngreso { get; set; }

        // Constructor. Seria nuestra "QUE" estamos creando. Nuestro Objeto
        public Pelicula(string titulo, string actor, string director, string genero, int duracion, int cantidadStock, decimal precioAlquiler, DateTime fechaIngreso)
        {
            Titulo = titulo;
            Actor_Principal = actor;
            Director = director;
            Genero = genero;
            Duracion = duracion;
            CantidadStock = cantidadStock;
            CantidadAlquilada = 0; // Empieza sin películas alquiladas
            PrecioAlquiler = precioAlquiler;
            FechaIngreso = fechaIngreso;
        }

        public Pelicula()
        {
        }
    }
}

//La clase encapsula la información sobre una película.
//Los atributos pueden modificarse solo a través de las propiedades, manteniendo control sobre cómo se accede y
//modifica la información, lo cual es importante para asegurar la integridad de los datos dentro del sistema.