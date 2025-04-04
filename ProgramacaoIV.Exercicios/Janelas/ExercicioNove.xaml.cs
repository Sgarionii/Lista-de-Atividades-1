using System.Windows;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioNove.xaml
    /// </summary>
    public partial class ExercicioNove : Window
    {
        public ExercicioNove()
        {
            InitializeComponent();
        }

        private bool estado = false;

        private void btnLigaDesliga_Click(object sender, RoutedEventArgs e)
        {
            estado = !estado;
            string mensagem = estado ? "Ligado" : "Desligado";
            MessageBox.Show(mensagem);
        }
    }
}
