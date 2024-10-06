using System.Windows.Controls;

namespace VideoClubWPF
{
    public partial class ListarPeliculas : Page
    {
        public string Message { get; set; }

        public ListarPeliculas(string message)
        {
            InitializeComponent();
            Message = message;
            DataContext = this; // Establece el contexto de datos
        }
    }
}
