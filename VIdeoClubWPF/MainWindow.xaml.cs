using implementaciones;
using System.Windows;

namespace VideoClubApp
{
    public partial class MainWindow : Window
    {
        private VideoClubManager gestor;

        public MainWindow()
        {
            InitializeComponent();
            gestor = new VideoClubManager();
            gestor.CargarDatosDesdeArchivo(); // Cargar datos al iniciar la aplicación
        }

        // Evento al hacer clic en "Listar Películas"
        private void Button_Click_ListarPeliculas(object sender, RoutedEventArgs e)
        {
            gestor.ListarPeliculas();
        }

        // Evento al hacer clic en "Listar Series"
        private void Button_Click_ListarSeries(object sender, RoutedEventArgs e)
        {
            gestor.ListarSeries();
        }

        // Evento al hacer clic en "Alquilar Películas"
        private void Button_Click_AlquilarPeliculas(object sender, RoutedEventArgs e)
        {
            gestor.AlquilarPelicula(); // Asegúrate que el método exista
        }

        // Evento al hacer clic en "Devolver Películas"
        private void Button_Click_DevolverPeliculas(object sender, RoutedEventArgs e)
        {
            gestor.DevolverPelicula(); // Asegúrate que el método exista
        }

        // Evento al hacer clic en "Agregar Películas"
        private void Button_Click_AgregarPeliculas(object sender, RoutedEventArgs e)
        {
            gestor.AgregarPelicula(); // Asegúrate que el método exista
        }

        // Evento al hacer clic en "Guardar y Salir"
        private void Button_Click_GuardarSalir(object sender, RoutedEventArgs e)
        {
            gestor.GuardarDatosEnArchivo(); // Asegúrate que el método exista
            Application.Current.Shutdown(); // Cerrar la aplicación
        }
    }
}
