using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfViewsw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            CadastroCliente cadCli = new CadastroCliente();

            //cadCli.Show();
            cadCli.ShowDialog();
        }

        private void btnEntregador_Click(object sender, RoutedEventArgs e)
        {
            CadastroEntregador cadEntregador = new CadastroEntregador();

            cadEntregador.ShowDialog();
        }

        private void btnFornecedor_Click(object sender, RoutedEventArgs e)
        {
            CadastroFornecedor cadFornecedor = new CadastroFornecedor();

            cadFornecedor.ShowDialog();
        }
    }
}
