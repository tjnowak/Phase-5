using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5_TylerNowakCodyThompson
{
    public partial class Add : System.Web.UI.Page
    {
        EventList theList = new EventList();

        protected void Page_Load(object sender, EventArgs e)
        {
            theList = (EventList)Session["theList"];
        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Main.aspx");
        }
    }
}