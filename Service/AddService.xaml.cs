using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AddService.xaml
    /// </summary>
    public partial class AddService : Window
    {
        Entities1 SC;
        public AddService(Entities1 context1, ServiceCenter service)
        {
            InitializeComponent();
            this.SC = context1;
            this.DataContext = service;
        }

        private void btnAdd(object sender, RoutedEventArgs e)
        {
            SC.SaveChanges();
            this.Close();
        }

        private void btnBack(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
