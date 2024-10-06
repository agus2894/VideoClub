using System.Windows.Controls;

namespace VideoClubWPF
{
    public partial class AlquilarPelicula : Page
    {
        public string Message { get; set; }

        public AlquilarPelicula(string message)
        {
            InitializeComponent();
            Message = message;
            DataContext = this; // Establece el contexto de datos
        }
    }
}
