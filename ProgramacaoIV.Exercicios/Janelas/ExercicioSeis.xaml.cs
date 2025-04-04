using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExerciciSeis.xaml
    /// </summary>
    public partial class ExercicioSeis : Window
    {
        public ExercicioSeis()
        {
            InitializeComponent();
        }

        private int contador = 0;

        private void btnContador_Click(object sender, RoutedEventArgs e)
        {
            contador++;
            MessageBox.Show("Contador: " + contador);
        }
    }
}
