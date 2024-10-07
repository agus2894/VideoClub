using System;
using System.Linq;
using System.Windows;
using VideoClubApp.Implementaciones;

namespace VideoClubWPF
{
    public partial class MainWindow : Window
    {
        private VideoClubManager videoClubManager;

        public MainWindow()
        {
            InitializeComponent();
            videoClubManager = new VideoClubManager(); // Instancia de VideoClubManager
        }

        private void ListarPeliculas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Llama al método para obtener la lista de películas desde VideoClubManager
                var peliculas = videoClubManager.ListarPeliculas();

                // Si hay películas disponibles, las mostramos en el ListBox
                if (peliculas != null && peliculas.Count > 0)
                {
                    // Muestra solo los títulos de las películas en el ListBox
                    PeliculasListBox.ItemsSource = peliculas.Select(p => p.Titulo).ToList();
                }
                else
                {
                    MessageBox.Show("No hay películas disponibles.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al listar las películas: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ListarSeries_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar el código para listar series si lo necesitas
        }

        private void AlquilarPelicula_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AlquilarPeliculaPage();
        }

        private void AlquilarSerie_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AlquilarSeriePage();
        }

        private void DevolverPelicula_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new DevolverPeliculaPage();
        }

        private void DevolverSerie_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new DevolverSeriePage();
        }

        private void AgregarPelicula_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AgregarPeliculaPage();
        }

        private void AgregarSerie_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AgregarSeriePage();
        }
    }
}
