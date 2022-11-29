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
using System.Windows.Shapes;

namespace Service
{
    /// <summary>
    /// Логика взаимодействия для ServiceClient.xaml
    /// </summary>
    public partial class ServiceClient : Window
    {
        Entities1 SC;
        public ServiceClient()
        {
            SC = new Entities1();
            InitializeComponent();
            ServiceClientTable.ItemsSource = SC.ClientService.ToList();
        }

        private void bnt_Back(object sender, RoutedEventArgs e)
        {
            MainWindow MN = new MainWindow();
            MN.Show();
            Close();
        }
    }
}
