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
    /// Logika interakcji dla klasy Wypożyczenia.xaml
    /// </summary>
    public partial class Wypożyczenia : Page
    {
      


        public Wypożyczenia()
        {
            InitializeComponent();
            LoadGrid();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=WypozyczalniaRowerow;Integrated Security=True");

        public void clearData()
        {
            datawypożyczenia_txt.Clear();
            cena_txt.Clear();
            dataoddania_txt.Clear();
          

        }

        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Wypożyczenie", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            datagrid4.ItemsSource = dt.DefaultView;
        }
        private void ClearDataBtn4_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }
        public bool isValid()
        {
            if (datawypożyczenia_txt.Text == String.Empty)
            {
                MessageBox.Show("Pesel wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (cena_txt.Text == String.Empty)
            {
                MessageBox.Show(" wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (dataoddania_txt.Text == String.Empty)
            {
                MessageBox.Show("wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        
            return true;

        }
        private void InsertBtn4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Pracownik VALUES (@Pesel,@NazwiskoPracownik,@ImięPracownik,@Stanowisko,@NrTelefonu)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Pesel", datawypożyczenia_txt.Text);
                    cmd.Parameters.AddWithValue("@NazwiskoPracownik", cena_txt.Text);
                    cmd.Parameters.AddWithValue("@ImięPracownik", dataoddania_txt.Text);
                   
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

        private void DeleteBtn4_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Pracownik where PracownikId = " + search_txt4.Text + " ", con);
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

        private void UpdateBtn4_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Pracownik set Pesel = '" + datawypożyczenia_txt.Text + "', NazwiskoPracownik = '" + cena_txt.Text + "',ImięPracownik = '" + dataoddania_txt.Text + "'" + search_txt4.Text + "'", con);
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

