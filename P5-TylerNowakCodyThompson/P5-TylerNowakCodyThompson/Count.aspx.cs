﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5_TylerNowakCodyThompson
{
    public partial class Count : System.Web.UI.Page
    {
        EventList theList = new EventList();

        protected void Page_Load(object sender, EventArgs e)
        {
            theList = (EventList)Session["theList"];
        }

        protected void ButtonClick1(object sender, System.EventArgs e)
        {
            Label1.Text = "success";
        }
    }
}