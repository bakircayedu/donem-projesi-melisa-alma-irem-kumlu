using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminDeneyimGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        TxtId.Enabled = false;
        TxtId.Text = x.ToString();

    }


    protected void BtnGuncelle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLDENEYIMTableAdapter dt = new DataSetTableAdapters.TBLDENEYIMTableAdapter();
        dt.DeneyimGuncelle(TxtBaslik.Text,TxtAltbaslik.Text,TxtAciklama.Text,Convert.ToInt16(TxtTarihid.Text),Convert.ToInt16(TxtId.Text));
        Response.Redirect("AdminDeneyimler.Aspx");

    }
}