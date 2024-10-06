using System.Windows.Controls;
using VideoClubApp.Implementaciones;

namespace VideoClubWPF
{
    public partial class ListarSeries : Page
    {
        private VideoClubManager videoClubManager;

        public ListarSeries(VideoClubManager manager)
        {
            InitializeComponent();
            videoClubManager = manager;

            // Cargar las series al iniciar la página
            CargarSeries();
        }

        private void CargarSeries()
        {
            var series = videoClubManager.ListarSeries();
            SeriesListBox.ItemsSource = series;
        }
    }
}
