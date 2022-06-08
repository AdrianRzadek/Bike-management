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
    /// Logika interakcji dla klasy Rowery.xaml
    /// </summary>
    public partial class Rowery : Page
    {
        public Rowery()
        {
            InitializeComponent();
            LoadGrid();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=WypozyczalniaRowerow;Integrated Security=True");

        public void clearData()
        {
            kolor_txt.Clear();
            rowertype_txt.Clear();
            rozmiarramy_txt.Clear();
            rozmiaropon_txt.Clear();
            biegi_txt.Clear();
            search_txt3.Clear();

        }

        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Rower", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            datagrid3.ItemsSource = dt.DefaultView;
        }
        private void ClearDataBtn3_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }
        public bool isValid()
        {
            if (kolor_txt.Text == String.Empty)
            {
                MessageBox.Show("Pesel wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (rowertype_txt.Text == String.Empty)
            {
                MessageBox.Show(" wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (rozmiarramy_txt.Text == String.Empty)
            {
                MessageBox.Show("wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (rozmiaropon_txt.Text == String.Empty)
            {
                MessageBox.Show("wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (biegi_txt.Text == String.Empty)
            {
                MessageBox.Show("wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;

        }
        private void InsertBtn3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Pracownik VALUES (@Pesel,@NazwiskoPracownik,@ImięPracownik,@Stanowisko,@NrTelefonu)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Pesel", kolor_txt.Text);
                    cmd.Parameters.AddWithValue("@NazwiskoPracownik", rowertype_txt.Text);
                    cmd.Parameters.AddWithValue("@ImięPracownik", rozmiarramy_txt.Text);
                    cmd.Parameters.AddWithValue("@Stanowisko", rozmiaropon_txt.Text);
                    cmd.Parameters.AddWithValue("@NrTelefonu", biegi_txt.Text);
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

        private void DeleteBtn3_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Pracownik where PracownikId = " + search_txt3.Text + " ", con);
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

        private void UpdateBtn3_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Pracownik set Pesel = '" + kolor_txt.Text + "', NazwiskoPracownik = '" + rowertype_txt.Text + "',ImięPracownik = '" + rozmiarramy_txt.Text + "', Stanowisko ='" + rozmiaropon_txt.Text + "', NrTelefonu='" + biegi_txt.Text + "' WHERE PracownikId = '" + search_txt3.Text + "'", con);
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
