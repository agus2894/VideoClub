using System;
using System.Windows;
using VideoClubApp.Implementaciones;

namespace VideoCluWPF
{
    public partial class AgregarSerie : Window
    {
        private VideoClubManager videoClubManager;

        public AgregarSerie(VideoClubManager manager)
        {
            InitializeComponent();
            videoClubManager = manager;
        }

        private void AgregarSerieButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string titulo = TituloTextBox.Text;
                string actorPrincipal = ActorPrincipalTextBox.Text;
                string director = DirectorTextBox.Text;
                string genero = GeneroTextBox.Text;
                int duracion = int.Parse(DuracionTextBox.Text);
                int cantidadStock = int.Parse(StockTextBox.Text);
                double precioAlquiler = double.Parse(PrecioTextBox.Text);
                DateTime fechaIngreso = FechaIngresoPicker.SelectedDate.GetValueOrDefault(); // Asegúrate de que la fecha esté seleccionada
                int numeroEpisodios = int.Parse(EpisodiosTextBox.Text);

                // Llama al método de VideoClubManager para agregar la serie
                videoClubManager.AgregarSerie(titulo, actorPrincipal, director, genero, duracion, cantidadStock, precioAlquiler, fechaIngreso, numeroEpisodios);
                MessageBox.Show("Serie agregada exitosamente.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error en los datos ingresados: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la serie: {ex.Message}");
            }
        }
    }
}
