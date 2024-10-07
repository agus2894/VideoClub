using System.Windows;
using System.Windows.Controls;

namespace VideoClubWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListarPeliculas_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ListarPeliculasPage();
        }

        private void ListarSeries_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new ListarSeriesPage();
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
