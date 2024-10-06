using System.Windows;
using System.Windows.Controls;
using VideoClubApp.Implementaciones;

namespace VideoClubWPF
{
    public partial class AlquilarPelicula : Page
    {
        private VideoClubManager videoClubManager;

        public AlquilarPelicula(VideoClubManager manager)
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

        // Evento al hacer clic en el botón "Alquilar"
        private void AlquilarButton_Click(object sender, RoutedEventArgs e)
        {
            var peliculaSeleccionada = PeliculasComboBox.SelectedItem as Pelicula;
            if (peliculaSeleccionada != null)
            {
                bool exito = videoClubManager.AlquilarPelicula(peliculaSeleccionada.Titulo);
                if (exito)
                {
                    MessageBox.Show("Película alquilada exitosamente.");
                    CargarPeliculas(); // Refrescar la lista después de alquilar
                }
                else
                {
                    MessageBox.Show("No hay stock disponible para esta película.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una película.");
            }
        }
    }
}
