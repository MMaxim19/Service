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

namespace Service
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Autoservice.FontFamily = new System.Windows.Media.FontFamily("Arial");
        }

        private void btn_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void bntClients(object sender, RoutedEventArgs e)
        {
            Clients clients = new Clients();
            clients.Show();
            Close();
        }

        private void bntService(object sender, RoutedEventArgs e)
        {
            Service SC = new Service();
            SC.Show();
            Close();
        }

        private void btnServiceClient(object sender, RoutedEventArgs e)
        {
            ServiceClient serviceClient = new ServiceClient();
            serviceClient.Show();
            Close();
        }
    }
}
