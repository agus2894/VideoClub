using System.Windows.Controls;

namespace VideoClubWPF
{
    public partial class DevolverSerie : Page
    {
        public string Message { get; set; }

        public DevolverSerie(string message)
        {
            InitializeComponent();
            Message = message;
            DataContext = this; // Establece el contexto de datos
        }
    }
}
