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
                    TornadoTypeQLabel.Visible = true;
                    TornadoTypeDropDown.Visible = true;
                    break;
                case "STATE":
                    StateQLabel.Visible = true;
                    StateDropDown.Visible = true;
                    break;
                case "COUNTY":
                    CountyQLabel.Visible = true;
                    CountyTextBox.Visible = true;
                    break;
                case "START AZIMUTH":
                    StartAzimuthQlabel.Visible = true;
                    StartAzimuthDropDown.Visible = true;
                    break;
                case "START LOCATION":
                    StartLocationQlabel.Visible = true;
                    StartLocationTextBox.Visible = true;
                    break;
                case "END AZIMUTH":
                    EndAzimuthQLabel.Visible = true;
                    EndAzimuthDropDown.Visible = true;
                    break;
                case "END LOCATION":
                    EndLocationQLabel.Visible = true;
                    EndLocationTextBox.Visible = true;
                    break;
                case "TIME ZONE":
                    TimeZoneQLabel.Visible = true;
                    TimeZoneDropDown.Visible = true;
                    break;
                case "INJURIES":
                    InjuriesQ1Label.Visible = true;
                    InjuriesQ2Label.Visible = true;
                    LowerInjuriesTextBox.Visible = true;
                    UpperInjuriesTextBox.Visible = true;
                    break;
                case "FATALITIES":
                    FatalitiesQ1Label.Visible = true;
                    FatalitiesQ2Label.Visible = true;
                    LowerFatalitiesTextBox.Visible = true;
                    UpperFatalitiesTextBox.Visible = true;
                    break;
                case "WIND SPEED":
                    WindSpeedQ1Label.Visible = true;
                    WindSpeedQ2Label.Visible = true;
                    LowerWindSpeedsTextBox.Visible = true;
                    UpperWindSpeedsTextBox.Visible = true;
                    break;
                case "HAIL SIZE":
                    HailSizeQ1Label.Visible = true;
                    HailSizeQ2Label.Visible = true;
                    LowerHailSizeTextBox.Visible = true;
                    UpperHailSizeTextBox.Visible = true;
                    break;
                case "START RANGE":
                    StartRangeQ1Label.Visible = true;
                    StartRangeQ2Label.Visible = true;
                    LowerStartRangeTextBox.Visible = true;
                    UpperStartRangeTextBox.Visible = true;
                    break;
                case "END RANGE":
                    EndRangeQ1Label.Visible = true;
                    EndRangeQ2Label.Visible = true;
                    LowerEndRangeTextBox.Visible = true;
                    UpperEndRangeTextBox.Visible = true;
                    break;
                case "START YEAR":
                    StartYearQ1Label.Visible = true;
                    StartYearQ2Label.Visible = true;
                    LowerStartYearTextBox.Visible = true;
                    UpperStartYearTextBox.Visible = true;
                    break;
                case "START MONTH":
                    StartMonthQ1Label.Visible = true;
                    StartMonthQ2Label.Visible = true;
                    LowerStartMonthTextBox.Visible = true;
                    UpperStartMonthTextBox.Visible = true;
                    break;
                case "START DAY":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (as integer, day of month) on the" +
                                               " range of event start days you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (as integer, day of month) on" +
                                               " the range of event start days you are searching for.";
                    break;
                case "START TIME":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (24 hour time with no ':', EX" +
                                               " : 1425) on the range of event start times you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (24 hour time with no ':' EX " +
                                               " : 1456) on the range of event start times you are searching for.";
                    break;
                case "END YEAR":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (as integer) on the range of" +
                                               " event end years you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (as integer) on the range of" +
                                               " event end years you are searching for.";
                    break;
                case "END MONTH":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (as integer, 1-12) on the range" +
                                               " of event end months you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (as integer, 1 - 12) on the" +
                                               " range of event end months you are searching for.";
                    break;
                case "END DAY":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (as integer, day of the month) on" +
                                               " the range of event end days you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (as integer, day of the month)" +
                                               " on the range of event end days you are searching for.";
                    break;
                case "END TIME":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (24 hour time with no ':'," +
                                               " EX: 1043) on the range of event end times you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (24 hour time with no ':'," +
                                               " EX: 1115) on the range of event end times you are searching for.";
                    break;
                case "TORNADO LENGTH":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (how far in miles) on the" +
                                               " range of tornado lengths (distance traveled) you are" +
                                               " searching for.";
                    StateQLabel.Text = "Please enter the upper bound (how far in miles) on" +
                                               " the range of tornado lengths (distance traveled) you " +
                                               " are searching for.";
                    break;
                case "TORNADO WIDTH":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (yards) on the range of" +
                                               "tornado widths (diameter accross) you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (yards)on the range of" +
                                               " tornado widths (diameter accross) you are searching for.";
                    break;
                case "START LATITUDE":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (-90 to 90) on the range of" +
                                               " event start latitudes you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (-90 to 90) on the range of" +
                                               " event start latitudes you are searching for.";
                    break;
                case "START LONGITUDE":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (-180 to 180) on the range of" +
                                               " event start longitudes you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (-180 to 180) on the range " +
                                               " of event start longitudes you are searching for.";
                    break;
                case "END LATITUDE":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (-90 to 90) on the range of event" +
                                               " end latitudes you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (-90 to 90) on the range of" +
                                               " event end latitudes you are searching for.";
                    break;
                case "END LONGITUDE":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (-180 to 180) on the range" +
                                               " of event end longitudes you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (-180 to 180) on the range" +
                                               " of event end longitudes you are searching for.";
                    break;
                case "PROPERTY DAMAGE":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (as a number without '$')" +
                                               " on the range of property damage you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (as a number without '$')" +
                                               " on the range of property damage you are searching for.";
                    break;
                case "CROP DAMAGE":
                    TornadoTypeQLabel.Text = "Please enter the lower bound (as a number without '$')" +
                                               " on the range of crop damage you are searching for.";
                    StateQLabel.Text = "Please enter the upper bound (as a number without '$')" +
                                               " on the range of crop damage you are searching for.";
                    break;
                default:
                    throw new ArgumentException("Property to search is invalid!");
            }
        }

       
    }
}