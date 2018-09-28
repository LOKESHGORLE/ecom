using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using DAL.ProductRepository;
using System.Data;

namespace P24Sep2018.Product_Management
{
    public partial class ProductManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Context.User.IsInRole("Products"))
            {
                Response.Redirect("~/");
            }
            string RepoString="";
            

            Table T = new Table();
            PlaceHolder1.Controls.Add(T);
            TableRow Tr;
            TableCell Tc;
            
            HyperLink ProdName;
            HyperLink Preview;
            HyperLink Update;
            HyperLink Delete;
            Label ProNAme;

            //DAL.ProductRepository.ProductRepository productRepository = new DAL.ProductRepository.ProductRepository();
            //productRepository.GetProductList(RepoString);
            //int MaxRows = productRepository.products.Count;

            //for (int ProdCount=0; ProdCount< MaxRows; ProdCount++)
            //{
                
            //    {
                    

            //        Tr = new TableRow();
            //        Tc = new TableCell();


            //        int ProdId = productRepository.products[ProdCount].ID;
                    
            //        ProNAme = new Label();
            //        T.Rows.Add(Tr);
            //        Tr.Cells.Add(Tc);
            //        ProdName = new HyperLink();
            //        ProdName.Text = productRepository.products[ProdCount].Name;
                   

            //        ProdName.NavigateUrl = "~/Products_User/ProductDescription?Id=" + ProdId;
            //        ProdName.Width = 250;
            //        Tc.Controls.Add(ProdName);
                   
            //        Preview = new HyperLink();
            //        Preview.Text = "PREVIEW";
            //        Preview.NavigateUrl = "~/Products_User/ProductDescription?Id=" + ProdId;
            //        Preview.Width = 250;
            //        Tc.Controls.Add(Preview);
                   
            //        Update = new HyperLink();
            //        Update.Text = "UPDATE";
            //        Update.Width = 250;
            //        Tc.Controls.Add(Update);
                    
            //        Delete = new HyperLink();
            //        Delete.Text = "DELETE";
            //        Tc.Controls.Add(Delete);
            //    }


            //}
            InventoryAdapter adapter = new InventoryAdapter();
            adapter.GetProductTable(RepoString);
            
            foreach ( DataRow data in adapter.ProdTable.Rows)
            {

                Tr = new TableRow();
                Tc = new TableCell();


                
                string ProdNameQ = data[1].ToString();
                int ProdIdQ= Convert.ToInt32(data[0].ToString());

                ProNAme = new Label();
                T.Rows.Add(Tr);
                Tr.Cells.Add(Tc);
                ProdName = new HyperLink();
                
                ProdName.Text = data[1].ToString();

                ProdName.NavigateUrl = "~/Products_User/ProductDescription?Id=" + ProdIdQ+"&&QueryID=0";
                ProdName.Width = 250;
                Tc.Controls.Add(ProdName);
                
                Preview = new HyperLink();
                Preview.Text = "PREVIEW";
                Preview.NavigateUrl = "~/Products_User/ProductDescription?Id=" + ProdIdQ + "&&QueryID=0";
                Preview.Width = 250;
                Tc.Controls.Add(Preview);
                
                Update = new HyperLink();
                Update.Text = "UPDATE";
                Update.NavigateUrl = "~/Product_Management/ProductInsert?Id=" + ProdNameQ + "&&Act=1"+"&&pUID="+ ProdIdQ;
                Update.Width = 250;
                Tc.Controls.Add(Update);
               
                Delete = new HyperLink();
                Delete.Text = "DELETE";
                Delete.NavigateUrl= "~/Product_Management/ProductInsert?Id=" + ProdNameQ + "&&Act=1" + "&&pUID=" + ProdIdQ;
                Tc.Controls.Add(Delete);
            }

        }

         

        protected void AddProducts_Click(object sender, EventArgs e)
        {
            //DAL.ProductRepository.Inventory inventory = new DAL.ProductRepository.Inventory();
            Response.Redirect("~/Product_Management/ProductInsert");
        }
    }
}