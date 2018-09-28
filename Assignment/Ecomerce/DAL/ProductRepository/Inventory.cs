using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL.ProductRepository
{
    public class Inventory
    {
        private SqlConnection connection = new SqlConnection();


        public void InsertProduct(string pName, string pURL, float pPrice, string pDescription)
        {
            connection.ConnectionString = @"Data Source=ACUPC-208;Initial Catalog=IndivAuth;Integrated Security=True";
            connection.Open();
            string OutStatus;
            

            using (SqlCommand command = new SqlCommand("PROC_InsertProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Input param.
                SqlParameter parName = new SqlParameter
                {
                    ParameterName = "@pName",
                    SqlDbType = SqlDbType.Char,
                    Value = pName,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parName);
                SqlParameter parPrice = new SqlParameter
                {
                    ParameterName = "@pPrice",
                    SqlDbType = SqlDbType.Float,
                    Value = pPrice,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parPrice);
                SqlParameter parURL = new SqlParameter
                {
                    ParameterName = "@pImageURL",
                    SqlDbType = SqlDbType.Char,
                    Value = pURL,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parURL);
                SqlParameter parDescription = new SqlParameter
                {
                    ParameterName = "@pDescript",
                    SqlDbType = SqlDbType.Char,
                    Value = pDescription,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parDescription);
                SqlParameter parStatus = new SqlParameter
                {
                    ParameterName = "@pStatus",
                    SqlDbType = SqlDbType.Char,
                    Value = pDescription,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(parStatus);
                command.ExecuteNonQuery();
                // OutStatus = (string)command.Parameters["@pStatus"].Value;

            }
            connection.Close();
            //return OutStatus;
        }
        public void UpdateProduct(string pName, string pURL, float pPrice, string pDescription, int pID)
        {
            connection.ConnectionString = @"Data Source=ACUPC-208;Initial Catalog=IndivAuth;Integrated Security=True";
            connection.Open();
            string OutStatus;

            using (SqlCommand command = new SqlCommand("Proc_UpdateProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Input param.
                SqlParameter parName = new SqlParameter
                {
                    ParameterName = "@pName",
                    SqlDbType = SqlDbType.Char,
                    Value = pName,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parName);
                SqlParameter parPrice = new SqlParameter
                {
                    ParameterName = "@pPrice",
                    SqlDbType = SqlDbType.Float,
                    Value = pPrice,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parPrice);
                SqlParameter parURL = new SqlParameter
                {
                    ParameterName = "@pImageURL",
                    SqlDbType = SqlDbType.Char,
                    Value = pURL,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parURL);
                SqlParameter parDescription = new SqlParameter
                {
                    ParameterName = "@pDescript",
                    SqlDbType = SqlDbType.Char,
                    Value = pDescription,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parDescription);
                SqlParameter parId = new SqlParameter
                {
                    ParameterName = "@pID",
                    SqlDbType = SqlDbType.Int,
                    Value = pID,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parId);
                command.ExecuteNonQuery();
                // OutStatus = (string)command.Parameters["@pStatus"].Value;

            }
            connection.Close();
            //return OutStatus;
        }
        public void DeleteProduct( int pID)
        {
            connection.ConnectionString = @"Data Source=ACUPC-208;Initial Catalog=IndivAuth;Integrated Security=True";
            connection.Open();
            string OutStatus;

            using (SqlCommand command = new SqlCommand("Proc_DeleteProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Input param.
                SqlParameter parId = new SqlParameter
                {
                    ParameterName = "@pID",
                    SqlDbType = SqlDbType.Int,
                    Value = pID,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parId);
                command.ExecuteNonQuery();
            }
            
            connection.Close();
        }
    }
}
