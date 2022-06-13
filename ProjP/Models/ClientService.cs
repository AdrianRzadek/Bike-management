using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Models
{
    public class ClientService
    {

        SqlConnection ObjSqlConnection = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=WypozyczalniaRowerow;Integrated Security=True");
        SqlCommand ObjSqlCommand = new SqlCommand();


        public ClientService()
        {
            ObjSqlCommand.Connection = ObjSqlConnection;
            ObjSqlCommand.CommandType = CommandType.StoredProcedure;

        }


        public List<ClientDTO> GetAll()
        {
            List<ClientDTO> ObjClientList = new List<ClientDTO>();
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_SelectAllClients";
                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    ClientDTO ObjClient = null;
                    while (ObjSqlDataReader.Read())
                    {
                        ObjClient = new ClientDTO();
                        ObjClient.KlientId = ObjSqlDataReader.GetInt32(0);
                        ObjClient.Pesel = ObjSqlDataReader.GetString(1);
                        ObjClient.Nazwisko = ObjSqlDataReader.GetString(2);
                        ObjClient.Imię = ObjSqlDataReader.GetString(3);
                        ObjClient.NrTelefon = ObjSqlDataReader.GetString(4);

                        ObjClientList.Add(ObjClient);
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
            return ObjClientList;
        }
        public bool Add(ClientDTO objNewClient)
        {
            bool IsAdded = false;
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_InsertClient";
               ObjSqlCommand.Parameters.AddWithValue("@KlientId", objNewClient.KlientId);
                ObjSqlCommand.Parameters.AddWithValue("@Pesel", objNewClient.Pesel);
                ObjSqlCommand.Parameters.AddWithValue("@Nazwisko", objNewClient.Nazwisko);
                ObjSqlCommand.Parameters.AddWithValue("@Imię", objNewClient.Imię);
                ObjSqlCommand.Parameters.AddWithValue("@NrTelefon", objNewClient.NrTelefon);
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

        public bool Update(ClientDTO objClientToUpdate)
        {
            bool IsUpdated = false;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_UpdateClient";
                ObjSqlCommand.Parameters.AddWithValue("@KlientId", objClientToUpdate.KlientId);
                ObjSqlCommand.Parameters.AddWithValue("@Pesel", objClientToUpdate.Pesel);
                ObjSqlCommand.Parameters.AddWithValue("@Nazwisko", objClientToUpdate.Nazwisko);
                ObjSqlCommand.Parameters.AddWithValue("@Imię", objClientToUpdate.Imię);
                ObjSqlCommand.Parameters.AddWithValue("@NrTelefon", objClientToUpdate.NrTelefon);
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

        public bool Delete(int klientid)
        {
            bool IsDeleted = false;
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_DeleteClient";
                ObjSqlCommand.Parameters.AddWithValue("@KlientId", klientid);

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


        public ClientDTO Search(int klientid)
        {
            ClientDTO ObjClient = null;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_SelectClientById";
                ObjSqlCommand.Parameters.AddWithValue("@KlientId", klientid);

                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {

                    ObjSqlDataReader.Read();
                    ObjClient = new ClientDTO();
                   
                    ObjClient.KlientId = ObjSqlDataReader.GetInt32(0);
                    ObjClient.Pesel = ObjSqlDataReader.GetString(1);
                    ObjClient.Nazwisko = ObjSqlDataReader.GetString(2);
                    ObjClient.Imię = ObjSqlDataReader.GetString(3);
                    ObjClient.NrTelefon = ObjSqlDataReader.GetString(4);
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
            return ObjClient;

        }

       
    }
}
