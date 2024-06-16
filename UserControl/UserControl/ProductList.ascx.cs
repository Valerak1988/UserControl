using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControl.UserControl
{
    public partial class ProductList : System.Web.UI.UserControl
    {
        public int MaxProducts { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Product> ProductList = (List<Product>)Application["Product"];
                if (ProductList != null)
                {
                    RptProducts.DataSource = ProductList.Take(MaxProducts);
                    RptProducts.DataBind();
                }
            }
        }

    }
}