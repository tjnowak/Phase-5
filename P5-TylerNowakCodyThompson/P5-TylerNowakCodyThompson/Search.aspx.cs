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
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

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

            TornadoTypeCompareValidator.Visible = false;
            StateCompareValidator.Visible = false;
            CountyRequiredFieldValidator.Visible = false;
            StartAzimuthCompareValidator.Visible = false;
            StartLocationRequiredFieldValidator.Visible = false;
            EndAzimuthCompareValidator.Visible = false;
            EndLocationRequiredFieldValidator.Visible = false;
            TimeZoneCompareValidator.Visible = false;
            LowerInjuriesRequiredFieldValidator.Visible = false;
            LowerInjuriesRangeValidator.Visible = false;
            UpperInjuriesRequiredFieldValidator.Visible = false;
            UpperInjuriesRangeValidator.Visible = false;
            UpperInjuriesCompareValidator.Visible = false;
            LowerFatalitiesRequiredFieldValidator.Visible = false;
            LowerFatalitiesRangeValidator.Visible = false;
            UpperFatalitiesRequiredFieldValidator.Visible = false;
            UpperFatalitiesRangeValidator.Visible = false;
            UpperFatalitiesCompareValidator.Visible = false;
            LowerWindSpeedsRequiredFieldValidator.Visible = false;
            LowerWindSpeedRangeValidator.Visible = false;
            UpperWindSpeedsRequiredFieldValidator.Visible = false;
            UpperWindSpeedRangeValidator.Visible = false;
            UpperWindSpeedCompareValidator.Visible = false;
            LowerHailSizeRequiredFieldValidator.Visible = false;
            LowerHailSizeRangeValidator.Visible = false;
            UpperHailSizeRequiredFieldValidator.Visible = false;
            UpperHailSizeRangeValidator.Visible = false;
            UpperHailSizeCompareValidator.Visible = false;
            LowerStartRangeRequiredFieldValidator.Visible = false;
            LowerStartRangeValidator.Visible = false;
            UpperStartRangeRequiredFieldValidator.Visible = false;
            UpperStartRangeValidator.Visible = false;
            UpperStartRangeCompareValidator.Visible = false;
            LowerEndRangeRequiredFieldValidator.Visible = false;
            LowerEndRangeValidator.Visible = false;
            UpperEndRangeRequiredFieldValidator.Visible = false;
            UpperEndRangeValidator.Visible = false;
            UpperEndRangeCompareValidator.Visible = false;
            LowerStartYearRequiredFieldValidator.Visible = false;
            LowerStartYearValidator.Visible = false;
            UpperStartYearRequiredFieldValidator.Visible = false;
            UpperStartYearValidator.Visible = false;
            UpperStartYearCompareValidator.Visible = false;
            LowerStartMonthRequiredFieldValidator.Visible = false;
            LowerStartMonthValidator.Visible = false;
            UpperStartMonthRequiredFieldValidator.Visible = false;
            UpperStartMonthValidator.Visible = false;
            UpperStartMonthCompareValidator.Visible = false;
            LowerStartDayRequiredFieldValidator.Visible = false;
            LowerStartDayValidator.Visible = false;
            UpperStartDayRequiredFieldValidator.Visible = false;
            UpperStartDayValidator.Visible = false;
            UpperStartDayCompareValidator.Visible = false;
            LowerEndYearRequiredFieldValidator.Visible = false;
            LowerEndYearValidator.Visible = false;
            UpperEndYearRequiredFieldValidator.Visible = false;
            UpperEndYearValidator.Visible = false;
            UpperEndYearCompareValidator.Visible = false;
            LowerEndMonthRequiredFieldValidator.Visible = false;
            LowerEndMonthValidator.Visible = false;
            UpperEndMonthRequiredFieldValidator.Visible = false;
            UpperEndMonthValidator.Visible = false;
            UpperEndMonthCompareValidator.Visible = false;
            LowerEndDayRequiredFieldValidator.Visible = false;
            LowerEndDayValidator.Visible = false;
            UpperEndDayRequiredFieldValidator.Visible = false;
            UpperEndDayValidator.Visible = false;
            UpperEndDayCompareValidator.Visible = false;
            LowerEndTimeRequiredFieldValidator.Visible = false;
            LowerEndTimeValidator.Visible = false;
            UpperEndTimeRequiredFieldValidator.Visible = false;
            UpperEndTimeValidator.Visible = false;
            UpperEndTimeCompareValidator.Visible = false;
            LowerTornadoLengthRequiredFieldValidator.Visible = false;
            LowerTornadoLengthRangeValidator.Visible = false;
            UpperTornadoLengthRequiredFieldValidator.Visible = false;
            UpperTornadoLengthRangeValidator.Visible = false;
            UpperTornadoLengthCompareValidator.Visible = false;
            LowerTornadoWidthRequiredFieldValidator.Visible = false;
            LowerTornadoWidthRangeValidator.Visible = false;
            UpperTornadoWidthRequiredFieldValidator.Visible = false;
            UpperTornadoWidthRangeValidator.Visible = false;
            UpperTornadoWidthCompareValidator.Visible = false;
            LowerStartLatitudeRequiredFieldValidator.Visible = false;
            LowerStartLatitudeRangeValidator.Visible = false;
            UpperStartLatitudeRequiredFieldValidator.Visible = false;
            UpperStartLatitudeRangeValidator.Visible = false;
            UpperStartLatitudeCompareValidator.Visible = false;
            LowerStartLongitudeRequiredFieldValidator.Visible = false;
            LowerStartLongitudeRangeValidator.Visible = false;
            UpperStartLatitudeRequiredFieldValidator.Visible = false;
            UpperStartLatitudeRangeValidator.Visible = false;
            UpperStartLatitudeCompareValidator.Visible = false;
            LowerEndLatitudeRequiredFieldValidator.Visible = false;
            LowerEndLatitudeRangeValidator.Visible = false;
            UpperEndLatitudeRequiredFieldValidator.Visible = false;
            UpperEndLatitudeRangeValidator.Visible = false;
            UpperEndLatitudeCompareValidator.Visible = false;
            LowerEndLongitudeRequiredFieldValidator.Visible = false;
            LowerEndLongitudeRangeValidator.Visible = false;
            UpperEndLongitudeRequiredFieldValidator.Visible = false;
            UpperEndLongitudeRangeValidator.Visible = false;
            UpperEndLongitudeCompareValidator.Visible = false;
            LowerPropertyDamageRequiredFieldValidator.Visible = false;
            LowerPropertyDamageRangeValidator.Visible = false;
            UpperPropertyDamageRequiredFieldValidator.Visible = false;
            UpperPropertyDamageRangeValidator.Visible = false;
            UpperPropertyDamageCompareValidator.Visible = false;
            LowerCropDamageRequiredFieldValidator.Visible = false;
            LowerCropDamageRangeValidator.Visible = false;
            UpperCropDamageRequiredFieldValidator.Visible = false;
            UpperCropDamageRangeValidator.Visible = false;
            UpperCropDamageCompareValidator.Visible = false;
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
                    TornadoTypeCompareValidator.Visible = true;
                    break;
                case "STATE":
                    StateQLabel.Visible = true;
                    StateDropDown.Visible = true;
                    StateCompareValidator.Visible = true;
                    break;
                case "COUNTY":
                    CountyQLabel.Visible = true;
                    CountyTextBox.Visible = true;
                    CountyRequiredFieldValidator.Visible = true;
                    break;
                case "START AZIMUTH":
                    StartAzimuthQlabel.Visible = true;
                    StartAzimuthDropDown.Visible = true;
                    StartAzimuthCompareValidator.Visible = true;
                    break;
                case "START LOCATION":
                    StartLocationQlabel.Visible = true;
                    StartLocationTextBox.Visible = true;
                    StartLocationRequiredFieldValidator.Visible = true;
                    break;
                case "END AZIMUTH":
                    EndAzimuthQLabel.Visible = true;
                    EndAzimuthDropDown.Visible = true;
                    EndAzimuthCompareValidator.Visible = true;
                    break;
                case "END LOCATION":
                    EndLocationQLabel.Visible = true;
                    EndLocationTextBox.Visible = true;
                    EndLocationRequiredFieldValidator.Visible = true;
                    break;
                case "TIME ZONE":
                    TimeZoneQLabel.Visible = true;
                    TimeZoneDropDown.Visible = true;
                    TimeZoneCompareValidator.Visible = true;
                    break;
                case "INJURIES":
                    InjuriesQ1Label.Visible = true;
                    InjuriesQ2Label.Visible = true;
                    LowerInjuriesTextBox.Visible = true;
                    UpperInjuriesTextBox.Visible = true;
                    LowerInjuriesRequiredFieldValidator.Visible = true;
                    LowerInjuriesRangeValidator.Visible = true;
                    UpperInjuriesRequiredFieldValidator.Visible = true;
                    UpperInjuriesRangeValidator.Visible = true;
                    UpperInjuriesCompareValidator.Visible = true;
                    break;
                case "FATALITIES":
                    FatalitiesQ1Label.Visible = true;
                    FatalitiesQ2Label.Visible = true;
                    LowerFatalitiesTextBox.Visible = true;
                    UpperFatalitiesTextBox.Visible = true;
                    LowerFatalitiesRequiredFieldValidator.Visible = true;
                    LowerFatalitiesRangeValidator.Visible = true;
                    UpperFatalitiesRequiredFieldValidator.Visible = true;
                    UpperFatalitiesRangeValidator.Visible = true;
                    UpperFatalitiesCompareValidator.Visible = true;
                    break;
                case "WIND SPEED":
                    WindSpeedQ1Label.Visible = true;
                    WindSpeedQ2Label.Visible = true;
                    LowerWindSpeedsTextBox.Visible = true;
                    UpperWindSpeedsTextBox.Visible = true;
                    LowerWindSpeedsRequiredFieldValidator.Visible = true;
                    LowerWindSpeedRangeValidator.Visible = true;
                    UpperWindSpeedsRequiredFieldValidator.Visible = true;
                    UpperWindSpeedRangeValidator.Visible = true;
                    UpperWindSpeedCompareValidator.Visible = true;
                    break;
                case "HAIL SIZE":
                    HailSizeQ1Label.Visible = true;
                    HailSizeQ2Label.Visible = true;
                    LowerHailSizeTextBox.Visible = true;
                    UpperHailSizeTextBox.Visible = true;
                    LowerHailSizeRequiredFieldValidator.Visible = true;
                    LowerHailSizeRangeValidator.Visible = true;
                    UpperHailSizeRequiredFieldValidator.Visible = true;
                    UpperHailSizeRangeValidator.Visible = true;
                    UpperHailSizeCompareValidator.Visible = true;
                    break;
                case "START RANGE":
                    StartRangeQ1Label.Visible = true;
                    StartRangeQ2Label.Visible = true;
                    LowerStartRangeTextBox.Visible = true;
                    UpperStartRangeTextBox.Visible = true;
                    LowerStartRangeRequiredFieldValidator.Visible = true;
                    LowerStartRangeValidator.Visible = true;
                    UpperStartRangeRequiredFieldValidator.Visible = true;
                    UpperStartRangeValidator.Visible = true;
                    UpperStartRangeCompareValidator.Visible = true;
                    break;
                case "END RANGE":
                    EndRangeQ1Label.Visible = true;
                    EndRangeQ2Label.Visible = true;
                    LowerEndRangeTextBox.Visible = true;
                    UpperEndRangeTextBox.Visible = true;
                    LowerEndRangeRequiredFieldValidator.Visible = true;
                    LowerEndRangeValidator.Visible = true;
                    UpperEndRangeRequiredFieldValidator.Visible = true;
                    UpperEndRangeValidator.Visible = true;
                    UpperEndRangeCompareValidator.Visible = true;
                    break;
                case "START YEAR":
                    StartYearQ1Label.Visible = true;
                    StartYearQ2Label.Visible = true;
                    LowerStartYearTextBox.Visible = true;
                    UpperStartYearTextBox.Visible = true;
                    LowerStartYearRequiredFieldValidator.Visible = true;
                    LowerStartYearValidator.Visible = true;
                    UpperStartYearRequiredFieldValidator.Visible = true;
                    UpperStartYearValidator.Visible = true;
                    UpperStartYearCompareValidator.Visible = true;
                    break;
                case "START MONTH":
                    StartMonthQ1Label.Visible = true;
                    StartMonthQ2Label.Visible = true;
                    LowerStartMonthTextBox.Visible = true;
                    UpperStartMonthTextBox.Visible = true;
                    LowerStartMonthRequiredFieldValidator.Visible = true;
                    LowerStartMonthValidator.Visible = true;
                    UpperStartMonthRequiredFieldValidator.Visible = true;
                    UpperStartMonthValidator.Visible = true;
                    UpperStartMonthCompareValidator.Visible = true;
                    break;
                case "START DAY":
                    StartDayQ1Label.Visible = true;
                    StartDayQ2Label.Visible = true;
                    LowerStartDayTextBox.Visible = true;
                    UpperStartDayTextBox.Visible = true;
                    LowerStartDayRequiredFieldValidator.Visible = true;
                    LowerStartDayValidator.Visible = true;
                    UpperStartDayRequiredFieldValidator.Visible = true;
                    UpperStartDayValidator.Visible = true;
                    UpperStartDayCompareValidator.Visible = true;
                    break;
                case "START TIME":
                    StartTimeQ1Label.Visible = true;
                    StartTimeQ2Label.Visible = true;
                    LowerStartTimeTextBox.Visible = true;
                    UpperStartTimeTextBox.Visible = true;
                    LowerStartTimeRequiredFieldValidator.Visible = true;
                    LowerStartTimeValidator.Visible = true;
                    UpperStartTimeRequiredFieldValidator.Visible = true;
                    UpperStartTimeValidator.Visible = true;
                    UpperStartTimeCompareValidator.Visible = true;
                    break;
                case "END YEAR":
                    EndYearQ1Label.Visible = true;
                    EndYearQ2Label.Visible = true;
                    LowerEndYearTextBox.Visible = true;
                    UpperEndYearTextBox.Visible = true;
                    LowerEndYearRequiredFieldValidator.Visible = true;
                    LowerEndYearValidator.Visible = true;
                    UpperEndYearRequiredFieldValidator.Visible = true;
                    UpperEndYearValidator.Visible = true;
                    UpperEndYearCompareValidator.Visible = true;
                    break;
                case "END MONTH":
                    EndMonthQ1Label.Visible = true;
                    EndMonthQ2Label.Visible = true;
                    LowerEndMonthTextBox.Visible = true;
                    UpperEndMonthTextBox.Visible = true;
                    LowerEndMonthRequiredFieldValidator.Visible = true;
                    LowerEndMonthValidator.Visible = true;
                    UpperEndMonthRequiredFieldValidator.Visible = true;
                    UpperEndMonthValidator.Visible = true;
                    UpperEndMonthCompareValidator.Visible = true;
                    break;
                case "END DAY":
                    EndDayQ1Label.Visible = true;
                    EndDayQ2Label.Visible = true;
                    LowerEndDayTextBox.Visible = true;
                    UpperEndDayTextBox.Visible = true;
                    LowerEndDayRequiredFieldValidator.Visible = true;
                    LowerEndDayValidator.Visible = true;
                    UpperEndDayRequiredFieldValidator.Visible = true;
                    UpperEndDayValidator.Visible = true;
                    UpperEndDayCompareValidator.Visible = true;
                    break;
                case "END TIME":
                    EndTimeQ1Label.Visible = true;
                    EndTimeQ2Label.Visible = true;
                    LowerEndTimeTextBox.Visible = true;
                    UpperEndTimeTextBox.Visible = true;
                    LowerEndTimeRequiredFieldValidator.Visible = true;
                    LowerEndTimeValidator.Visible = true;
                    UpperEndTimeRequiredFieldValidator.Visible = true;
                    UpperEndTimeValidator.Visible = true;
                    UpperEndTimeCompareValidator.Visible = true;
                    break;
                case "TORNADO LENGTH":
                    TornadoLengthQ1Label.Visible = true;
                    TornadoLengthQ2Label.Visible = true;
                    LowerTornadoLengthTextBox.Visible = true;
                    UpperTornadoLengthTextBox.Visible = true;
                    LowerTornadoLengthRequiredFieldValidator.Visible = true;
                    LowerTornadoLengthRangeValidator.Visible = true;
                    UpperTornadoLengthRequiredFieldValidator.Visible = true;
                    UpperTornadoLengthRangeValidator.Visible = true;
                    UpperTornadoLengthCompareValidator.Visible = true;
                    break;
                case "TORNADO WIDTH":
                    TornadoWidthQ1Label.Visible = true;
                    TornadoWidthQ2Label.Visible = true;
                    LowerTornadoWidthTextBox.Visible = true;
                    UpperTornadoWidthTextBox.Visible = true;
                    LowerTornadoWidthRequiredFieldValidator.Visible = true;
                    LowerTornadoWidthRangeValidator.Visible = true;
                    UpperTornadoWidthRequiredFieldValidator.Visible = true;
                    UpperTornadoWidthRangeValidator.Visible = true;
                    UpperTornadoWidthCompareValidator.Visible = true;
                    break;
                case "START LATITUDE":
                    StartLatitudeQ1Label.Visible = true;
                    StartLatitudeQ2Label.Visible = true;
                    LowerStartLatitudeTextBox.Visible = true;
                    UpperStartLatitudeTextBox.Visible = true;
                    LowerStartLatitudeRequiredFieldValidator.Visible = true;
                    LowerStartLatitudeRangeValidator.Visible = true;
                    UpperStartLatitudeRequiredFieldValidator.Visible = true;
                    UpperStartLatitudeRangeValidator.Visible = true;
                    UpperStartLatitudeCompareValidator.Visible = true;
                    break;
                case "START LONGITUDE":
                    StartLongitudeQ1Label.Visible = true;
                    StartLongitudeQ2Label.Visible = true;
                    LowerStartLongitudeTextBox.Visible = true;
                    UpperStartLongitudeTextBox.Visible = true;
                    LowerStartLongitudeRequiredFieldValidator.Visible = true;
                    LowerStartLongitudeRangeValidator.Visible = true;
                    UpperStartLatitudeRequiredFieldValidator.Visible = true;
                    UpperStartLatitudeRangeValidator.Visible = true;
                    UpperStartLatitudeCompareValidator.Visible = true;
                    break;
                case "END LATITUDE":
                    EndLatitudeQ1Label.Visible = true;
                    EndLatitudeQ2Label.Visible = true;
                    LowerEndLatitudeTextBox.Visible = true;
                    UpperEndLatitudeTextBox.Visible = true;
                    LowerEndLatitudeRequiredFieldValidator.Visible = true;
                    LowerEndLatitudeRangeValidator.Visible = true;
                    UpperEndLatitudeRequiredFieldValidator.Visible = true;
                    UpperEndLatitudeRangeValidator.Visible = true;
                    UpperEndLatitudeCompareValidator.Visible = true;
                    break;
                case "END LONGITUDE":
                    EndLongitudeQ1Label.Visible = true;
                    EndLongitudeQ2Label.Visible = true;
                    LowerEndLongitudeTextBox.Visible = true;
                    UpperEndLongitudeTextBox.Visible = true;
                    LowerEndLongitudeRequiredFieldValidator.Visible = true;
                    LowerEndLongitudeRangeValidator.Visible = true;
                    UpperEndLongitudeRequiredFieldValidator.Visible = true;
                    UpperEndLongitudeRangeValidator.Visible = true;
                    UpperEndLongitudeCompareValidator.Visible = true;
                    break;
                case "PROPERTY DAMAGE":
                    PropertyDamageQ1Label.Visible = true;
                    PropertyDamageQ2Label.Visible = true;
                    LowerPropertyDamageTextBox.Visible = true;
                    UpperPropertyDamageTextBox.Visible = true;
                    LowerPropertyDamageRequiredFieldValidator.Visible = true;
                    LowerPropertyDamageRangeValidator.Visible = true;
                    UpperPropertyDamageRequiredFieldValidator.Visible = true;
                    UpperPropertyDamageRangeValidator.Visible = true;
                    UpperPropertyDamageCompareValidator.Visible = true;
                    break;
                case "CROP DAMAGE":
                    CropDamageQ1Label.Visible = true;
                    CropDamageQ2Label.Visible = true;
                    LowerCropDamageTextBox.Visible = true;
                    UpperCropDamageTextBox.Visible = true;
                    LowerCropDamageRequiredFieldValidator.Visible = true;
                    LowerCropDamageRangeValidator.Visible = true;
                    UpperCropDamageRequiredFieldValidator.Visible = true;
                    UpperCropDamageRangeValidator.Visible = true;
                    UpperCropDamageCompareValidator.Visible = true;
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

            // Validate user input
            if (IsPostBack)
                Validate();

            // Pull stored EventList from session variable
            theList = (EventList)Session["theList"];

            //  Search in theList for events with a property value or range
            switch (PropertyDropDown.SelectedValue)
            {
                case "TORNADO TYPE":
                    TornadoTypeQLabel.Visible = true;
                    TornadoTypeDropDown.Visible = true;
                    TornadoTypeCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   TornadoTypeDropDown.SelectedValue, results);
                    break;
                case "STATE":
                    StateQLabel.Visible = true;
                    StateDropDown.Visible = true;
                    StateCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   StateDropDown.SelectedValue, results);
                    break;
                case "COUNTY":
                    CountyQLabel.Visible = true;
                    CountyTextBox.Visible = true;
                    CountyRequiredFieldValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   CountyTextBox.Text, results);
                    break;
                case "START AZIMUTH":
                    StartAzimuthQlabel.Visible = true;
                    StartAzimuthDropDown.Visible = true;
                    StartAzimuthCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   StartAzimuthDropDown.SelectedValue, results);
                    break;
                case "START LOCATION":
                    StartLocationQlabel.Visible = true;
                    StartLocationTextBox.Visible = true;
                    StartLocationRequiredFieldValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   StartLocationTextBox.Text, results);
                    break;
                case "END AZIMUTH":
                    EndAzimuthQLabel.Visible = true;
                    EndAzimuthDropDown.Visible = true;
                    EndAzimuthCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   EndAzimuthDropDown.SelectedValue, results);
                    break;
                case "END LOCATION":
                    EndLocationQLabel.Visible = true;
                    EndLocationTextBox.Visible = true;
                    EndLocationRequiredFieldValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   EndLocationTextBox.Text, results);
                    break;
                case "TIME ZONE":
                    TimeZoneQLabel.Visible = true;
                    TimeZoneDropDown.Visible = true;
                    TimeZoneCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   TimeZoneDropDown.SelectedValue, results);
                    break;
                case "INJURIES":
                    InjuriesQ1Label.Visible = true;
                    InjuriesQ2Label.Visible = true;
                    LowerInjuriesTextBox.Visible = true;
                    UpperInjuriesTextBox.Visible = true;
                    LowerInjuriesRequiredFieldValidator.Visible = true;
                    LowerInjuriesRangeValidator.Visible = true;
                    UpperInjuriesRequiredFieldValidator.Visible = true;
                    UpperInjuriesRangeValidator.Visible = true;
                    UpperInjuriesCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerInjuriesTextBox.Text),
                                   Convert.ToInt32(UpperInjuriesTextBox.Text), results);
                    break;
                case "FATALITIES":
                    FatalitiesQ1Label.Visible = true;
                    FatalitiesQ2Label.Visible = true;
                    LowerFatalitiesTextBox.Visible = true;
                    UpperFatalitiesTextBox.Visible = true;
                    LowerFatalitiesRequiredFieldValidator.Visible = true;
                    LowerFatalitiesRangeValidator.Visible = true;
                    UpperFatalitiesRequiredFieldValidator.Visible = true;
                    UpperFatalitiesRangeValidator.Visible = true;
                    UpperFatalitiesCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerFatalitiesTextBox.Text),
                                   Convert.ToInt32(UpperFatalitiesTextBox.Text), results);
                    break;
                case "WIND SPEED":
                    WindSpeedQ1Label.Visible = true;
                    WindSpeedQ2Label.Visible = true;
                    LowerWindSpeedsTextBox.Visible = true;
                    UpperWindSpeedsTextBox.Visible = true;
                    LowerWindSpeedsRequiredFieldValidator.Visible = true;
                    LowerWindSpeedRangeValidator.Visible = true;
                    UpperWindSpeedsRequiredFieldValidator.Visible = true;
                    UpperWindSpeedRangeValidator.Visible = true;
                    UpperWindSpeedCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerWindSpeedsTextBox.Text),
                                   Convert.ToInt32(UpperWindSpeedsTextBox.Text), results);
                    break;
                case "HAIL SIZE":
                    HailSizeQ1Label.Visible = true;
                    HailSizeQ2Label.Visible = true;
                    LowerHailSizeTextBox.Visible = true;
                    UpperHailSizeTextBox.Visible = true;
                    LowerHailSizeRequiredFieldValidator.Visible = true;
                    LowerHailSizeRangeValidator.Visible = true;
                    UpperHailSizeRequiredFieldValidator.Visible = true;
                    UpperHailSizeRangeValidator.Visible = true;
                    UpperHailSizeCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerHailSizeTextBox.Text),
                                   Convert.ToDouble(UpperHailSizeTextBox.Text), results);
                    break;
                case "START RANGE":
                    StartRangeQ1Label.Visible = true;
                    StartRangeQ2Label.Visible = true;
                    LowerStartRangeTextBox.Visible = true;
                    UpperStartRangeTextBox.Visible = true;
                    LowerStartRangeRequiredFieldValidator.Visible = true;
                    LowerStartRangeValidator.Visible = true;
                    UpperStartRangeRequiredFieldValidator.Visible = true;
                    UpperStartRangeValidator.Visible = true;
                    UpperStartRangeCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerStartRangeTextBox.Text),
                                   Convert.ToInt32(UpperStartRangeTextBox.Text), results);
                    break;
                case "END RANGE":
                    EndRangeQ1Label.Visible = true;
                    EndRangeQ2Label.Visible = true;
                    LowerEndRangeTextBox.Visible = true;
                    UpperEndRangeTextBox.Visible = true;
                    LowerEndRangeRequiredFieldValidator.Visible = true;
                    LowerEndRangeValidator.Visible = true;
                    UpperEndRangeRequiredFieldValidator.Visible = true;
                    UpperEndRangeValidator.Visible = true;
                    UpperEndRangeCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerEndRangeTextBox.Text),
                                   Convert.ToInt32(UpperEndRangeTextBox.Text), results);
                    break;
                case "START YEAR":
                    StartTimeQ1Label.Visible = true;
                    StartTimeQ2Label.Visible = true;
                    LowerStartTimeTextBox.Visible = true;
                    UpperStartTimeTextBox.Visible = true;
                    LowerStartTimeRequiredFieldValidator.Visible = true;
                    LowerStartTimeValidator.Visible = true;
                    UpperStartTimeRequiredFieldValidator.Visible = true;
                    UpperStartTimeValidator.Visible = true;
                    UpperStartTimeCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerStartYearTextBox.Text),
                                   Convert.ToInt32(UpperStartYearTextBox.Text), results);
                    break;
                case "START MONTH":
                    StartMonthQ1Label.Visible = true;
                    StartMonthQ2Label.Visible = true;
                    LowerStartMonthTextBox.Visible = true;
                    UpperStartMonthTextBox.Visible = true;
                    LowerStartMonthRequiredFieldValidator.Visible = true;
                    LowerStartMonthValidator.Visible = true;
                    UpperStartMonthRequiredFieldValidator.Visible = true;
                    UpperStartMonthValidator.Visible = true;
                    UpperStartMonthCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerStartMonthTextBox.Text),
                                   Convert.ToInt32(UpperStartMonthTextBox.Text), results);
                    break;
                case "START DAY":
                    StartDayQ1Label.Visible = true;
                    StartDayQ2Label.Visible = true;
                    LowerStartDayTextBox.Visible = true;
                    UpperStartDayTextBox.Visible = true;
                    LowerStartDayRequiredFieldValidator.Visible = true;
                    LowerStartDayValidator.Visible = true;
                    UpperStartDayRequiredFieldValidator.Visible = true;
                    UpperStartDayValidator.Visible = true;
                    UpperStartDayCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerStartDayTextBox.Text),
                                   Convert.ToInt32(UpperStartDayTextBox.Text), results);
                    break;
                case "START TIME":
                    StartTimeQ1Label.Visible = true;
                    StartTimeQ2Label.Visible = true;
                    LowerStartTimeTextBox.Visible = true;
                    UpperStartTimeTextBox.Visible = true;
                    LowerStartTimeRequiredFieldValidator.Visible = true;
                    LowerStartTimeValidator.Visible = true;
                    UpperStartTimeRequiredFieldValidator.Visible = true;
                    UpperStartTimeValidator.Visible = true;
                    UpperStartTimeCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerStartTimeTextBox.Text),
                                   Convert.ToInt32(UpperStartTimeTextBox.Text), results);
                    break;
                case "END YEAR":
                    EndYearQ1Label.Visible = true;
                    EndYearQ2Label.Visible = true;
                    LowerEndYearTextBox.Visible = true;
                    UpperEndYearTextBox.Visible = true;
                    LowerEndYearRequiredFieldValidator.Visible = true;
                    LowerEndYearValidator.Visible = true;
                    UpperEndYearRequiredFieldValidator.Visible = true;
                    UpperEndYearValidator.Visible = true;
                    UpperEndYearCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerEndYearTextBox.Text),
                                   Convert.ToInt32(UpperEndYearTextBox.Text), results);
                    break;
                case "END MONTH":
                    EndMonthQ1Label.Visible = true;
                    EndMonthQ2Label.Visible = true;
                    LowerEndMonthTextBox.Visible = true;
                    UpperEndMonthTextBox.Visible = true;
                    LowerEndMonthRequiredFieldValidator.Visible = true;
                    LowerEndMonthValidator.Visible = true;
                    UpperEndMonthRequiredFieldValidator.Visible = true;
                    UpperEndMonthValidator.Visible = true;
                    UpperEndMonthCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerEndMonthTextBox.Text),
                                   Convert.ToInt32(UpperEndMonthTextBox.Text), results);
                    break;
                case "END DAY":
                    EndDayQ1Label.Visible = true;
                    EndDayQ2Label.Visible = true;
                    LowerEndDayTextBox.Visible = true;
                    UpperEndDayTextBox.Visible = true;
                    LowerEndDayRequiredFieldValidator.Visible = true;
                    LowerEndDayValidator.Visible = true;
                    UpperEndDayRequiredFieldValidator.Visible = true;
                    UpperEndDayValidator.Visible = true;
                    UpperEndDayCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerEndDayTextBox.Text),
                                   Convert.ToInt32(UpperEndDayTextBox.Text), results);
                    break;
                case "END TIME":
                    EndTimeQ1Label.Visible = true;
                    EndTimeQ2Label.Visible = true;
                    LowerEndTimeTextBox.Visible = true;
                    UpperEndTimeTextBox.Visible = true;
                    LowerEndTimeRequiredFieldValidator.Visible = true;
                    LowerEndTimeValidator.Visible = true;
                    UpperEndTimeRequiredFieldValidator.Visible = true;
                    UpperEndTimeValidator.Visible = true;
                    UpperEndTimeCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToInt32(LowerEndTimeTextBox.Text),
                                   Convert.ToInt32(UpperEndTimeTextBox.Text), results);
                    break;
                case "TORNADO LENGTH":
                    TornadoLengthQ1Label.Visible = true;
                    TornadoLengthQ2Label.Visible = true;
                    LowerTornadoLengthTextBox.Visible = true;
                    UpperTornadoLengthTextBox.Visible = true;
                    LowerTornadoLengthRequiredFieldValidator.Visible = true;
                    LowerTornadoLengthRangeValidator.Visible = true;
                    UpperTornadoLengthRequiredFieldValidator.Visible = true;
                    UpperTornadoLengthRangeValidator.Visible = true;
                    UpperTornadoLengthCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerTornadoLengthTextBox.Text),
                                   Convert.ToDouble(UpperTornadoLengthTextBox.Text), results);
                    break;
                case "TORNADO WIDTH":
                    TornadoWidthQ1Label.Visible = true;
                    TornadoWidthQ2Label.Visible = true;
                    LowerTornadoWidthTextBox.Visible = true;
                    UpperTornadoWidthTextBox.Visible = true;
                    LowerTornadoWidthRequiredFieldValidator.Visible = true;
                    LowerTornadoWidthRangeValidator.Visible = true;
                    UpperTornadoWidthRequiredFieldValidator.Visible = true;
                    UpperTornadoWidthRangeValidator.Visible = true;
                    UpperTornadoWidthCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerTornadoWidthTextBox.Text),
                                   Convert.ToDouble(UpperTornadoWidthTextBox.Text), results);
                    break;
                case "START LATITUDE":
                    StartLatitudeQ1Label.Visible = true;
                    StartLatitudeQ2Label.Visible = true;
                    LowerStartLatitudeTextBox.Visible = true;
                    UpperStartLatitudeTextBox.Visible = true;
                    LowerStartLatitudeRequiredFieldValidator.Visible = true;
                    LowerStartLatitudeRangeValidator.Visible = true;
                    UpperStartLatitudeRequiredFieldValidator.Visible = true;
                    UpperStartLatitudeRangeValidator.Visible = true;
                    UpperStartLatitudeCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerStartLatitudeTextBox.Text),
                                   Convert.ToDouble(UpperStartLatitudeTextBox.Text), results);
                    break;
                case "START LONGITUDE":
                    StartLongitudeQ1Label.Visible = true;
                    StartLongitudeQ2Label.Visible = true;
                    LowerStartLongitudeTextBox.Visible = true;
                    UpperStartLongitudeTextBox.Visible = true;
                    LowerStartLongitudeRequiredFieldValidator.Visible = true;
                    LowerStartLongitudeRangeValidator.Visible = true;
                    UpperStartLatitudeRequiredFieldValidator.Visible = true;
                    UpperStartLatitudeRangeValidator.Visible = true;
                    UpperStartLatitudeCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerStartLongitudeTextBox.Text),
                                   Convert.ToDouble(UpperStartLongitudeTextBox.Text), results);
                    break;
                case "END LATITUDE":
                    EndLatitudeQ1Label.Visible = true;
                    EndLatitudeQ2Label.Visible = true;
                    LowerEndLatitudeTextBox.Visible = true;
                    UpperEndLatitudeTextBox.Visible = true;
                    LowerEndLatitudeRequiredFieldValidator.Visible = true;
                    LowerEndLatitudeRangeValidator.Visible = true;
                    UpperEndLatitudeRequiredFieldValidator.Visible = true;
                    UpperEndLatitudeRangeValidator.Visible = true;
                    UpperEndLatitudeCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerEndLatitudeTextBox.Text),
                                   Convert.ToDouble(UpperEndLatitudeTextBox.Text), results);
                    break;
                case "END LONGITUDE":
                    EndLongitudeQ1Label.Visible = true;
                    EndLongitudeQ2Label.Visible = true;
                    LowerEndLongitudeTextBox.Visible = true;
                    UpperEndLongitudeTextBox.Visible = true;
                    LowerEndLongitudeRequiredFieldValidator.Visible = true;
                    LowerEndLongitudeRangeValidator.Visible = true;
                    UpperEndLongitudeRequiredFieldValidator.Visible = true;
                    UpperEndLongitudeRangeValidator.Visible = true;
                    UpperEndLongitudeCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDouble(LowerEndLongitudeTextBox.Text),
                                   Convert.ToDouble(UpperEndLongitudeTextBox.Text), results);
                    break;
                case "PROPERTY DAMAGE":
                    PropertyDamageQ1Label.Visible = true;
                    PropertyDamageQ2Label.Visible = true;
                    LowerPropertyDamageTextBox.Visible = true;
                    UpperPropertyDamageTextBox.Visible = true;
                    LowerPropertyDamageRequiredFieldValidator.Visible = true;
                    LowerPropertyDamageRangeValidator.Visible = true;
                    UpperPropertyDamageRequiredFieldValidator.Visible = true;
                    UpperPropertyDamageRangeValidator.Visible = true;
                    UpperPropertyDamageCompareValidator.Visible = true;
                    theList.Search(StormTypeDropDown.SelectedValue, PropertyDropDown.SelectedValue,
                                   Convert.ToDecimal(LowerPropertyDamageTextBox.Text),
                                   Convert.ToDecimal(UpperPropertyDamageTextBox.Text), results);
                    break;
                case "CROP DAMAGE":
                    CropDamageQ1Label.Visible = true;
                    CropDamageQ2Label.Visible = true;
                    LowerCropDamageTextBox.Visible = true;
                    UpperCropDamageTextBox.Visible = true;
                    LowerCropDamageRequiredFieldValidator.Visible = true;
                    LowerCropDamageRangeValidator.Visible = true;
                    UpperCropDamageRequiredFieldValidator.Visible = true;
                    UpperCropDamageRangeValidator.Visible = true;
                    UpperCropDamageCompareValidator.Visible = true;
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
            ResultsListBox.Items.Clear();
            if (results.Count() == 0)
                ResultsListBox.Items.Add("The search returned no results.");
            else
                for (int index = 0; index < results.Count(); index++)
                {
                    ResultsListBox.Items.Add("*****************************************" +
                                             "*****************************************\n");
                    ResultsListBox.Items.Add(results.GetEventFromList(index).ToString());
                }
        }
    }
}