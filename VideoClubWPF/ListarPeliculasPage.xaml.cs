using System.Windows;
using System.Windows.Controls;
using VideoClubApp.Implementaciones; // Asegúrate de incluir el namespace correcto

namespace VideoClubWPF
{
    public partial class ListarPeliculas : Page
    {
        private VideoClubManager videoClubManager;

        public ListarPeliculas()
        {
            InitializeComponent();
            this.videoClubManager = new VideoClubManager(); // Instancia de VideoClubManager
            CargarPeliculas();
        }

        public ListarPeliculas(VideoClubManager videoClubManager)
        {
            this.videoClubManager = videoClubManager;
        }

        private void CargarPeliculas()
        {
            var peliculas = videoClubManager.ObtenerPeliculas(); // Obtiene la lista de películas
            if (peliculas != null && peliculas.Count > 0)
            {
                foreach (var pelicula in peliculas)
                {
                    listBoxPeliculas.Items.Add(pelicula.Titulo); // Agrega el título de la película al ListBox
                }
            }
            else
            {
                MessageBox.Show("No hay películas disponibles.");
            }
        }
    }
}
