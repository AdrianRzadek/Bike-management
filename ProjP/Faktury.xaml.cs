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
using System.Data.SqlClient;
using ProjP.Data;
using System.Data;

namespace ProjP
{
    /// <summary>
    /// Logika interakcji dla klasy Faktury.xaml
    /// </summary>
    public partial class Faktury : Page
    {
        public Faktury()
        {
            InitializeComponent();
            LoadGrid();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=WypozyczalniaRowerow;Integrated Security=True");

        public void clearData()
        {
            nip_txt.Clear();
           datawystawienia_txt.Clear();
            nazwa_txt.Clear();
          

        }

        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Faktura", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            datagrid1.ItemsSource = dt.DefaultView;
        }
        private void ClearDataBtn1_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }
        public bool isValid()
        {
            if (nip_txt.Text == String.Empty)
            {
                MessageBox.Show("Pesel wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (datawystawienia_txt.Text == String.Empty)
            {
                MessageBox.Show(" wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (nazwa_txt.Text == String.Empty)
            {
                MessageBox.Show("wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            
            return true;

        }
        private void InsertBtn1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Faktura VALUES (@NIP,@DataWystawienia,@Nazwa)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@NIP", nip_txt.Text);
                    cmd.Parameters.AddWithValue("@DataWystawienia", datawystawienia_txt.Text);
                    cmd.Parameters.AddWithValue("@Nazwa", nazwa_txt.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadGrid();
                    MessageBox.Show("Sukces", "Zapisano", MessageBoxButton.OK, MessageBoxImage.Information);
                    clearData();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DeleteBtn1_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Faktura where FakturakId = " + search_txt1.Text + " ", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usunięto", "usunięte", MessageBoxButton.OK, MessageBoxImage.Information);
                con.Close();
                clearData();
                LoadGrid();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("nie usunięto" + ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void UpdateBtn1_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Faktura set Pesel = '" + nip_txt.Text + "', NazwiskoPracownik = '" + datawystawienia_txt.Text + "',ImięPracownik = '" + nazwa_txt.Text + "'", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Zaktualizowane pomyślnie", "zaktualizowane", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                clearData();
                LoadGrid();
            }
        }
    }




}

