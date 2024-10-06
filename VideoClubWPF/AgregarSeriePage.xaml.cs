using System.Windows;
using System.Windows.Controls;
using VideoClubApp.Implementaciones;

namespace VideoClubWPF
{
    public partial class AgregarSeries : Page
    {
        private VideoClubManager videoClubManager;

        public AgregarSeries(VideoClubManager manager)
        {
            InitializeComponent();
            videoClubManager = manager;
        }

        private void AgregarSerie_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string titulo = TituloTextBox.Text;
                string actorPrincipal = ActorPrincipalTextBox.Text;
                string director = DirectorTextBox.Text;
                string genero = GeneroTextBox.Text;
                int duracion = int.Parse(DuracionTextBox.Text);
                int cantidadStock = int.Parse(CantidadStockTextBox.Text);
                double precioAlquiler = double.Parse(PrecioAlquilerTextBox.Text);
                int numeroEpisodios = int.Parse(NumeroEpisodiosTextBox.Text);

                // Llama al método de VideoClubManager para agregar la serie
                videoClubManager.AgregarSerie(titulo, actorPrincipal, director, genero, duracion, cantidadStock, precioAlquiler, numeroEpisodios);
                MessageBox.Show("Serie agregada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la serie: {ex.Message}");
            }
        }
    }
}
