using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioOito.xaml
    /// </summary>
    public partial class ExercicioOito : Window
    {
        public ExercicioOito()
        {
            InitializeComponent();
        }

        private void btnVerificarDia_Click(object sender, RoutedEventArgs e)
        {
            if (dpData.SelectedDate.HasValue)
            {
                DateTime data = dpData.SelectedDate.Value;
                MessageBox.Show("Dia da semana: " + data.DayOfWeek);
            }
            else
            {
                MessageBox.Show("Selecione uma data.");
            }
        }
    }
}
