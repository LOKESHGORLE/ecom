﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P22Sep2018_Auth
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Context.User.IsInRole("Products"))
            {
                Response.Redirect("~/");
            }

        }
    }
}