using System.Windows;
using VideoClubApp.Implementaciones;
namespace VideoClubApp
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
            if (string.IsNullOrWhiteSpace(TituloTextBox.Text) ||
                string.IsNullOrWhiteSpace(ActorPrincipalTextBox.Text) ||
                string.IsNullOrWhiteSpace(DirectorTextBox.Text) ||
                string.IsNullOrWhiteSpace(GeneroTextBox.Text) ||
                string.IsNullOrWhiteSpace(DuracionTextBox.Text) ||
                string.IsNullOrWhiteSpace(StockTextBox.Text) ||
                string.IsNullOrWhiteSpace(PrecioTextBox.Text) ||
                FechaIngresoPicker.SelectedDate == null ||
                string.IsNullOrWhiteSpace(EpisodiosTextBox.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                DateTime fechaIngreso = FechaIngresoPicker.SelectedDate.Value;
                int duracion = int.Parse(DuracionTextBox.Text);
                int stock = int.Parse(StockTextBox.Text);
                decimal precio = decimal.Parse(PrecioTextBox.Text);
                int episodios = int.Parse(EpisodiosTextBox.Text);

                Serie nuevaSerie = new Serie
                {
                    Titulo = TituloTextBox.Text,
                    ActorPrincipal = ActorPrincipalTextBox.Text,
                    Director = DirectorTextBox.Text,
                    Genero = GeneroTextBox.Text,
                    Duracion = duracion,
                    CantidadStock = stock,
                    PrecioAlquiler = precio,
                    FechaIngreso = fechaIngreso,
                    NumeroEpisodios = episodios
                };

                videoClubManager.AgregarSerie(nuevaSerie);
                videoClubManager.GuardarDatosEnArchivo(); // Guarda los cambios

                MessageBox.Show("Serie agregada exitosamente.");
                Close(); // Cierra la ventana después de agregar
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos para duración, cantidad de stock, precio y episodios.");
            }
        }
    }
}
