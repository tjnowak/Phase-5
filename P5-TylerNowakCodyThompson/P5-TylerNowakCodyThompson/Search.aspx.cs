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
                    StartDayQ1Label.Visible = true;
                    StartDayQ2Label.Visible = true;
                    LowerStartDayTextBox.Visible = true;
                    UpperStartDayTextBox.Visible = true;
                    break;
                case "START TIME":
                    StartTimeQ1Label.Visible = true;
                    StartTimeQ2Label.Visible = true;
                    LowerStartTimeTextBox.Visible = true;
                    UpperStartTimeTextBox.Visible = true;
                    break;
                case "END YEAR":
                    EndYearQ1Label.Visible = true;
                    EndYearQ2Label.Visible = true;
                    LowerEndYearTextBox.Visible = true;
                    UpperEndYearTextBox.Visible = true;
                    break;
                case "END MONTH":
                    EndMonthQ1Label.Visible = true;
                    EndMonthQ2Label.Visible = true;
                    LowerEndMonthTextBox.Visible = true;
                    UpperEndMonthTextBox.Visible = true;
                    break;
                case "END DAY":
                    EndDayQ1Label.Visible = true;
                    EndDayQ2Label.Visible = true;
                    LowerEndDayTextBox.Visible = true;
                    UpperEndDayTextBox.Visible = true;
                    break;
                case "END TIME":
                    EndTimeQ1Label.Visible = true;
                    EndTimeQ2Label.Visible = true;
                    LowerEndTimeTextBox.Visible = true;
                    UpperEndTimeTextBox.Visible = true;
                    break;
                case "TORNADO LENGTH":
                    TornadoLengthQ1Label.Visible = true;
                    TornadoLengthQ2Label.Visible = true;
                    LowerTornadoLengthTextBox.Visible = true;
                    UpperTornadoLengthTextBox.Visible = true;
                    break;
                case "TORNADO WIDTH":
                    TornadoWidthQ1Label.Visible = true;
                    TornadoWidthQ2Label.Visible = true;
                    LowerTornadoWidthTextBox.Visible = true;
                    UpperTornadoWidthTextBox.Visible = true;
                    break;
                case "START LATITUDE":
                    StartLatitudeQ1Label.Visible = true;
                    StartLatitudeQ2Label.Visible = true;
                    LowerStartLatitudeTextBox.Visible = true;
                    UpperStartLatitudeTextBox.Visible = true;
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