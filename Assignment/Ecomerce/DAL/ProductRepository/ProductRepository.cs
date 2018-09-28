using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.ProductModel;
using System.Data.SqlClient;
using System.Data;

namespace DAL.ProductRepository
{
    public class ProductRepository
    {
        public List<Product> products = new List<Product>();

        public List<Product> GetProductList(string pSearchObj,string pQueryID)
        {
            string Search = string.IsNullOrEmpty(pSearchObj) ? "%" : pSearchObj;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=ACUPC-208;Initial Catalog=IndivAuth;Integrated Security=True";
                connection.Open();
                string sql;
                //string sql = "select * from ProductDetails where Name like "+ "\'"+ Search + '\"";
                if (pQueryID == "0")
                {
                    sql = "select * from ProductDetails where ID =" + pSearchObj;
                }
                else
                {
                   sql = string.Format("select * from ProductDetails where Name like '%{0}%'", Search);
                }


                
                SqlCommand mycommand = new SqlCommand(sql, connection);

                using (SqlDataReader myDataReader = mycommand.ExecuteReader())
                {
                    while (myDataReader.Read())
                    {
                        products.Add(new Product
                        {
                            Name = myDataReader["Name"].ToString(),
                            ID = Convert.ToInt32(myDataReader["ID"].ToString()),
                            Price = Convert.ToInt32(myDataReader["Price"].ToString()),
                            ImageUrl = myDataReader["ImageURL"].ToString(),
                            Description = myDataReader["Descript"].ToString()
                        });

                    }
                }
                return products;

            }
        }
    }
    public class InventoryAdapter
    {

        public DataTable ProdTable = new DataTable();
        private SqlConnection connection = new SqlConnection();

        private SqlDataAdapter adapter ;
        private string AdapterConnStr = @"Data Source=ACUPC-208;Initial Catalog=IndivAuth;Integrated Security=True";

        public DataTable GetProductTable(string pSearchObj)
        {
            connection.ConnectionString = AdapterConnStr;
            //connection.Open();
            string sql = string.Format("select * from ProductDetails where Name like '%{0}%'", pSearchObj);
            adapter = new SqlDataAdapter(sql, connection);                       
        
        
            
            adapter.Fill(ProdTable);
            return ProdTable;
        }
    }
}