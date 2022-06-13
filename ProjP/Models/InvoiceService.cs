using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Models
{
    public class InvoiceService
    {

        SqlConnection ObjSqlConnection = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=WypozyczalniaRowerow;Integrated Security=True");
        SqlCommand ObjSqlCommand = new SqlCommand();


        public InvoiceService()
        {
            ObjSqlCommand.Connection = ObjSqlConnection;
            ObjSqlCommand.CommandType = CommandType.StoredProcedure;

        }


        public List<InvoiceDTO> GetAll()
        {
            List<InvoiceDTO> ObjInvoiceList = new List<InvoiceDTO>();
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_SelectAllInvoices";
                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    InvoiceDTO ObjInvoice = null;
                    while (ObjSqlDataReader.Read())
                    {
                        ObjInvoice = new InvoiceDTO();
                     ObjInvoice.FakturaId = ObjSqlDataReader.GetInt32(0);
                        ObjInvoice.NIP = ObjSqlDataReader.GetString(1);
                        ObjInvoice.Nazwa = ObjSqlDataReader.GetString(2);
                        ObjInvoice.DataWystawienia= ObjSqlDataReader.GetDateTime(3);
                        ObjInvoiceList.Add(ObjInvoice);
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
            return ObjInvoiceList;
        }
        public bool Add(InvoiceDTO objNewInvoice)
        {
            bool IsAdded = false;
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_InsertInvoice";
              ObjSqlCommand.Parameters.AddWithValue("@FakturaId", objNewInvoice.FakturaId);
                ObjSqlCommand.Parameters.AddWithValue("@NIP", objNewInvoice.NIP);
                ObjSqlCommand.Parameters.AddWithValue("@Nazwa", objNewInvoice.Nazwa);
                ObjSqlCommand.Parameters.AddWithValue("@DataWystawienia", objNewInvoice.DataWystawienia);

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

        public bool Update(InvoiceDTO objInvoiceToUpdate)
        {
            bool IsUpdated = false;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_UpdateInvoice";
                ObjSqlCommand.Parameters.AddWithValue("@FakturaId", objInvoiceToUpdate.FakturaId);
                ObjSqlCommand.Parameters.AddWithValue("@NIP", objInvoiceToUpdate.NIP);
                ObjSqlCommand.Parameters.AddWithValue("@Nazwa", objInvoiceToUpdate.Nazwa);
                ObjSqlCommand.Parameters.AddWithValue("@DataWystawienia", objInvoiceToUpdate.DataWystawienia);
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

        public bool Delete(int fakturaid)
        {
            bool IsDeleted = false;
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_DeleteInvoice";
                ObjSqlCommand.Parameters.AddWithValue("@FakturaId", fakturaid);

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


        public InvoiceDTO Search(int fakturaid)
        {
           InvoiceDTO ObjInvoice = null;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_SelectInvoiceById";
                ObjSqlCommand.Parameters.AddWithValue("@FakturaId", fakturaid);

                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {

                    ObjSqlDataReader.Read();
                    ObjInvoice = new InvoiceDTO();
                    ObjInvoice.FakturaId = ObjSqlDataReader.GetInt32(0);
                    ObjInvoice.NIP = ObjSqlDataReader.GetString(1);
                    ObjInvoice.Nazwa = ObjSqlDataReader.GetString(2);
                    ObjInvoice.DataWystawienia = ObjSqlDataReader.GetDateTime(3);

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
            return ObjInvoice;

        }
    }
}
