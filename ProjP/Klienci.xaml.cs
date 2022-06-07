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
using ProjP.Data;

namespace ProjP
{
    /// <summary>
    /// Logika interakcji dla klasy Klienci.xaml
    /// </summary>
    public partial class Klienci : Page
    {
        public Klienci()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;
        Database=WypozyczalniaRowerow;Trusted_Connection=true");
        SqlCommand cmd = new SqlCommand();

        private void btnSelectklient_Click(object sender, RoutedEventArgs e)
        {
            /*
            con.Open();
            SqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT Imię, Nazwisko FROM Klient";

            txtBox1.Text = command.ExecuteScalar() as string;
            con.Close();*/


            con.Open();
           
            cmd = new SqlCommand("SELECT Imię FROM Klient;",con);
            txtBox1.Text = cmd.ExecuteScalar().ToString();
            cmd = new SqlCommand("SELECT Nazwisko FROM Klient;",con);
            txtBox2.Text = cmd.ExecuteScalar().ToString();
            cmd = new SqlCommand("SELECT PeselKey FROM Klient;", con);
            txtBox3.Text = cmd.ExecuteScalar().ToString();
            cmd = new SqlCommand("SELECT NrTelefon FROM Klient;", con);
            txtBox4.Text = cmd.ExecuteScalar().ToString();
            con.Close();



        }

        private void btnAddKlient_Click(object sender, RoutedEventArgs e)
        {


            con.Open();

            cmd = new SqlCommand("SELECT Imię FROM Klient;", con);
            txtBox1.Text = cmd.ExecuteScalar().ToString();
            cmd = new SqlCommand("SELECT Nazwisko FROM Klient;", con);
            txtBox2.Text = cmd.ExecuteScalar().ToString();
            cmd = new SqlCommand("SELECT PeselKey FROM Klient;", con);
            txtBox3.Text = cmd.ExecuteScalar().ToString();
            cmd = new SqlCommand("SELECT NrTelefon FROM Klient;", con);
            txtBox4.Text = cmd.ExecuteScalar().ToString();
            con.Close();


        }
    }
}
