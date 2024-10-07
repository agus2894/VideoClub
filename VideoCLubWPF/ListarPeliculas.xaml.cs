using System.Windows;
using System.Windows.Controls;
using VideoClubApp.Implementaciones;
using VideoClubWPF;
namespace VideoClubWPF
{
    public partial class ListarPeliculasPage : Page
    {
        private VideoClubManager videoClubManager;

        public ListarPeliculasPage()
        {
            InitializeComponent();
            videoClubManager = new VideoClubManager();  // Inicializa la instancia de VideoClubManager
        }

        private void CargarPeliculas_Click(object sender, RoutedEventArgs e)
        {
            // Limpiar el ListBox antes de cargar las películas
            PeliculasListBox.Items.Clear();

            // Llama al método ListarPeliculas para obtener la lista
            var peliculas = videoClubManager.ListarPeliculas();

            // Agrega cada película al ListBox
            foreach (var pelicula in peliculas)
            {
                PeliculasListBox.Items.Add($"{pelicula.Titulo} - {pelicula.ActorPrincipal} - Stock: {pelicula.CantidadStock}");
            }

            // En caso de que no haya películas
            if (peliculas.Count == 0)
            {
                PeliculasListBox.Items.Add("No hay películas disponibles.");
            }
        }
    }
}
