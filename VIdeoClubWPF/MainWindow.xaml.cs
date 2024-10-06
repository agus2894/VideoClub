using System.Windows;
using VideoClubWPF;

namespace VideoClubApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListarPeliculasButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListarPeliculas("Esta es la página para listar películas."));
        }

        private void ListarSeriesButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListarSeries("Esta es la página para listar series."));
        }

        private void AlquilarPeliculaButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AlquilarPelicula("Esta es la página para alquilar una película."));
        }

        private void AlquilarSerieButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AlquilarSerie("Esta es la página para alquilar una serie."));
        }

        private void DevolverPeliculaButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DevolverPelicula("Esta es la página para devolver una película."));
        }

        private void DevolverSerieButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DevolverSerie("Esta es la página para devolver una serie."));
        }

        private void AgregarPeliculaButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AgregarPelicula("Esta es la página para agregar una película."));
        }

        private void AgregarSerieButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AgregarSerie("Esta es la página para agregar una serie."));
        }
    }
}
