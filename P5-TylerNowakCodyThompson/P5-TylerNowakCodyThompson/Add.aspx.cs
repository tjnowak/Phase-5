using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5_TylerNowakCodyThompson
{
    public partial class Add : System.Web.UI.Page
    {
        EventList theList = new EventList();
        Event anEvent;

        protected void Page_Load(object sender, EventArgs e)
        {
            theList = (EventList)Session["theList"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Main.aspx");
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            //Check which type to make anEvent
            if (StormTypeDropdown.SelectedIndex == 18)
                anEvent = new HailEvent();
            else if (StormTypeDropdown.SelectedIndex == 39)
                anEvent = new TornadoEvent();
            else if (StormTypeDropdown.SelectedIndex == 38 ||
                     StormTypeDropdown.SelectedIndex == 32 ||
                     StormTypeDropdown.SelectedIndex == 31 ||
                     StormTypeDropdown.SelectedIndex == 30 ||
                     StormTypeDropdown.SelectedIndex == 37)
                anEvent = new WindEvent();
            else
                anEvent = new Event();

            //Hail and Tornado are auto set properties since they can only have their own type
            if (!(anEvent is HailEvent) &&
                !(anEvent is TornadoEvent))
            {
                try { anEvent.EventType = StormTypeDropdown.SelectedValue.ToUpper(); }
                catch (ArgumentException N)
                {
                    Console.WriteLine(N.Message + "\n");
                }
            }

            // Set BeginYear
            anEvent.dateTime.BeginYear = Convert.ToInt32(StartYearDropDownList.SelectedValue);
            
            // Set BeginMonth
            anEvent.dateTime.BeginMonth = (StartMonthDropDown.SelectedIndex+1);

            // Set BeginDay
            anEvent.dateTime.BeginDay = StartDayDropDown.SelectedIndex;

            // Set BeginTime
            anEvent.dateTime.BeginTime = Convert.ToInt32(StartTimeTextBox.Text);

            // Set EndYear
            anEvent.dateTime.EndYear = Convert.ToInt32(EndYearDropDownList.SelectedValue);

            // Set EndMonth
            anEvent.dateTime.EndMonth = (EndMonthDropDown.SelectedIndex + 1);

            // Set EndDay
            anEvent.dateTime.EndDay = EndDayDropDown.SelectedIndex;

            // Set EndTime
            anEvent.dateTime.EndTime = Convert.ToInt32(EndTimeTextBox.Text);

            // Set State
            anEvent.location.State = SelectStateDropDown.SelectedValue;

            // Set County
            anEvent.location.County = CountyTextBox.Text;

            // Set TimeZone
            anEvent.dateTime.Timezone = TimeZoneDropDown.SelectedValue;


        }
    }
}