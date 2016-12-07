using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ScriptManager1.RegisterAsyncPostBackControl(ddlTeams);

        }

        protected void ddlTeams_SelectedIndexChanged(object sender, EventArgs e)
        {

            ddlMeasures.Items.Add(

            new ListItem("item 1"));
            ddlMeasures.Items.Add(

            new ListItem("item 2"));
            ddlMeasures.Items.Add(

            new ListItem("item 3"));
            ddlMeasures.Items.Add(

            new ListItem("item 4"));
            lblTime.Text =

            DateTime.Now.ToString();
        }

    }
}