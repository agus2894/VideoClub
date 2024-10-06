using System.Windows;

namespace VideoClubWPF
{
    public partial class ListarSeries : Window
    {
        public ListarSeries()
        {
            InitializeComponent();
            // Cargar lista de series (esto lo puedes reemplazar con los datos reales)
            SeriesListBox.Items.Add("Serie 1");
            SeriesListBox.Items.Add("Serie 2");
            SeriesListBox.Items.Add("Serie 3");
        }
    }
}
