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
