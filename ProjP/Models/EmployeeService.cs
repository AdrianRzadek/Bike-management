using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjP.Models
{
    public class EmployeeService
    {


        SqlConnection ObjSqlConnection = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=WypozyczalniaRowerow;Integrated Security=True");
        SqlCommand ObjSqlCommand = new SqlCommand();


        public EmployeeService()
        {
            ObjSqlCommand.Connection = ObjSqlConnection;
            ObjSqlCommand.CommandType = CommandType.StoredProcedure;

        }


        public List<EmployeeDTO> GetAll()
        {
            List<EmployeeDTO> ObjEmployeeList = new List<EmployeeDTO>();
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_SelectAllEmployees";
                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {
                    EmployeeDTO ObjEmployee = null;
                    while (ObjSqlDataReader.Read())
                    {
                        ObjEmployee = new EmployeeDTO();
                        ObjEmployee.PracownikId = ObjSqlDataReader.GetInt32(0);
                        ObjEmployee.Pesel = ObjSqlDataReader.GetString(1);
                        ObjEmployee.NazwiskoPracownik = ObjSqlDataReader.GetString(2);
                        ObjEmployee.ImięPracownik = ObjSqlDataReader.GetString(3);
                        ObjEmployee.Stanowisko = ObjSqlDataReader.GetString(4);
                        ObjEmployee.NrTelefonu = ObjSqlDataReader.GetString(5);

                        ObjEmployeeList.Add(ObjEmployee);
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
            return ObjEmployeeList;
        }
        public bool Add(EmployeeDTO objNewEmployee)
        {
            bool IsAdded = false;
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_InsertEmployee";
                ObjSqlCommand.Parameters.AddWithValue("@PracownikId", objNewEmployee.PracownikId);
                ObjSqlCommand.Parameters.AddWithValue("@Pesel", objNewEmployee.Pesel);
                ObjSqlCommand.Parameters.AddWithValue("@NazwiskoPracownik", objNewEmployee.NazwiskoPracownik);
                ObjSqlCommand.Parameters.AddWithValue("@ImięPracownik", objNewEmployee.ImięPracownik);
                ObjSqlCommand.Parameters.AddWithValue("@Stanowisko", objNewEmployee.Stanowisko);
                ObjSqlCommand.Parameters.AddWithValue("@NrTelefonu", objNewEmployee.NrTelefonu);
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

        public bool Update(EmployeeDTO objEmployeeToUpdate)
        {
            bool IsUpdated = false;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_UpdateEmployee";
              ObjSqlCommand.Parameters.AddWithValue("@PracownikId", objEmployeeToUpdate.PracownikId);
              ObjSqlCommand.Parameters.AddWithValue("@Pesel", objEmployeeToUpdate.Pesel);
              ObjSqlCommand.Parameters.AddWithValue("@NazwiskoPracownik", objEmployeeToUpdate.NazwiskoPracownik);
                ObjSqlCommand.Parameters.AddWithValue("@ImięPracownik", objEmployeeToUpdate.ImięPracownik);
                ObjSqlCommand.Parameters.AddWithValue("@Stanowisko", objEmployeeToUpdate.Stanowisko);
                ObjSqlCommand.Parameters.AddWithValue("@NrTelefonu", objEmployeeToUpdate.NrTelefonu);
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

        public bool Delete(int pracownikid)
        {
            bool IsDeleted = false;
            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_DeleteEmployee";
                ObjSqlCommand.Parameters.AddWithValue("@PracownikId", pracownikid);

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


        public EmployeeDTO Search(int pracownikid)
        {
            EmployeeDTO ObjEmployee = null;

            try
            {
                ObjSqlCommand.Parameters.Clear();
                ObjSqlCommand.CommandText = "udp_SelectEmployeeById";
                ObjSqlCommand.Parameters.AddWithValue("@PracownikId", pracownikid);

                ObjSqlConnection.Open();
                var ObjSqlDataReader = ObjSqlCommand.ExecuteReader();
                if (ObjSqlDataReader.HasRows)
                {

                    ObjSqlDataReader.Read();
                    ObjEmployee = new EmployeeDTO();
                    ObjEmployee.PracownikId = ObjSqlDataReader.GetInt32(0);
                    ObjEmployee.Pesel = ObjSqlDataReader.GetString(1);
                    ObjEmployee.NazwiskoPracownik = ObjSqlDataReader.GetString(2);
                    ObjEmployee.ImięPracownik = ObjSqlDataReader.GetString(3);
                    ObjEmployee.Stanowisko = ObjSqlDataReader.GetString(4);
                    ObjEmployee.NrTelefonu = ObjSqlDataReader.GetString(5);
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
            return ObjEmployee;

        }
    }
}
