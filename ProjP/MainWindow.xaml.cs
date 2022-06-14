using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Configuration;
using ProjP.Views;
using ProjP.ViewModels;
using ProjP.Models;
using System.Data;


namespace ProjP
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
      

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonLogout_Click(object sender, RoutedEventArgs e)
        {
           Application.Current.Shutdown();
        }

        private void KlienciButton_Click(object sender, RoutedEventArgs e)
        {
            ClientView client = new ClientView()
            {
                DataContext = new ClientViewModel()
            };
            Main.Content = client;

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
        Main.Content = new HomeP();
        }

        private void WypożyczeniaButton_Click(object sender, RoutedEventArgs e)
        {
            RentalView rental = new RentalView()
            {
                DataContext = new RentalViewModel()
            };
            Main.Content = rental;
        }

        private void FakturyButton_Click(object sender, RoutedEventArgs e)
        {
            InvoiceView invoice = new InvoiceView()
            {
                DataContext = new InvoiceViewModel()
            };
            Main.Content = invoice;
        }

        private void RoweryButton_Click(object sender, RoutedEventArgs e)
        {
            BikeView bike = new BikeView()
            {
                DataContext = new BikeViewModel()
            };
            Main.Content = bike;
        }

        private void PracownicyButton_Click(object sender, RoutedEventArgs e)
        {

            EmployeeView employee = new EmployeeView()
            {
                DataContext = new EmployeeViewModel()
            };
            Main.Content = employee;
        }

        private void TextBlock_ColorChanged(object sender, RoutedPropertyChangedEventArgs<System.Windows.Media.Color> e)
        {

        }
    }
}
