using System.Windows.Controls;

namespace VideoClubWPF
{
    public partial class DevolverPelicula : Page
    {
        public string Message { get; set; }

        public DevolverPelicula(string message)
        {
            InitializeComponent();
            Message = message;
            DataContext = this; // Establece el contexto de datos
        }
    }
}
