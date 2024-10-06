using System.Windows;
using VideoClubWPF;
using VideoClubApp.Implementaciones;

namespace VideoClubApp
{
    public partial class MainWindow : Window
    {
        private VideoClubManager videoClubManager;

        public MainWindow()
        {
            InitializeComponent();
            videoClubManager = new VideoClubManager(); // Inicializa el VideoClubManager
        }

        private void AgregarPeliculaButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AgregarPeliculas(videoClubManager));
        }

        private void AgregarSerieButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AgregarSeries(videoClubManager));
        }

        private void ListarPeliculasButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListarPeliculas(videoClubManager));
        }

        private void ListarSeriesButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListarSeries(videoClubManager));
        }
    }
}
