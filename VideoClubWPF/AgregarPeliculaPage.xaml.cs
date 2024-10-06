using System.Windows;
using System.Windows.Controls;
using VideoClubApp.Implementaciones;

namespace VideoClubWPF
{
    public partial class AgregarPeliculas : Page
    {
        private VideoClubManager videoClubManager;

        public AgregarPeliculas(VideoClubManager manager)
        {
            InitializeComponent();
            videoClubManager = manager;
        }

        private void AgregarPelicula_Click(object sender, RoutedEventArgs e)
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

                // Llama al método de VideoClubManager para agregar la película
                videoClubManager.AgregarPelicula(titulo, actorPrincipal, director, genero, duracion, cantidadStock, precioAlquiler);
                MessageBox.Show("Película agregada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la película: {ex.Message}");
            }
        }
    }
}
