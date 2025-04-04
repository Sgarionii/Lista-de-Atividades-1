using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioDois.xaml
    /// </summary>
    public partial class ExercicioDois : Window
    {
        public ExercicioDois()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                MessageBox.Show("Temperatura em Fahrenheit: " + fahrenheit.ToString("F2"));
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor numérico válido.");
            }
        }
    }
}
