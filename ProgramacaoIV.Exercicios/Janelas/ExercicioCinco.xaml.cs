using System.Windows;
using System.ComponentModel;
using System.Reflection;

namespace ProgramacaoIV.Exercicios.Janelas
{
    /// <summary>
    /// Lógica interna para ExercicioCinco.xaml
    /// </summary>
    public partial class ExercicioCinco : Window
    {
        public ExercicioCinco()
        {
            InitializeComponent();
        }

        public enum TipoUsuario
        {
            [Description("Administrador do sistema")]
            Administrador,
            [Description("Usuário comum")]
            UsuarioComum,
            [Description("Visitante do site")]
            Visitante
        }

        private string GetEnumDescription(Enum valor)
        {
            FieldInfo fi = valor.GetType().GetField(valor.ToString());
            DescriptionAttribute[] atributos = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return (atributos != null && atributos.Length > 0) ? atributos[0].Description : valor.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbTipoUsuario.ItemsSource = Enum.GetValues(typeof(TipoUsuario));
        }

        private void btnExibirDescricao_Click(object sender, RoutedEventArgs e)
        {
            if (cbTipoUsuario.SelectedItem != null)
            {
                TipoUsuario tipo = (TipoUsuario)cbTipoUsuario.SelectedItem;
                MessageBox.Show(GetEnumDescription(tipo));
            }
            else
            {
                MessageBox.Show("Selecione um tipo de usuário.");
            }
        }
    }
}
