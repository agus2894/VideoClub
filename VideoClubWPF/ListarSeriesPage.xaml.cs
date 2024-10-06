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
            CargarSeries();
        }

        private void CargarSeries()
        {
            var series = videoClubManager.ObtenerSeries(); // Obtiene la lista de series desde el manager
            SeriesListBox.ItemsSource = series; // Enlaza la lista de series con el control ListBox
        }
    }
}
