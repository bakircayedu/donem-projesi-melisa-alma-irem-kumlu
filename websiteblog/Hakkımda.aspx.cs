using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hakkımda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {

            DataSetTableAdapters.TBLHAKKIMDATableAdapter dt = new
                DataSetTableAdapters.TBLHAKKIMDATableAdapter();
            DataSetTableAdapters.ILETISIMTableAdapter dt2 = new DataSetTableAdapters.ILETISIMTableAdapter();
            TextBox1.Text = dt.HakkımdaListe()[0].AD;
            TextBox2.Text = dt.HakkımdaListe()[0].SOYAD;
            TextBox6.Text = dt.HakkımdaListe()[0].KISANOT;
            TextBox3.Text = dt2.IletisimGetir()[0].ADRES;
            TextBox4.Text = dt2.IletisimGetir()[0].MAIL;
            TextBox5.Text = dt2.IletisimGetir()[0].TELEFON;

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLHAKKIMDATableAdapter dt1 = new DataSetTableAdapters.TBLHAKKIMDATableAdapter();
        DataSetTableAdapters.ILETISIMTableAdapter dt2 = new DataSetTableAdapters.ILETISIMTableAdapter();
        dt1.HakkımdaGuncelle(TextBox1.Text,TextBox2.Text,TextBox6.Text,TextBox7.Text);
        dt2.IletisimGuncelle(TextBox3.Text, TextBox4.Text, TextBox5.Text);
        Response.Redirect("Default.aspx");
    }
}