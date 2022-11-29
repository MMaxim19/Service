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
using System.Windows.Navigation;

namespace Service
{
    /// <summary>
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        Entities1 DataBase;
        public Clients()
        {
            DataBase = new Entities1();
            InitializeComponent();
            ListClient.ItemsSource = DataBase.Client.ToList();
        }

        private void bnt_Back(object sender, RoutedEventArgs e)
        {
            MainWindow MN = new MainWindow();
            MN.Show();
            Close();
        }
    }
}
