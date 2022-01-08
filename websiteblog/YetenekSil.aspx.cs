using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class YetenekSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        DataSetTableAdapters.TBLYETENEKTableAdapterTableAdapter dt = new DataSetTableAdapters.TBLYETENEKTableAdapterTableAdapter();
        dt.YetenekSil(Convert.ToInt16(x));
        Response.Redirect("YetenekListesi.Aspx");
    }
}