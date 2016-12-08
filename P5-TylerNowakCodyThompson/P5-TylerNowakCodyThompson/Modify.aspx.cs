using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5_TylerNowakCodyThompson
{
    public partial class Modify : System.Web.UI.Page
    {
        EventList theList = new EventList();

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            // Pull stored EventList from session variable
            theList = (EventList)Session["theList"];

            // Display events in eventlist
            AllStormsList.Items.Clear();
            List<string> storms = theList.ReturnEvents();
            foreach (var storm in storms)
                AllStormsList.Items.Add(storm);

            // Set Maximum storm index
            MaxIndexTextBox.Text = Convert.ToString(theList.Count() - 1);

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
            LowerInjuriesTextBox.Visible = false;
            FatalitiesQ1Label.Visible = false;            
            LowerFatalitiesTextBox.Visible = false;          
            WindSpeedQ1Label.Visible = false;        
            LowerWindSpeedsTextBox.Visible = false;          
            HailSizeQ1Label.Visible = false;
            LowerHailSizeTextBox.Visible = false;            
            StartRangeQ1Label.Visible = false;
            LowerStartRangeTextBox.Visible = false;          
            EndRangeQ1Label.Visible = false;           
            LowerEndRangeTextBox.Visible = false;         
            StartYearQ1Label.Visible = false;           
            LowerStartYearTextBox.Visible = false;
            StartMonthQ1Label.Visible = false;
            LowerStartMonthTextBox.Visible = false;
            StartDayQ1Label.Visible = false;
            LowerStartDayTextBox.Visible = false;
            StartTimeQ1Label.Visible = false;
            LowerStartTimeTextBox.Visible = false;
            EndYearQ1Label.Visible = false;
            LowerEndYearTextBox.Visible = false;
            EndMonthQ1Label.Visible = false;
            LowerEndMonthTextBox.Visible = false;
            EndDayQ1Label.Visible = false;
            LowerEndDayTextBox.Visible = false;
            EndTimeQ1Label.Visible = false;
            LowerEndTimeTextBox.Visible = false;
            TornadoLengthQ1Label.Visible = false;
            LowerTornadoLengthTextBox.Visible = false;
            TornadoWidthQ1Label.Visible = false;
            LowerTornadoWidthTextBox.Visible = false;
            StartLatitudeQ1Label.Visible = false;
            LowerStartLatitudeTextBox.Visible = false;
            StartLongitudeQ1Label.Visible = false;
            LowerStartLongitudeTextBox.Visible = false;
            EndLatitudeQ1Label.Visible = false;
            LowerEndLatitudeTextBox.Visible = false;
            EndLongitudeQ1Label.Visible = false;
            LowerEndLongitudeTextBox.Visible = false;
            PropertyDamageQ1Label.Visible = false;
            LowerPropertyDamageTextBox.Visible = false;
            CropDamageQ1Label.Visible = false;
            LowerCropDamageTextBox.Visible = false;

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
            LowerFatalitiesRequiredFieldValidator.Visible = false;
            LowerFatalitiesRangeValidator.Visible = false;
            LowerWindSpeedsRequiredFieldValidator.Visible = false;
            LowerWindSpeedRangeValidator.Visible = false;
            LowerHailSizeRequiredFieldValidator.Visible = false;
            LowerHailSizeRangeValidator.Visible = false;
            LowerStartRangeRequiredFieldValidator.Visible = false;
            LowerStartRangeValidator.Visible = false;
            LowerEndRangeRequiredFieldValidator.Visible = false;
            LowerEndRangeValidator.Visible = false;
            LowerStartYearRequiredFieldValidator.Visible = false;
            LowerStartYearValidator.Visible = false;
            LowerStartMonthRequiredFieldValidator.Visible = false;
            LowerStartMonthValidator.Visible = false;
            LowerStartDayRequiredFieldValidator.Visible = false;
            LowerStartDayValidator.Visible = false;
            LowerStartTimeRequiredFieldValidator.Visible = false;
            LowerStartTimeValidator.Visible = false;
            LowerEndYearRequiredFieldValidator.Visible = false;
            LowerEndYearValidator.Visible = false;
            LowerEndMonthRequiredFieldValidator.Visible = false;
            LowerEndMonthValidator.Visible = false;
            LowerEndDayRequiredFieldValidator.Visible = false;
            LowerEndDayValidator.Visible = false;
            LowerEndTimeRequiredFieldValidator.Visible = false;
            LowerEndTimeValidator.Visible = false;
            LowerTornadoLengthRequiredFieldValidator.Visible = false;
            LowerTornadoLengthRangeValidator.Visible = false;
            LowerTornadoWidthRequiredFieldValidator.Visible = false;
            LowerTornadoWidthRangeValidator.Visible = false;
            LowerStartLatitudeRequiredFieldValidator.Visible = false;
            LowerStartLatitudeRangeValidator.Visible = false;
            LowerStartLongitudeRequiredFieldValidator.Visible = false;
            LowerStartLongitudeRangeValidator.Visible = false;
            LowerEndLatitudeRequiredFieldValidator.Visible = false;
            LowerEndLatitudeRangeValidator.Visible = false;
            LowerEndLongitudeRequiredFieldValidator.Visible = false;
            LowerEndLongitudeRangeValidator.Visible = false;
            LowerPropertyDamageRequiredFieldValidator.Visible = false;
            LowerPropertyDamageRangeValidator.Visible = false;
            LowerCropDamageRequiredFieldValidator.Visible = false;
            LowerCropDamageRangeValidator.Visible = false;
        }

        protected void PropertyDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void IndexTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}