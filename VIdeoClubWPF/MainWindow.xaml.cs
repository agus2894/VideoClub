using System.Windows;

namespace VideoClubWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPagina1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pagina1());
        }

        private void btnPagina2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pagina2());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
