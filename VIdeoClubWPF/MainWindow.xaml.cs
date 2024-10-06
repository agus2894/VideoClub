using System.Windows;
using System.Windows.Controls;
using VideoClubWPF; // Asegúrate de que este namespace está correctamente definido

namespace VideoClubWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Manejador para "Agregar Película"
        private void AgregarPelicula_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AgregarPelicula()); // Navega a la página AgregarPelicula
            if (MainFrame.NavigationService.CanGoBack)
            {
                MainFrame.NavigationService.RemoveBackEntry();
            }
        }

        // Manejador para "Listar Películas"
        private void ListarPeliculas_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListarPeliculas()); // Navega a la página ListarPeliculas
            if (MainFrame.NavigationService.CanGoBack)
            {
                MainFrame.NavigationService.RemoveBackEntry();
            }
        }

        // Manejador para "Agregar Serie"
        private void AgregarSerie_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AgregarSerie()); // Navega a la página AgregarSerie
            if (MainFrame.NavigationService.CanGoBack)
            {
                MainFrame.NavigationService.RemoveBackEntry();
            }
        }

        // Manejador para "Listar Series"
        private void ListarSeries_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ListarSeries()); // Navega a la página ListarSeries

            if (MainFrame.NavigationService.CanGoBack)
            {
                MainFrame.NavigationService.RemoveBackEntry();
            }
        }
    }
}