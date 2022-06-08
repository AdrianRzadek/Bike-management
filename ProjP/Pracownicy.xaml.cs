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
    /// Logika interakcji dla klasy Pracownicy.xaml
    /// </summary>
    public partial class Pracownicy : Page
    {
        public Pracownicy()
        {
            InitializeComponent();
            LoadGrid();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=WypozyczalniaRowerow;Integrated Security=True");

        public void clearData()
        {
            pesel_txt.Clear();
            nazwisko_txt.Clear();
            imię_txt.Clear();
            stanowisko_txt.Clear();
            telefon_txt.Clear();
            search_txt.Clear();

        }

        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Pracownik", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            datagrid.ItemsSource = dt.DefaultView;
        }
        private void ClearDataBtn_Click(object sender, RoutedEventArgs e)
        {
            clearData();
        }
        public bool isValid()
        {
            if(pesel_txt.Text == String.Empty)
            {
                MessageBox.Show("Pesel wymagany","Błąd",MessageBoxButton.OK,MessageBoxImage.Error);
                return false;
            }
            if (imię_txt.Text == String.Empty)
            {
                MessageBox.Show(" wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (nazwisko_txt.Text == String.Empty)
            {
                MessageBox.Show("wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (stanowisko_txt.Text == String.Empty)
            {
                MessageBox.Show("wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (telefon_txt.Text == String.Empty)
            {
                MessageBox.Show("wymagany", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;

        }
        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (isValid())
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Pracownik VALUES (@Pesel,@NazwiskoPracownik,@ImięPracownik,@Stanowisko,@NrTelefonu)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Pesel", pesel_txt.Text);
                    cmd.Parameters.AddWithValue("@NazwiskoPracownik", nazwisko_txt.Text);
                    cmd.Parameters.AddWithValue("@ImięPracownik", imię_txt.Text);
                    cmd.Parameters.AddWithValue("@Stanowisko", stanowisko_txt.Text);
                    cmd.Parameters.AddWithValue("@NrTelefonu", telefon_txt.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LoadGrid();
                    MessageBox.Show("Sukces", "Zapisano", MessageBoxButton.OK, MessageBoxImage.Information);
                    clearData();

                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Pracownik where PracownikId = " + search_txt.Text + " ", con);
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

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Pracownik set Pesel = '" + pesel_txt.Text + "', NazwiskoPracownik = '"+nazwisko_txt.Text+"',ImięPracownik = '"+imię_txt.Text+"', Stanowisko ='"+stanowisko_txt.Text+"', NrTelefonu='"+telefon_txt.Text+"' WHERE PracownikId = '"+search_txt.Text+"'",con);
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
