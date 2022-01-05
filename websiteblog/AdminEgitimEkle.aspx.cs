using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitimEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLEGİTİMTableAdapter dt = new DataSetTableAdapters.TBLEGİTİMTableAdapter();
        dt.EgitimEkle(TxtBaslik.Text, TxtAltBaslik.Text,Convert.ToInt16(DropDownList1.SelectedItem.Value), TxtAciklama.Text);
        Response.Redirect("Default.Aspx");
    }

   
}