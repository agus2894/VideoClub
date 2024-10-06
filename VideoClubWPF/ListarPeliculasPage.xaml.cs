using System.Windows.Controls;
using VideoClubApp.Implementaciones;

namespace VideoClubWPF
{
    public partial class ListarPeliculas : Page
    {
        private VideoClubManager videoClubManager;

        public ListarPeliculas(VideoClubManager manager)
        {
            InitializeComponent();
            videoClubManager = manager;

            // Cargar las películas al iniciar la página
            CargarPeliculas();
        }

        private void CargarPeliculas()
        {
            var peliculas = videoClubManager.ListarPeliculas();
            PeliculasListBox.ItemsSource = peliculas;
        }
    }
}
