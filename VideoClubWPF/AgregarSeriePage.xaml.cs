using System.Windows.Controls;

namespace VideoClubWPF
{
    public partial class AgregarSerie : Page
    {
        public string Message { get; set; }

        public AgregarSerie(string message)
        {
            InitializeComponent();
            Message = message;
            DataContext = this; // Establece el contexto de datos
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
