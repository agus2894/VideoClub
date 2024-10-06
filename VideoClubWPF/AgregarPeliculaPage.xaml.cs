using System.Windows.Controls;

namespace VideoClubWPF
{
    public partial class AgregarPelicula : Page
    {
        public string Message { get; set; }

        public AgregarPelicula(string message)
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
