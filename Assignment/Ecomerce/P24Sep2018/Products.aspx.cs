using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DAL.ProductRepository;

namespace P22Sep2018_Auth
{
    public partial class Products : System.Web.UI.Page
    {
        private void SearchLoad()
        {
            string SearchObj = SearchBox.Text;

            ProductRepository productRepository = new ProductRepository();
            productRepository.GetProductList(SearchObj,"1");

            Table DisplayTable = new Table();
            PlaceHolder1.Controls.Add(DisplayTable);

            int cellcount = 0;
            int productcount = 0;
            //for (int rowcount = 0; rowcount < 2; rowcount++)
            //{
            TableRow TabRow = new TableRow();



            for (cellcount = 0; cellcount < productRepository.products.Count; cellcount++)
            {

                DisplayTable.Rows.Add(TabRow);
                TableCell TabCell1 = new TableCell();

                TabRow.Cells.Add(TabCell1);

                Image im1 = new Image();
                Label lbl1 = new Label();
                HyperLink Hyp = new HyperLink();

                TabCell1.Controls.Add(im1);
                TabCell1.Controls.Add(Hyp);
                TabCell1.Controls.Add(lbl1);
                int ProdId = productRepository.products[productcount].ID;
                Hyp.Text = productRepository.products[productcount].Name;
                Hyp.NavigateUrl = "/Products_User/ProductDescription.aspx?ID=" + ProdId;
                lbl1.Text = productRepository.products[productcount].Price.ToString();
                im1.ImageUrl = productRepository.products[productcount].ImageUrl;

                productcount++;
            }

        }
        protected void SearchByAdapter()
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {

            SearchLoad();
        }



        protected void Search_Click(object sender, EventArgs e)
        {
           // SearchLoad();
            
        }
    }
}



