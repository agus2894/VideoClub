using System.Windows;
using VideoClubApp.Implementaciones;

namespace VideoClubWPF
{
    public partial class MainWindow : Window
    {
        private VideoClubManager gestor; // Declara la variable gestor

        public MainWindow()
        {
            InitializeComponent();
            gestor = new VideoClubManager(); // Inicializa la variable gestor
        }

        private void btnListarPeliculas_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListarPeliculasPage());
        }

        private void btnListarSeries_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListarSeriesPage());
        }

        private void btnAlquilarPelicula_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AlquilarPeliculaPage());
        }

        private void btnAlquilarSerie_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AlquilarSeriePage());
        }

        private void btnDevolverPelicula_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DevolverPeliculaPage());
        }

        private void GuardarYSalir_Click(object sender, RoutedEventArgs e)
        {
            gestor.GuardarDatosEnArchivo();  // Guarda los datos
            Application.Current.Shutdown();    // Cierra la aplicación
        }

        private void btnDevolverSerie_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DevolverSeriePage());
        }

        private void btnAgregarPelicula_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AgregarPeliculaPage());
        }

        private void btnAgregarSerie_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AgregarSeriePage());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
