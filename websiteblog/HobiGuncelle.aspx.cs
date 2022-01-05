using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HobiGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        Txtid.Text = x.ToString();
        Txtid.Enabled = false;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLHOBILERTableAdapter dt = new DataSetTableAdapters.TBLHOBILERTableAdapter();
        dt.HobiGuncelle(TxtHobi.Text, Convert.ToInt16(Txtid.Text));
        Response.Redirect("HobiListesi.Aspx");
    }
}