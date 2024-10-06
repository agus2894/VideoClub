using System.Windows;
using VideoCLubWPF;
using VideoClubApp;
namespace VideoClubWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AgregarPelicula_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AgregarPelicula());
        }

        private void ListarPelicula_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListarPeliculas());
        }

        private void AgregarSerie_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AgregarSerie());
        }

        private void ListarSerie_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListarSeries());
        }
    }
}
