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

 
        }

        protected void StormTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StormTypeDropDown.SelectedValue == "TORNADO")
            {
                // Remove hail and wind properties
                if (!(PropertyDropDown.Items.FindByText("Hail Size") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Hail Size", "HAIL SIZE"));
                if (!(PropertyDropDown.Items.FindByText("Wind Speed") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Wind Speed", "WIND SPEED"));

                // Show additional tornado properties
                if (PropertyDropDown.Items.FindByText("Tornado Type") == null)
                    PropertyDropDown.Items.Add(new ListItem("Tornado Type", "TORNADO TYPE"));
                if (PropertyDropDown.Items.FindByText("Tornado Length") == null)
                    PropertyDropDown.Items.Add(new ListItem("Tornado Length", "TORNADO LENGTH"));
                if (PropertyDropDown.Items.FindByText("Tornado Width") == null)
                    PropertyDropDown.Items.Add(new ListItem("Tornado Width", "TORNADO WIDTH"));
            }
            else if (StormTypeDropDown.SelectedValue == "HAIL")
            {
                // Remove tornado and wind properties
                if (!(PropertyDropDown.Items.FindByText("Tornado Type") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Tornado Type", "TORNADO TYPE"));
                if (!(PropertyDropDown.Items.FindByText("Tornado Length") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Tornado Length", "TORNADO LENGTH"));
                if (!(PropertyDropDown.Items.FindByText("Tornado Width") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Tornado Width", "TORNADO WIDTH"));
                if (!(PropertyDropDown.Items.FindByText("Wind Speed") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Wind Speed", "WIND SPEED"));

                // Show additional hail properties
                if (PropertyDropDown.Items.FindByText("Hail Size") == null)
                    PropertyDropDown.Items.Add(new ListItem("Hail Size", "HAIL SIZE"));

            }
            else if (StormTypeDropDown.SelectedValue == "THUNDERSTORM WIND" ||
                     StormTypeDropDown.SelectedValue == "MARINE THUNDERSTORM WIND" ||
                     StormTypeDropDown.SelectedValue == "MARINE STRONG WIND" ||
                     StormTypeDropDown.SelectedValue == "MARINE HIGH WIND" ||
                     StormTypeDropDown.SelectedValue == "STRONG WIND")
            {
                // Remove tornado and hail properties
                if (!(PropertyDropDown.Items.FindByText("Tornado Type") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Tornado Type", "TORNADO TYPE"));
                if (!(PropertyDropDown.Items.FindByText("Tornado Length") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Tornado Length", "TORNADO LENGTH"));
                if (!(PropertyDropDown.Items.FindByText("Tornado Width") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Tornado Width", "TORNADO WIDTH"));
                if (!(PropertyDropDown.Items.FindByText("Hail Size") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Hail Size", "HAIL SIZE"));

                // Only show WindEvent property list
                if (PropertyDropDown.Items.FindByText("Wind Speed") == null)
                    PropertyDropDown.Items.Add(new ListItem("Wind Speed", "WIND SPEED"));
            }
            else
            {
                // Remove extra properties
                if (!(PropertyDropDown.Items.FindByText("Tornado Type") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Tornado Type", "TORNADO TYPE"));
                if (!(PropertyDropDown.Items.FindByText("Tornado Length") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Tornado Length", "TORNADO LENGTH"));
                if (!(PropertyDropDown.Items.FindByText("Tornado Width") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Tornado Width", "TORNADO WIDTH"));
                if (!(PropertyDropDown.Items.FindByText("Hail Size") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Hail Size", "HAIL SIZE"));
                if (!(PropertyDropDown.Items.FindByText("Wind Speed") == null))
                    PropertyDropDown.Items.Remove(new ListItem("Wind Speed", "WIND SPEED"));
            }
        }

        protected void MainMenuButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Main.aspx");
        }

        protected void PropertyDropDown_SelectedIndexChanged(object sender, EventArgs e)
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