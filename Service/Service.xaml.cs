using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Microsoft.Win32;

namespace Service
{
    /// <summary>
    /// Логика взаимодействия для Service.xaml
    /// </summary>
    public partial class Service : Window
    {
        Entities1 ServiceTable;
        public Service()
        {
            ServiceTable = new Entities1();
            InitializeComponent();
            this.DataContext = ServiceTable;
            ListService.ItemsSource = ServiceTable.ServiceCenter.ToList();
        }

        private void bnt_Back(object sender, RoutedEventArgs e)
        {
            MainWindow MN = new MainWindow();
            MN.Show();
            Close();
        }

        private void btn_Edit(object sender, RoutedEventArgs e)
        {
            Button reda = sender as Button;
            var reda1 = reda.DataContext as ServiceCenter;
            OpenFileDialog das = new OpenFileDialog();
            das.Title = "Выберите изображение";
            das.Filter = "All supported graphics|*.jpeg;*.jpg;*.png|" + " JPEG(*.jpeg;*.jpg)|*.jpeg;*.jpg|" +
            "Portable Network Graphic (*.png)|*.png";
            if (das.ShowDialog() == true)
            {
                reda1.Photo = new Photo { PhotoPath = das.FileName };
            }
            var reda2 = new AddService(ServiceTable, reda1);
            reda2.ShowDialog();
        }

        private void btn_Add(object sender, RoutedEventArgs e)
        {
            var NewDob = new ServiceCenter();
            ServiceTable.ServiceCenter.Add(NewDob);
            OpenFileDialog das = new OpenFileDialog();
            das.Title = "Выберите изображение";
            das.Filter = "All supported graphics|*.jpeg;*.jpg;*.png|" + " JPEG(*.jpeg;*.jpg)|*.jpeg;*.jpg|" +
            "Portable Network Graphic (*.png)|*.png";
            if (das.ShowDialog() == true)
            {
                NewDob.Photo = new Photo { PhotoPath = das.FileName };
            }
            var NewDob1 = new AddService(ServiceTable, NewDob);
            NewDob1.ShowDialog();
        }

        private void btn_Refresh(object sender, RoutedEventArgs e)
        {
            //CollectionViewSource.GetDefaultView(ListService.ItemsSource).Refresh();
            ListService.ItemsSource = ServiceTable.ServiceCenter.ToList();
        }
    }
}
