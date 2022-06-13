using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Models
{
    public class BikeService
    {

        SqlConnection ObjSqlConnection = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=WypozyczalniaRowerow;Integrated Security=True");
        SqlCommand ObjSqlCommand = new SqlCommand();


        public BikeService()
        {
            ObjSqlCommand.Connection = ObjSqlConnection;
            ObjSqlCommand.CommandType = CommandType.StoredProcedure;

        }


        public List<BikeDTO> GetAll()
        {
            List<BikeDTO> ObjBikeList = new List<BikeDTO>();
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_SelectAllBikes";
                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    BikeDTO ObjBike = null;
                    while (ObjSqlDataReader.Read())
                    {
                        ObjBike = new BikeDTO();
                        ObjBike.RowerId = ObjSqlDataReader.GetInt32(0);
                        ObjBike.Kolor = ObjSqlDataReader.GetString(1);
                        ObjBike.RowerType = ObjSqlDataReader.GetString(2);
                        ObjBike.RozmiarRamy = ObjSqlDataReader.GetFloat(3);
                        ObjBike.RozmiarOpon = ObjSqlDataReader.GetFloat(4);
                        ObjBike.Biegi = ObjSqlDataReader.GetInt32(5);

                        ObjBikeList.Add(ObjBike);
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
            return ObjBikeList;
        }
        public bool Add(BikeDTO objNewBike)
        {
            bool IsAdded = false;
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_InsertBike";
                ObjSqlCommand.Parameters.AddWithValue("@RowerId", objNewBike.RowerId);
                ObjSqlCommand.Parameters.AddWithValue("@Kolor", objNewBike.Kolor);
                ObjSqlCommand.Parameters.AddWithValue("@RowerType", objNewBike.RowerType);
                ObjSqlCommand.Parameters.AddWithValue("@RozmiarRamy", objNewBike.RozmiarRamy);
                ObjSqlCommand.Parameters.AddWithValue("@RozmiarOpon", objNewBike.RozmiarOpon);
                ObjSqlCommand.Parameters.AddWithValue("@Biegi", objNewBike.Biegi);
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

        public bool Update(BikeDTO objBikeToUpdate)
        {
            bool IsUpdated = false;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_UpdateBike";
                  ObjSqlCommand.Parameters.AddWithValue("@RowerId", objBikeToUpdate.RowerId);
                ObjSqlCommand.Parameters.AddWithValue("@Kolor", objBikeToUpdate.Kolor);
                ObjSqlCommand.Parameters.AddWithValue("@RowerType", objBikeToUpdate.RowerType);
                ObjSqlCommand.Parameters.AddWithValue("@RozmiarRamy", objBikeToUpdate.RozmiarRamy);
                ObjSqlCommand.Parameters.AddWithValue("@RozmiarOpon", objBikeToUpdate.RozmiarOpon);
                ObjSqlCommand.Parameters.AddWithValue("@Biegi", objBikeToUpdate.Biegi);
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

        public bool Delete(int rowerid)
        {
            bool IsDeleted = false;
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_DeleteBike";
                ObjSqlCommand.Parameters.AddWithValue("@RowerId", rowerid);

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


        public BikeDTO Search(int rowerid)
        {
            BikeDTO ObjBike = null;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_SelectBikeById";
                ObjSqlCommand.Parameters.AddWithValue("@RowerId", rowerid);

                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {

                    ObjSqlDataReader.Read();
                    ObjBike = new BikeDTO();
                    ObjBike.RowerId = ObjSqlDataReader.GetInt32(0);
                    ObjBike.Kolor = ObjSqlDataReader.GetString(1);
                    ObjBike.RowerType = ObjSqlDataReader.GetString(2);
                    ObjBike.RozmiarRamy = ObjSqlDataReader.GetFloat(3);
                    ObjBike.RozmiarOpon = ObjSqlDataReader.GetFloat(4);
                    ObjBike.Biegi = ObjSqlDataReader.GetInt32(5);

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
            return ObjBike;

        }
    }
}
