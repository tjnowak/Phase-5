using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5_TylerNowakCodyThompson
{
    public partial class AvgTorDamg : System.Web.UI.Page
    {
        EventList theList = new EventList();
        List<string> damage = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            theList = (EventList)Session["theList"];
        }

        protected void StartYearDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            EndYearDropDown.Visible = true;
        }

        protected void EndYearDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EndYearDropDown.SelectedValue == "Pick One")
            {
                Label4.Text = "";
                Label4.Visible = false;
            }
            else if ((Convert.ToInt32(EndYearDropDown.SelectedValue)) < Convert.ToInt32(StartYearDropDown.SelectedValue))
            {
                Label4.Text = "Please select a year after " + StartYearDropDown.SelectedValue;
                Label4.Visible = true;
                EndYearDropDown.SelectedValue = "Pick One";
            }
            else
            {
                Label4.Text = "";
                Label4.Visible = false;
                CalcDamage.Visible = true;
            }
        }

        protected void CalcDamage_Click(object sender, EventArgs e)
        {
            damage = theList.CalculateMeanDamagePerState(Convert.ToInt32(StartYearDropDown.SelectedValue), Convert.ToInt32(EndYearDropDown.SelectedValue));
            Label5.Visible = true;
            TryAgain1.Visible = true;

            foreach (var item in damage)
                DisplayDmgStats.Items.Add(item);

            DisplayDmgStats.Visible = true;
            Label6.Visible = true;
        }

        protected void TryAgain1_Click(object sender, EventArgs e)
        {
            StartYearDropDown.SelectedValue = "Pick One";
            EndYearDropDown.SelectedValue = "Pick One";
            EndYearDropDown.Visible = false;
            CalcDamage.Visible = false;
            DisplayDmgStats.Items.Clear();
            DisplayDmgStats.Visible = true;
            Label6.Visible = true;
            Label5.Visible = false;
            TryAgain1.Visible = false;
        }

        protected void AvgTorDamgToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Main.aspx");
        }

        protected void AvgTorDamgToStats_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DisplayStatistics.aspx");
        }
    }
}