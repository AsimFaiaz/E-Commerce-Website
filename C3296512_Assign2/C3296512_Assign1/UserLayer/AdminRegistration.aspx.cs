﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace C3296512_Assign1.UserLayer
{
    public partial class AdminRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdminRegDone_Click(object sender, EventArgs e)
        {
            if (AdminpassRegtxt.Text != AdminconPassRegtxt.Text)
            {
                regAdminFeedbacklbl.Text = "Please check your password";
            }
            else
            {
                Response.Redirect("AdminLogin.aspx");
                regAdminFeedbacklbl.Text = "Your registration is done";
            }
          
        }
    }
}