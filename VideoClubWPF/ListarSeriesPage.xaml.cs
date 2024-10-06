using System.Windows.Controls;

namespace VideoClubWPF
{
    public partial class ListarSeries : Page
    {
        public string Message { get; set; }

        public ListarSeries(string message)
        {
            InitializeComponent();
            Message = message;
            DataContext = this; // Establece el contexto de datos
        }
    }
}
