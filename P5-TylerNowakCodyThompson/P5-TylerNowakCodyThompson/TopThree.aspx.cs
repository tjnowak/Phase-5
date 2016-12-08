using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5_TylerNowakCodyThompson
{
    public partial class TopThree : System.Web.UI.Page
    {
        EventList theList = new EventList();
        EventList results = new EventList();
        decimal totalDamage = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            theList = (EventList)Session["theList"];
        }

        protected void CalculateTopThree_Click(object sender, EventArgs e)
        {
            theList.GetTopThree(StormTypeDropDown1.SelectedValue, results);

            // Determine damage of top storm in results
            if (results.Count() > 0)
                totalDamage = results.GetEventFromList(0).PropertyDamage +
                              results.GetEventFromList(0).CropDamage;

            // Display results
            if (totalDamage == 0)
                Label2.Text = "No storms of this type have caused any damage!";
            else
            {
                Label2.Text = "The storms below have caused the most damage as of the current date.";
                for (int index = 0; index < results.Count(); index++)
                {
                    DisplayResults.Items.Add(results.GetEventFromList(index).ToString());
                }
            }



            

            Label2.Visible = true;
            DisplayResults.Visible = true;
            Label3.Visible = true;
            TryAgain.Visible = true;
        }

        protected void TryAgain_Click(object sender, EventArgs e)
        {
            results = null;
            StormTypeDropDown1.SelectedValue = "Pick One";
            Label2.Text = "";
            DisplayResults.Items.Clear();
            Label2.Visible = false;
            DisplayResults.Visible = false;
            Label3.Visible = false;
            TryAgain.Visible = false;
        }

        protected void FatalToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Main.aspx");
        }

        protected void FatalToStats_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DisplayStatistics.aspx");
        }

        protected void StormTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}