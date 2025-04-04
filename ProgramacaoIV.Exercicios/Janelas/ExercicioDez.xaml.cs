using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioDez.xaml
    /// </summary>
    public partial class ExercicioDez : Window
    {
        public ExercicioDez()
        {
            InitializeComponent();
        }

        private Random random = new Random();

        private void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            int numero = random.Next(1, 7);
            if (numero == 6)
            {
                MessageBox.Show("Você ganhou!");
            }
            else
            {
                MessageBox.Show("Tente novamente! (Número sorteado: " + numero + ")");
            }
        }
    }
}
