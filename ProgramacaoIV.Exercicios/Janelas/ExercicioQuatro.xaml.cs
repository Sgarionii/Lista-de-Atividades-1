using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioQuatro.xaml
    /// </summary>
    public partial class ExercicioQuatro : Window
    {
        public ExercicioQuatro()
        {
            InitializeComponent();
        }

        private void btnVerificarMaioridade_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtIdade.Text, out int idade))
            {
                string resultado = idade >= 18 ? "Maior de idade" : "Menor de idade";
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Por favor, insira uma idade válida.");
            }
        }
    }
}
