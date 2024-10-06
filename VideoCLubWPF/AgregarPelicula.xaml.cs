using System.Windows;

namespace VideoClubWPF
{
    public partial class AgregarPelicula : Window
    {
        public AgregarPelicula()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar el código para guardar la película utilizando los valores de los TextBox
            MessageBox.Show("Película agregada: " + TituloTextBox.Text);
        }
    }
}
