using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5_TylerNowakCodyThompson
{
    public partial class Fatalities : System.Web.UI.Page
    {
        EventList theList = new EventList();
        EventList results = new EventList();
        int Fatal = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            theList = (EventList)Session["theList"];
        }

        protected void StateDropDown0_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void StormTypeDropDown2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CalcFatalities_Click(object sender, EventArgs e)
        {
            Fatal = theList.DetermineFatalities(StateDropDown0.SelectedValue, StormTypeDropDown2.SelectedValue);
            Label4.Text = "The number of fatalities from storm type, " + StormTypeDropDown2.SelectedValue +
                " in state, " + StateDropDown0.SelectedValue + " has been " + Fatal.ToString();
            Label4.Visible = true;
            Label5.Visible = true;
            TryAgain1.Visible = true;
        }

        protected void TryAgain1_Click(object sender, EventArgs e)
        {
            StateDropDown0.SelectedIndex = 0;
            StormTypeDropDown2.SelectedIndex = 0;
            Label4.Text = "";
            Label4.Visible = false;
            Label5.Visible = false;
            TryAgain1.Visible = false;
        }

        protected void FatalToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Main.aspx");
        }

        protected void FatalToStats_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DisplayStatistics.aspx");
        }
    }
} 