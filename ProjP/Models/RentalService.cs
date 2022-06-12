using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Models
{
    public class RentalService
    {

        SqlConnection ObjSqlConnection = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=WypozyczalniaRowerow;Integrated Security=True");
        SqlCommand ObjSqlCommand = new SqlCommand();


        public RentalService()
        {
            ObjSqlCommand.Connection = ObjSqlConnection;
            ObjSqlCommand.CommandType = CommandType.StoredProcedure;

        }


        public List<RentalDTO> GetAll()
        {
            List<RentalDTO> ObjRentalList = new List<RentalDTO>();
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_SelectAllEmployees";
                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    RentalDTO ObjRental = null;
                    while (ObjSqlDataReader.Read())
                    {
                        ObjRental = new RentalDTO();
                        ObjRental.WypożyczenieId = ObjSqlDataReader.GetInt32(0);
                        ObjRental.DataWypożyczenia = ObjSqlDataReader.GetDateTime(1);
                        ObjRental.DataOddania = ObjSqlDataReader.GetDateTime(2);
                        ObjRental.Cena = ObjSqlDataReader.GetDecimal(3);
                        ObjRental.FakturaId = ObjSqlDataReader.GetInt32(4);
                        ObjRental.PracownikId = ObjSqlDataReader.GetInt32(5);


                        ObjRentalList.Add(ObjRental);
                    }
                }
                ObjSqlDataReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ObjSqlConnection.Close();
            }
            return ObjRentalList;
        }
        public bool Add(RentalDTO objNewRental)
        {
            bool IsAdded = false;
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_InsertEmployee";
                ObjSqlCommand.Parameters.AddWithValue("@WypożyczenieId", objNewRental.WypożyczenieId);
                ObjSqlCommand.Parameters.AddWithValue("@DataWypożyczenia", objNewRental.DataWypożyczenia);
                ObjSqlCommand.Parameters.AddWithValue("@DataOddania", objNewRental.DataOddania);
                ObjSqlCommand.Parameters.AddWithValue("@Cena", objNewRental.Cena);
                ObjSqlCommand.Parameters.AddWithValue("@FakturaId", objNewRental.FakturaId);
                ObjSqlCommand.Parameters.AddWithValue("@PracownikId", objNewRental.PracownikId);
                ObjSqlConnection.Open();
                int NoOfRowsAffected = ObjSqlCommand.ExecuteNonQuery();
                IsAdded = NoOfRowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            finally
            {
                ObjSqlConnection.Close();
            }


            return IsAdded;
        }

        public bool Update(RentalDTO objRentalToUpdate)
        {
            bool IsUpdated = false;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_UpdateEmployee";
                ObjSqlCommand.Parameters.AddWithValue("@WypożyczenieId", objRentalToUpdate.WypożyczenieId);
                ObjSqlCommand.Parameters.AddWithValue("@DataWypożyczenia", objRentalToUpdate.DataWypożyczenia);
                ObjSqlCommand.Parameters.AddWithValue("@DataOddania", objRentalToUpdate.DataOddania);
                ObjSqlCommand.Parameters.AddWithValue("@Cena", objRentalToUpdate.Cena);
                ObjSqlCommand.Parameters.AddWithValue("@FakturaId", objRentalToUpdate.FakturaId);
                ObjSqlCommand.Parameters.AddWithValue("@PracownikId", objRentalToUpdate.PracownikId);
                ObjSqlConnection.Open();
                int NoOfRowsAffected = ObjSqlCommand.ExecuteNonQuery();
                IsUpdated = NoOfRowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            finally
            {
                ObjSqlConnection.Close();
            }

            return IsUpdated;
        }

        public bool Delete(int wypożyczenieid)
        {
            bool IsDeleted = false;
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_DeleteEmployee";
                ObjSqlCommand.Parameters.AddWithValue("@WypożyczenieId", wypożyczenieid);

                ObjSqlConnection.Open();
                int NoOfRowsAffected = ObjSqlCommand.ExecuteNonQuery();
                IsDeleted = NoOfRowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            finally
            {
                ObjSqlConnection.Close();
            }
            return IsDeleted;
        }


        public RentalDTO Search(int wypożyczenieid)
        {
            RentalDTO ObjRental = null;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_SelectEmployeeById";
                ObjSqlCommand.Parameters.AddWithValue("@WypożyczenieId", wypożyczenieid);

                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {

                    ObjSqlDataReader.Read();
                    ObjRental = new RentalDTO();
                    ObjRental.WypożyczenieId = ObjSqlDataReader.GetInt32(0);
                    ObjRental.DataWypożyczenia = ObjSqlDataReader.GetDateTime(1);
                    ObjRental.DataOddania = ObjSqlDataReader.GetDateTime(2);
                    ObjRental.Cena = ObjSqlDataReader.GetDecimal(3);
                    ObjRental.FakturaId = ObjSqlDataReader.GetInt32(4);
                    ObjRental.PracownikId = ObjSqlDataReader.GetInt32(5);
                }
                ObjSqlDataReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ObjSqlConnection.Close();
            }
            return ObjRental;

        }
    }
}
