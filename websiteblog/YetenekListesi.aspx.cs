﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class YetenekListesi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.TBLPROFESYONELYETENEKLERIMTableAdapter dt = new DataSetTableAdapters.TBLPROFESYONELYETENEKLERIMTableAdapter();
        Repeater1.DataSource = dt.YetenekListesi();
        Repeater1.DataBind();
    }
}