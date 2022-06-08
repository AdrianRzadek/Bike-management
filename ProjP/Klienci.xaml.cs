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
    /// Logika interakcji dla klasy Klienci.xaml
    /// </summary>
    public partial class Klienci : Page
    {
        public Klienci()
        {
            InitializeComponent();
            LoadGrid();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=WypozyczalniaRowerow;Integrated Security=True");

        public void clearData()
        {
            
            nazwisko_txt2.Clear();
            imię_txt2.Clear();
            telefon_txt2.Clear();


        }

        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pracownik", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            datagrid2.ItemsSource = dt.DefaultView;
        }
        private void ClearDataBtn2_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }
        public bool isValid()
        {
            if (nazwisko_txt2.Text == String.Empty)
            {
                MessageBox.Show("Pesel wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (imię_txt2.Text == String.Empty)
            {
                MessageBox.Show(" wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (telefon_txt2.Text == String.Empty)
            {
                MessageBox.Show("wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        
            return true;

        }
        private void InsertBtn2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Pracownik VALUES (@Pesel,@NazwiskoPracownik,@ImięPracownik,@Stanowisko,@NrTelefonu)", con);
                    cmd.CommandType = CommandType.Text;
                    
                    cmd.Parameters.AddWithValue("@Nazwisko", nazwisko_txt2.Text);
                    cmd.Parameters.AddWithValue("@Imię", imię_txt2.Text);
                    cmd.Parameters.AddWithValue("@NrTelefon", telefon_txt2.Text);

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

        private void DeleteBtn2_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Pracownik where PracownikId = " + search_txt2.Text + " ", con);
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

        private void UpdateBtn2_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Pracownik set  Nazwisko = '" + nazwisko_txt2.Text + "',Imię = '" + imię_txt2.Text + "', NrTelefon ='" + telefon_txt2.Text + "' WHERE PeselKey = '" + search_txt2.Text + "'", con);
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
