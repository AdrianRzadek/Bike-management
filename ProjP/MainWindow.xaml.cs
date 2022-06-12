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
            Main.Content = new ClientView();

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new HomeP();
        }

        private void WypożyczeniaButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new RentalView();
        }

        private void FakturyButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new InvoiceView();
        }

        private void RoweryButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new BikeView();
        }

        private void PracownicyButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new EmployeeView();
        }
    }
}
