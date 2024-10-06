using System.Windows;
using System.Windows.Controls;
using VideoClubApp.Implementaciones;

namespace VideoClubWPF
{
    public partial class DevolverPelicula : Page
    {
        private VideoClubManager videoClubManager;

        public DevolverPelicula(VideoClubManager manager)
        {
            InitializeComponent();
            videoClubManager = manager;
            CargarPeliculas(); // Cargar las películas disponibles
        }

        // Cargar las películas en el ComboBox
        private void CargarPeliculas()
        {
            var peliculas = videoClubManager.ObtenerPeliculas();
            PeliculasComboBox.ItemsSource = peliculas;
            PeliculasComboBox.DisplayMemberPath = "Titulo"; // Mostrar solo el título de las películas
        }

        // Evento al hacer clic en el botón "Devolver"
        private void DevolverButton_Click(object sender, RoutedEventArgs e)
        {
            var peliculaSeleccionada = PeliculasComboBox.SelectedItem as Pelicula;
            if (peliculaSeleccionada != null)
            {
                bool exito = videoClubManager.DevolverPelicula(peliculaSeleccionada.Titulo);
                if (exito)
                {
                    MessageBox.Show("Película devuelta exitosamente.");
                    CargarPeliculas(); // Refrescar la lista después de devolver
                }
                else
                {
                    MessageBox.Show("Error al devolver la película.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una película.");
            }
        }
    }
}
