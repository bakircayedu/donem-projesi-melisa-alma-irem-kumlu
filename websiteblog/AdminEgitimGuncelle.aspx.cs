using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitimGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(Request.QueryString["ID"]);
        Txtid.Enabled = false;
        Txtid.Text = x.ToString();
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLEGİTİMTableAdapter dt = new DataSetTableAdapters.TBLEGİTİMTableAdapter();
        dt.EgitimGuncelle(TxtBaslik.Text,TxtAltBaslik.Text,TxtAciklama.Text, Convert.ToInt16(TxtTarih.Text),Convert.ToInt16(Txtid.Text));
        Response.Redirect("AdminEgitimler.Aspx"); 
    }
}