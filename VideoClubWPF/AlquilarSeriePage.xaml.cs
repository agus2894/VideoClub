using System.Windows.Controls;

namespace VideoClubWPF
{
    public partial class AlquilarSerie : Page
    {
        public string Message { get; set; }

        public AlquilarSerie(string message)
        {
            InitializeComponent();
            Message = message;
            DataContext = this; // Establece el contexto de datos
        }
    }
}
