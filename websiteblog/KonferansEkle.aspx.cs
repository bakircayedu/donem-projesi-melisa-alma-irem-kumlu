using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KonferansEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLKONFERANSTableAdapter dt = new DataSetTableAdapters.TBLKONFERANSTableAdapter();
        dt.KonferansEkle(TextBox1.Text);
        Response.Redirect("KonferansListesi.Aspx");
    }
}