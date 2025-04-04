using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioTres.xaml
    /// </summary>
    public partial class ExercicioTres : Window
    {
        public ExercicioTres()
        {
            InitializeComponent();
        }

        private void btnCalcularDias_Click(object sender, RoutedEventArgs e)
        {
            if (dpNascimento.SelectedDate.HasValue)
            {
                DateTime dataNascimento = dpNascimento.SelectedDate.Value;
                DateTime hoje = DateTime.Today;
                DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);
                if (proximoAniversario < hoje)
                    proximoAniversario = proximoAniversario.AddYears(1);

                int diasRestantes = (proximoAniversario - hoje).Days;
                MessageBox.Show("Faltam " + diasRestantes + " dias para o seu próximo aniversário.");
            }
            else
            {
                MessageBox.Show("Selecione sua data de nascimento.");
            }
        }
    }
}
