using System.Windows;
using System.Windows.Controls;
using VideoClubApp.Implementaciones;

namespace VideoClubWPF
{
    public partial class AlquilarSerie : Page
    {
        private VideoClubManager videoClubManager;

        public AlquilarSerie(VideoClubManager manager)
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

        // Evento al hacer clic en el botón "Alquilar"
        private void AlquilarButton_Click(object sender, RoutedEventArgs e)
        {
            var serieSeleccionada = SeriesComboBox.SelectedItem as Serie;
            if (serieSeleccionada != null)
            {
                bool exito = videoClubManager.AlquilarSerie(serieSeleccionada.Titulo);
                if (exito)
                {
                    MessageBox.Show("Serie alquilada exitosamente.");
                    CargarSeries(); // Refrescar la lista después de alquilar
                }
                else
                {
                    MessageBox.Show("No hay stock disponible para esta serie.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una serie.");
            }
        }
    }
}
