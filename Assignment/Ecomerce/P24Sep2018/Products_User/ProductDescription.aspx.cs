using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Data.SqlClient;
using DAL.ProductRepository;

namespace P24Sep2018.Products_User
{
    public partial class ProductDescription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string IDParam= Request.QueryString["ID"];
            string QueryID = Request.QueryString["QueryID"];
            ProductRepository repository = new ProductRepository();
            repository.GetProductList(IDParam, "0");

            ProductName.Text = repository.products[0].Name;
               

            Price.Text = repository.products[0].Price.ToString();
           
            ProductImage.ImageUrl = repository.products[0].ImageUrl;
           
            Description.Text = repository.products[0].Description;
           

            //using (SqlConnection connection = new SqlConnection())
            //{
            //    connection.ConnectionString = @"Data Source=ACUPC-208;Initial Catalog=IndivAuth;Integrated Security=True";
            //    connection.Open();
            //    string sql = "select * from ProductDetails where ID =" + IDParam;
            //    SqlCommand mycommand = new SqlCommand(sql, connection);

            //    using (SqlDataReader myDataReader = mycommand.ExecuteReader())
            //    {
            //        while (myDataReader.Read())
            //        {

            //            ProductName.Text = myDataReader["Name"].ToString();

            //            Price.Text = myDataReader["Price"].ToString();
            //            ProductImage.ImageUrl = myDataReader["ImageURL"].ToString();
            //            Description.Text = myDataReader["Descript"].ToString();


            //        }
            //    }
            //}
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {

        }
    }
}