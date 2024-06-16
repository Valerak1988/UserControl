using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControl
{
    public partial class ProdList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductList.MaxProducts = 4;
        }
    }
}