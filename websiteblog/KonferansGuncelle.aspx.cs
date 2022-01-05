using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class KonferansGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int s = Convert.ToInt16(Request.QueryString["ID"]);
        Txtid.Text = s.ToString();
        Txtid.Enabled = false;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLKONFERANSTableAdapter dt = new DataSetTableAdapters.TBLKONFERANSTableAdapter();
        dt.KonferansGuncelle(TxtKonferans.Text, Convert.ToInt16(Txtid.Text));
        Response.Redirect("KonferansListesi.Aspx");
    }
}