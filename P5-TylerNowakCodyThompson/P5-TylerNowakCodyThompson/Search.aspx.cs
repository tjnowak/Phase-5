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
        EventList theList = new EventList();

        protected void Page_Load(object sender, EventArgs e)
        {
            TornadoTypeQLabel.Visible = false;
            TornadoTypeDropDown.Visible = false;
            StateQLabel.Visible = false;
            StateDropDown.Visible = false;
            CountyQLabel.Visible = false;
            CountyTextBox.Visible = false;
            StartAzimuthQlabel.Visible = false;
            StartAzimuthDropDown.Visible = false;
            StartLocationQlabel.Visible = false;
            StartLocationTextBox.Visible = false;
            EndAzimuthQLabel.Visible = false;
            EndAzimuthDropDown.Visible = false;
            EndLocationQLabel.Visible = false;
            EndLocationTextBox.Visible = false;
            TimeZoneQLabel.Visible = false;
            TimeZoneDropDown.Visible = false;
            InjuriesQ1Label.Visible = false;
            InjuriesQ2Label.Visible = false;
            LowerInjuriesTextBox.Visible = false;
            UpperInjuriesTextBox.Visible = false;
            FatalitiesQ1Label.Visible = false;
            FatalitiesQ2Label.Visible = false;
            LowerFatalitiesTextBox.Visible = false;
            UpperFatalitiesTextBox.Visible = false;
            WindSpeedQ1Label.Visible = false;
            WindSpeedQ2Label.Visible = false;
            LowerWindSpeedsTextBox.Visible = false;
            UpperWindSpeedsTextBox.Visible = false;
            HailSizeQ1Label.Visible = false;
            HailSizeQ2Label.Visible = false;
            LowerHailSizeTextBox.Visible = false;
            UpperHailSizeTextBox.Visible = false;
            StartRangeQ1Label.Visible = false;
            StartRangeQ2Label.Visible = false;
            LowerStartRangeTextBox.Visible = false;
            UpperStartRangeTextBox.Visible = false;
            EndRangeQ1Label.Visible = false;
            EndRangeQ2Label.Visible = false;
            LowerEndRangeTextBox.Visible = false;
            UpperEndRangeTextBox.Visible = false;
            StartYearQ1Label.Visible = false;
            StartYearQ2Label.Visible = false;
            LowerStartYearTextBox.Visible = false;
            UpperStartYearTextBox.Visible = false;
            StartMonthQ1Label.Visible = false;
            StartMonthQ2Label.Visible = false;
            LowerStartMonthTextBox.Visible = false;
            UpperStartMonthTextBox.Visible = false;
            StartDayQ1Label.Visible = false;
            StartDayQ2Label.Visible = false;
            LowerStartDayTextBox.Visible = false;
            UpperStartDayTextBox.Visible = false;
            StartTimeQ1Label.Visible = false;
            StartTimeQ2Label.Visible = false;
            LowerStartTimeTextBox.Visible = false;
            UpperStartTimeTextBox.Visible = false;
            EndYearQ1Label.Visible = false;
            EndYearQ2Label.Visible = false;
            LowerEndYearTextBox.Visible = false;
            UpperEndYearTextBox.Visible = false;
            EndMonthQ1Label.Visible = false;
            EndMonthQ2Label.Visible = false;
            LowerEndMonthTextBox.Visible = false;
            UpperEndMonthTextBox.Visible = false;
            EndDayQ1Label.Visible = false;
            EndDayQ2Label.Visible = false;
            LowerEndDayTextBox.Visible = false;
            UpperEndDayTextBox.Visible = false;
            EndTimeQ1Label.Visible = false;
            EndTimeQ2Label.Visible = false;
            LowerEndTimeTextBox.Visible = false;
            UpperEndTimeTextBox.Visible = false;
            TornadoLengthQ1Label.Visible = false;
            TornadoLengthQ2Label.Visible = false;
            LowerTornadoLengthTextBox.Visible = false;
            UpperTornadoLengthTextBox.Visible = false;
            TornadoWidthQ1Label.Visible = false;
            TornadoWidthQ2Label.Visible = false;
            LowerTornadoWidthTextBox.Visible = false;
            UpperTornadoWidthTextBox.Visible = false;
            StartLatitudeQ1Label.Visible = false;
            StartLatitudeQ2Label.Visible = false;
            LowerStartLatitudeTextBox.Visible = false;
            UpperStartLatitudeTextBox.Visible = false;
            StartLongitudeQ1Label.Visible = false;
            StartLongitudeQ2Label.Visible = false;
            LowerStartLongitudeTextBox.Visible = false;
            UpperStartLongitudeTextBox.Visible = false;
            EndLatitudeQ1Label.Visible = false;
            EndLatitudeQ2Label.Visible = false;
            LowerEndLatitudeTextBox.Visible = false;
            UpperEndLatitudeTextBox.Visible = false;
            EndLongitudeQ1Label.Visible = false;
            EndLongitudeQ2Label.Visible = false;
            LowerEndLongitudeTextBox.Visible = false;
            UpperEndLongitudeTextBox.Visible = false;
            PropertyDamageQ1Label.Visible = false;
            PropertyDamageQ2Label.Visible = false;
            LowerPropertyDamageTextBox.Visible = false;
            UpperPropertyDamageTextBox.Visible = false;
            CropDamageQ1Label.Visible = false;
            CropDamageQ2Label.Visible = false;
            LowerCropDamageTextBox.Visible = false;
            UpperCropDamageTextBox.Visible = false;
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
            // Show relevant questions for selected property
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
                    StartLongitudeQ1Label.Visible = true;
                    StartLongitudeQ2Label.Visible = true;
                    LowerStartLongitudeTextBox.Visible = true;
                    UpperStartLongitudeTextBox.Visible = true;
                    break;
                case "END LATITUDE":
                    EndLatitudeQ1Label.Visible = true;
                    EndLatitudeQ2Label.Visible = true;
                    LowerEndLatitudeTextBox.Visible = true;
                    UpperEndLatitudeTextBox.Visible = true;
                    break;
                case "END LONGITUDE":
                    EndLongitudeQ1Label.Visible = true;
                    EndLongitudeQ2Label.Visible = true;
                    LowerEndLongitudeTextBox.Visible = true;
                    UpperEndLongitudeTextBox.Visible = true;
                    break;
                case "PROPERTY DAMAGE":
                    PropertyDamageQ1Label.Visible = true;
                    PropertyDamageQ2Label.Visible = true;
                    LowerPropertyDamageTextBox.Visible = true;
                    UpperPropertyDamageTextBox.Visible = true;
                    break;
                case "CROP DAMAGE":
                    CropDamageQ1Label.Visible = true;
                    CropDamageQ2Label.Visible = true;
                    LowerCropDamageTextBox.Visible = true;
                    UpperCropDamageTextBox.Visible = true;
                    break;
                case "PICK ONE":
                    break;
                default:
                    throw new ArgumentException("Property to search is invalid!");
            }
        }

        protected void TornadoTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void StateDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void StartAzimuthDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void EndAzimuthDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TimeZoneDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void StartLocationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CountyTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LowerInjuriesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void UpperInjuriesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LowerFatalitiesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void UpperFatalitiesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LowerWindSpeedsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void UpperWindSpeedsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LowerHailSizeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void UpperHailSizeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void LowerStartRangeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            EventList results = new EventList();

            // Pull stored EventList from session variable
            theList = (EventList)Session["theList"];

            //  Search in theList for events with a property value or range
            switch (PropertyDropDown.SelectedValue)
            {
                case "TORNADO TYPE":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   TornadoTypeDropDown.SelectedValue, results);
                    break;
                case "STATE":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue, 
                                   StateDropDown.SelectedValue, results);
                    break;
                case "COUNTY":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue, 
                                   CountyTextBox.Text, results);
                    break;
                case "START AZIMUTH":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   StartAzimuthDropDown.SelectedValue, results);
                    break;
                case "START LOCATION":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   StartLocationTextBox.Text, results);
                    break;
                case "END AZIMUTH":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   EndAzimuthDropDown.SelectedValue, results);
                    break;
                case "END LOCATION":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   EndLocationTextBox.Text, results);
                    break;
                case "TIME ZONE":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   TimeZoneDropDown.SelectedValue, results);
                    break;
                case "INJURIES":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerInjuriesTextBox.Text),
                                   Convert.ToInt32(UpperInjuriesTextBox.Text), results);
                    break;
                case "FATALITIES":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerFatalitiesTextBox.Text),
                                   Convert.ToInt32(UpperFatalitiesTextBox.Text), results);
                    break;
                case "WIND SPEED":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerWindSpeedsTextBox.Text),
                                   Convert.ToInt32(UpperWindSpeedsTextBox.Text), results);
                    break;
                case "HAIL SIZE":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerHailSizeTextBox.Text),
                                   Convert.ToDouble(UpperHailSizeTextBox.Text), results);
                    break;
                case "START RANGE":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerStartRangeTextBox.Text),
                                   Convert.ToInt32(UpperStartRangeTextBox.Text), results);
                    break;
                case "END RANGE":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerEndRangeTextBox.Text),
                                   Convert.ToInt32(UpperEndRangeTextBox.Text), results);
                    break;
                case "START YEAR":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerStartYearTextBox.Text),
                                   Convert.ToInt32(UpperStartYearTextBox.Text), results);
                    break;
                case "START MONTH":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerStartMonthTextBox.Text),
                                   Convert.ToInt32(UpperStartMonthTextBox.Text), results);
                    break;
                case "START DAY":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerStartDayTextBox.Text),
                                   Convert.ToInt32(UpperStartDayTextBox.Text), results);
                    break;
                case "START TIME":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerStartTimeTextBox.Text),
                                   Convert.ToInt32(UpperStartTimeTextBox.Text), results);
                    break;
                case "END YEAR":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerEndYearTextBox.Text),
                                   Convert.ToInt32(UpperEndYearTextBox.Text), results);
                    break;
                case "END MONTH":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerEndMonthTextBox.Text),
                                   Convert.ToInt32(UpperEndMonthTextBox.Text), results);
                    break;
                case "END DAY":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerEndDayTextBox.Text),
                                   Convert.ToInt32(UpperEndDayTextBox.Text), results);
                    break;
                case "END TIME":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerEndTimeTextBox.Text),
                                   Convert.ToInt32(UpperEndTimeTextBox.Text), results);
                    break;
                case "TORNADO LENGTH":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerTornadoLengthTextBox.Text),
                                   Convert.ToDouble(UpperTornadoLengthTextBox.Text), results);
                    break;
                case "TORNADO WIDTH":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerTornadoWidthTextBox.Text),
                                   Convert.ToDouble(UpperTornadoWidthTextBox.Text), results);
                    break;
                case "START LATITUDE":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerStartLatitudeTextBox.Text),
                                   Convert.ToDouble(UpperStartLatitudeTextBox.Text), results);
                    break;
                case "START LONGITUDE":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerStartLongitudeTextBox.Text),
                                   Convert.ToDouble(UpperStartLongitudeTextBox.Text), results);
                    break;
                case "END LATITUDE":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerEndLatitudeTextBox.Text),
                                   Convert.ToDouble(UpperEndLatitudeTextBox.Text), results);
                    break;
                case "END LONGITUDE":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerEndLongitudeTextBox.Text),
                                   Convert.ToDouble(UpperEndLongitudeTextBox.Text), results);
                    break;
                case "PROPERTY DAMAGE":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDecimal(LowerPropertyDamageTextBox.Text),
                                   Convert.ToDecimal(UpperPropertyDamageTextBox.Text), results);
                    break;
                case "CROP DAMAGE":
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDecimal(LowerCropDamageTextBox.Text),
                                   Convert.ToDecimal(UpperCropDamageTextBox.Text), results);
                    break;
                case "PICK ONE":
                    break;
                default:
                    throw new ArgumentException("Property to search is invalid!");
            }

            // Display results
    }
}