using System.Windows;

namespace VideoClubWPF
{
    public partial class AgregarSerie : Window
    {
        public AgregarSerie()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes agregar el código para guardar la serie utilizando los valores de los TextBox
            MessageBox.Show("Serie agregada: " + TituloTextBox.Text);
        }
    }
}
