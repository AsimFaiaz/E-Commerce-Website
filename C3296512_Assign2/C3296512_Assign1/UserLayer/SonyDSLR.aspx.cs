﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C3296512_Assign1.UserLayer.ProductPages
{
    public partial class SonyDSLR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnaddCart13_Click(object sender, EventArgs e)
        {
            if (Session["UID"] == "Asim")
            {
                Response.Redirect("CartPage.aspx");
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}