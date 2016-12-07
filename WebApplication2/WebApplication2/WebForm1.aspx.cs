using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5_TylerNowakCodyThompson
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ScriptManager1.RegisterAsyncPostBackControl(StormTypeDropDown);

            // Show generic property list
            Other_PropertyDropDown.Visible = true;
            Tornado_PropertyDropDown.Visible = false;
            Hail_PropertyDropDown.Visible = false;
            Wind_PropertyDropDown.Visible = false;
        }

        protected void StormTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StormTypeDropDown.SelectedValue == "TORNADO")
            {
                // Only show TornadoEvent property list
                Tornado_PropertyDropDown.Visible = true;
                Other_PropertyDropDown.Visible = false;
                Hail_PropertyDropDown.Visible = false;
                Wind_PropertyDropDown.Visible = false;
            }
            else if (StormTypeDropDown.SelectedValue == "HAIL")
            {
                // Only show HailEvent property list
                Hail_PropertyDropDown.Visible = true;
                Other_PropertyDropDown.Visible = false;
                Tornado_PropertyDropDown.Visible = false;
                Wind_PropertyDropDown.Visible = false;
            }
            else if (StormTypeDropDown.SelectedValue == "THUNDERSTORM WIND" ||
                     StormTypeDropDown.SelectedValue == "MARINE THUNDERSTORM WIND" ||
                     StormTypeDropDown.SelectedValue == "MARINE STRONG WIND" ||
                     StormTypeDropDown.SelectedValue == "MARINE HIGH WIND" ||
                     StormTypeDropDown.SelectedValue == "STRONG WIND")
            {
                // Only show WindEvent property list
                Wind_PropertyDropDown.Visible = true;
                Other_PropertyDropDown.Visible = false;
                Hail_PropertyDropDown.Visible = false;
                Tornado_PropertyDropDown.Visible = false;
            }
        }

        protected void MainMenuButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Main.aspx");
        }

        protected void Other_PropertyDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Tornado_PropertyDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Wind_PropertyDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Hail_PropertyDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}