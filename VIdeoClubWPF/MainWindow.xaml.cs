using System.Windows;
using VideoClubApp.Implementaciones; // Asegúrate de incluir este namespace
using VideoClubWPF;
namespace VideoClubApp
{
    public partial class MainWindow : Window
    {
        private VideoClubManager videoClubManager;

        public MainWindow()
        {
            InitializeComponent();
            videoClubManager = new VideoClubManager(); // Inicializa tu manager
        }

        private void ListarPeliculasButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListarPeliculas(videoClubManager)); // Carga la página ListarPeliculas
        }

        private void ListarSeriesButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListarSeries(videoClubManager)); // Carga la página ListarSeries
        }

        private void AlquilarPeliculaButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AlquilarPelicula(videoClubManager)); // Carga la página AlquilarPelicula
        }

        private void AlquilarSerieButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AlquilarSerie(videoClubManager)); // Carga la página AlquilarSerie
        }

        private void DevolverPeliculaButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DevolverPelicula(videoClubManager)); // Carga la página DevolverPelicula
        }

        private void DevolverSerieButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DevolverSerie(videoClubManager)); // Carga la página DevolverSerie
        }

        private void AgregarPeliculaButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AgregarPelicula(videoClubManager)); // Carga la página AgregarPelicula
        }

        private void AgregarSerieButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AgregarSerie(videoClubManager)); // Carga la página AgregarSerie
        }
    }
}
