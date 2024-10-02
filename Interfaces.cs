//La interface seria es "QUE" vamos a usar del Contructor//Program.cs

using VideoClubApp;

public interface IVideoClubManager
{
    void AgregarPelicula(Pelicula pelicula);
    void ListarPeliculas();
    bool AlquilarPelicula(string titulo);
    bool DevolverPelicula(string titulo);
}
//La interfaz establece el "contrato" que las clases que la implementen deben cumplir.
//Estas clases deberán definir cómo se agregarán, listarán, alquilarán y devolverán películas
//en el sistema del videoclub. Este enfoque permite la flexibilidad para cambiar
//la implementación de las operaciones del videoclub sin afectar al resto del sistema,
//ya que todas las interacciones se realizan a través de esta interfaz.

