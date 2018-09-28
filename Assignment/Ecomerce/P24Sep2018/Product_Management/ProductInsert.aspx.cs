using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
//using System.Data.SqlClient;
using DAL;
using DAL.ProductRepository;

namespace P24Sep2018.Product_Management
{
    public partial class ProductInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string IDParam = Request.QueryString["Id"];
            string ActParam = Request.QueryString["Act"];
             if(ActParam=="1" && !IsPostBack)
            {
                
                    DAL.ProductRepository.InventoryAdapter inventory = new DAL.ProductRepository.InventoryAdapter();
                    inventory.GetProductTable(IDParam);
                    foreach (DataRow data in inventory.ProdTable.Rows)
                    {
                        ProductName.Text = data[1].ToString();
                        ProductPrice.Text = data[3].ToString();
                        ProductURL.Text = data[4].ToString();
                        Description.Text = data[5].ToString();

                    }
                   

            }
            



            //    using (SqlConnection connection = new SqlConnection())
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

            //protected void BrandDropDown_SelectedIndexChanged(object sender, EventArgs e)
            //{
            //    using (SqlConnection connection = new SqlConnection())
            //    {
            //        connection.ConnectionString = @"Data Source=ACUPC-208;Initial Catalog=IndivAuth;Integrated Security=True";
            //        connection.Open();
            //        string sql = "select * from  ProductBrands";
            //        SqlCommand command = new SqlCommand(sql, connection);


            //            using (SqlDataReader myDataReader = command.ExecuteReader())
            //        {
            //            while (myDataReader.Read())
            //            {
            //                BrandDropDown.Text = myDataReader["Name"].ToString();
            //                BrandDropDown.DataSource = myDataReader;
            //                BrandDropDown.DataValueField = "ID";
            //            }
            //        }
            //    }
            //}
        }
        protected void Insert_Click(object sender, EventArgs e)
        {
            

            DAL.ProductRepository.Inventory inventory = new DAL.ProductRepository.Inventory();
            float Price = Convert.ToSingle(ProductPrice.Text);
            //string Status=
                inventory.InsertProduct(ProductName.Text,ProductURL.Text, Price, Description.Text);
            Label lbl = new Label();
            //lbl.Text = Status;
        }

        protected void Update_Click(object sender, EventArgs e)
        {
           Inventory inventory = new Inventory();
            int ProductID= Convert.ToInt32(Request.QueryString["pUID"]);
            float Price = Convert.ToSingle(ProductPrice.Text);
            inventory.UpdateProduct(ProductName.Text, ProductURL.Text, Price, Description.Text, ProductID);
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            int ProductID = Convert.ToInt32(Request.QueryString["pUID"]);
           
            inventory.DeleteProduct( ProductID);
        }
    }
}