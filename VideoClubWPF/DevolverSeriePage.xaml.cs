using System.Windows;
using System.Windows.Controls;
using VideoClubApp.Implementaciones;

namespace VideoClubWPF
{
    public partial class DevolverSerie : Page
    {
        private VideoClubManager videoClubManager;

        public DevolverSerie(VideoClubManager manager)
        {
            InitializeComponent();
            videoClubManager = manager;
            CargarSeries(); // Cargar las series disponibles
        }

        // Cargar las series en el ComboBox
        private void CargarSeries()
        {
            var series = videoClubManager.ObtenerSeries();
            SeriesComboBox.ItemsSource = series;
            SeriesComboBox.DisplayMemberPath = "Titulo"; // Mostrar solo el título de las series
        }

        // Evento al hacer clic en el botón "Devolver"
        private void DevolverButton_Click(object sender, RoutedEventArgs e)
        {
            var serieSeleccionada = SeriesComboBox.SelectedItem as Serie;
            if (serieSeleccionada != null)
            {
                bool exito = videoClubManager.DevolverSerie(serieSeleccionada.Titulo);
                if (exito)
                {
                    MessageBox.Show("Serie devuelta exitosamente.");
                    CargarSeries(); // Refrescar la lista después de devolver
                }
                else
                {
                    MessageBox.Show("Error al devolver la serie.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una serie.");
            }
        }
    }
}
