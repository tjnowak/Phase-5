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
            switch (PropertyDropDown.SelectedValue)
            {
                case "TORNADO TYPE":
                    Question1Label.Text = "Please enter the tornado type (EF0 through EF5) you" +
                                               " are searching for.";
                    break;
                case "STATE":
                    Question1Label.Text = "Please enter the full name of the state you are" +
                                               " searching for.";
                    break;
                case "COUNTY":
                    Question1Label.Text = "Please enter the full county name you are searching for.";
                    break;
                case "START AZIMUTH":
                    Question1Label.Text = "Please enter the starting azimuth (Compass direction," +
                                               " Ex: SW) you are searching for. ";
                    break;
                case "START LOCATION":
                    Question1Label.Text = "Please enter the full start location name (nearest city)" +
                                               " you are searching for.";
                    break;
                case "END AZIMUTH":
                    Question1Label.Text = "Please enter the ending azimuth (Compass direction, Ex: SW)" +
                                               " you are searching for .";
                    break;
                case "END LOCATION":
                    Question1Label.Text = "Please enter the full end location name (nearest city)" +
                                               " you are searching for.";
                    break;
                case "TIME ZONE":
                    Question1Label.Text = "Please enter the time zone (Ex: est) you are searching for.";
                    break;
                case "INJURIES":
                    Question1Label.Text = "Please enter the lower bound (integer) on the range of the" +
                                               " number of injuries you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (integer) on the range of the" +
                                               " number of injuries you are searching for.";
                    break;
                case "FATALITIES":
                    Question1Label.Text = "Please enter the lower bound (integer) on the range of the" +
                                               " number of fatalities you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (integer) on the range of the" +
                                               " number of fatalities you are searching for.";
                    break;
                case "WIND SPEED":
                    Question1Label.Text = "Please enter the lower bound (integer) on the range of wind" +
                                               " speeds (measured in knots) you are searching for. ";
                    Value2QuestionLabel.Text = "Please enter the upper bound (integer) on the range of" +
                                               " wind speeds (measured in knots) you are searching for.";
                    break;
                case "HAIL SIZE":
                    Question1Label.Text = "Please enter the lower bound (number in inches) on the range" +
                                               " of hail sizes you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (number in inches) on the" +
                                               " range of hail sizes you are searching for.";
                    break;
                case "START RANGE":
                    Question1Label.Text = "Please enter the lower bound of event start ranges" +
                                               " (miles from nearest city as integer) you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound of event start ranges" +
                                               " (miles from nearest city as integer) you are searching for.";
                    break;
                case "END RANGE":
                    Question1Label.Text = "Please enter the lower bound of event end ranges" +
                                               " (miles from nearest city as integer) you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound of event end ranges" +
                                               " (miles from nearest city as integer) you are searching for.";
                    break;
                case "START YEAR":
                    Question1Label.Text = "Please enter the lower bound (as integer) on the range of" +
                                               " event start years you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (as integer) on the range of" +
                                               " event start years you are searching for.";
                    break;
                case "START MONTH":
                    Question1Label.Text = "Please enter the lower bound (as integer, 1-12) on the range of" +
                                               " event start months you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (as integer, 1 - 12) on the range of" +
                                               " event start months you are searching for.";
                    break;
                case "START DAY":
                    Question1Label.Text = "Please enter the lower bound (as integer, day of month) on the" +
                                               " range of event start days you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (as integer, day of month) on" +
                                               " the range of event start days you are searching for.";
                    break;
                case "START TIME":
                    Question1Label.Text = "Please enter the lower bound (24 hour time with no ':', EX" +
                                               " : 1425) on the range of event start times you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (24 hour time with no ':' EX " +
                                               " : 1456) on the range of event start times you are searching for.";
                    break;
                case "END YEAR":
                    Question1Label.Text = "Please enter the lower bound (as integer) on the range of" +
                                               " event end years you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (as integer) on the range of" +
                                               " event end years you are searching for.";
                    break;
                case "END MONTH":
                    Question1Label.Text = "Please enter the lower bound (as integer, 1-12) on the range" +
                                               " of event end months you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (as integer, 1 - 12) on the" +
                                               " range of event end months you are searching for.";
                    break;
                case "END DAY":
                    Question1Label.Text = "Please enter the lower bound (as integer, day of the month) on" +
                                               " the range of event end days you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (as integer, day of the month)" +
                                               " on the range of event end days you are searching for.";
                    break;
                case "END TIME":
                    Question1Label.Text = "Please enter the lower bound (24 hour time with no ':'," +
                                               " EX: 1043) on the range of event end times you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (24 hour time with no ':'," +
                                               " EX: 1115) on the range of event end times you are searching for.";
                    break;
                case "TORNADO LENGTH":
                    Question1Label.Text = "Please enter the lower bound (how far in miles) on the" +
                                               " range of tornado lengths (distance traveled) you are" +
                                               " searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (how far in miles) on" +
                                               " the range of tornado lengths (distance traveled) you " +
                                               " are searching for.";
                    break;
                case "TORNADO WIDTH":
                    Question1Label.Text = "Please enter the lower bound (yards) on the range of" +
                                               "tornado widths (diameter accross) you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (yards)on the range of" +
                                               " tornado widths (diameter accross) you are searching for.";
                    break;
                case "START LATITUDE":
                    Question1Label.Text = "Please enter the lower bound (-90 to 90) on the range of" +
                                               " event start latitudes you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (-90 to 90) on the range of" +
                                               " event start latitudes you are searching for.";
                    break;
                case "START LONGITUDE":
                    Question1Label.Text = "Please enter the lower bound (-180 to 180) on the range of" +
                                               " event start longitudes you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (-180 to 180) on the range " +
                                               " of event start longitudes you are searching for.";
                    break;
                case "END LATITUDE":
                    Question1Label.Text = "Please enter the lower bound (-90 to 90) on the range of event" +
                                               " end latitudes you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (-90 to 90) on the range of" +
                                               " event end latitudes you are searching for.";
                    break;
                case "END LONGITUDE":
                    Question1Label.Text = "Please enter the lower bound (-180 to 180) on the range" +
                                               " of event end longitudes you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (-180 to 180) on the range" +
                                               " of event end longitudes you are searching for.";
                    break;
                case "PROPERTY DAMAGE":
                    Question1Label.Text = "Please enter the lower bound (as a number without '$')" +
                                               " on the range of property damage you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (as a number without '$')" +
                                               " on the range of property damage you are searching for.";
                    break;
                case "CROP DAMAGE":
                    Question1Label.Text = "Please enter the lower bound (as a number without '$')" +
                                               " on the range of crop damage you are searching for.";
                    Value2QuestionLabel.Text = "Please enter the upper bound (as a number without '$')" +
                                               " on the range of crop damage you are searching for.";
                    break;
                default:
                    throw new ArgumentException("Property to search is invalid!");
            }
        }
    }
}