using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioSete.xaml
    /// </summary>
    public partial class ExercicioSete : Window
    {
        public ExercicioSete()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                cbParcelas.Items.Add(i);
            }
        }

        private void btnCalcularParcela_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtValorTotal.Text, out double valorTotal) && cbParcelas.SelectedItem != null)
            {
                int numParcelas = (int)cbParcelas.SelectedItem;
                double valorParcela = valorTotal / numParcelas;
                MessageBox.Show("Valor da Parcela: " + valorParcela.ToString("F2"));
            }
            else
            {
                MessageBox.Show("Verifique se o valor total é numérico e se você selecionou o número de parcelas.");
            }
        }
    }
}