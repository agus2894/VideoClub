using System.Windows;

namespace VideoClubWPF
{
    public partial class ListarPeliculas : Window
    {
        public ListarPeliculas()
        {
            InitializeComponent();
            // Cargar lista de películas (esto lo puedes reemplazar con los datos reales)
            PeliculasListBox.Items.Add("Película 1");
            PeliculasListBox.Items.Add("Película 2");
            PeliculasListBox.Items.Add("Película 3");
        }
    }
}
