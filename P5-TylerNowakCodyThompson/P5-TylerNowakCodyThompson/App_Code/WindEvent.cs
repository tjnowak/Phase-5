/**********************************************************************************************************
Tyler Nowak & Cody Thompson
C490
Phase 4
 
This class stores details about a weather event that involves wind.
**********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_TylerNowak_CodyThompson
{
    // Stores information about a wind event
    class WindEvent : Event
    {
        private int windspeed;                  // windspeed (in knots) associated with an event
        private string eventType;               // type of storm

        // Property to get/set the windspeed recorded during a storm event
        public int Windspeed
        {
            get
            {
                return windspeed;
            }
            set
            {
                if (value >= 0)                 // must be a '+' value 
                    windspeed = value;
                else
                    throw new ArgumentException("Windspeed must be >= 0!");
            }
        }

        // Property to get/set the type of storm event
        public override string EventType
        {
            get
            {
                return eventType;
            }
            set
            {
                if (value.ToUpper() == "THUNDERSTORM WIND" ||          // only select types are
                    value.ToUpper() == "MARINE THUNDERSTORM WIND" ||   // wind events
                    value.ToUpper() == "MARINE STRONG WIND" ||
                    value.ToUpper() == "MARINE HIGH WIND" ||
                    value.ToUpper() == "STRONG WIND")              
                    eventType = value.ToUpper();
                else
                    throw new ArgumentException("Invalid event-type!");
            }
        }

        // Modify a WindEvent property.  Returns 0 if successful or -1 
        // if unsuccessful.
        public override int Modify(string property, string propValue)
        {
            ArgumentException excep = null;           // holds an exception that is thrown

            switch (property.ToUpper())
            {
                case "EVENT TYPE":
                    // Try to set property
                    try { EventType = propValue; }
                    catch (ArgumentException e) { excep = e; }  // set excep if exception thrown
                    break;
                case "EPISODE DESCRIPTION":
                    // Try to set property
                    try { EpisodeDesc = propValue; }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "EVENT DESCRIPTION":
                    // Try to set property
                    try { EventDesc = propValue; }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "STATE":
                    // Try to set property
                    try { location.State = propValue; }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "COUNTY":
                    // Try to set property
                    try { location.County = propValue; }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "START AZIMUTH":
                    // Try to set property
                    try { location.BeginAzimuth = propValue; }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "START LOCATION":
                    // Try to set property
                    try { location.BeginLocation = propValue; }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "END AZIMUTH":
                    // Try to set property
                    try { location.EndAzimuth = propValue; }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "END LOCATION":
                    // Try to set property
                    try { location.EndLocation = propValue; }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "TIME ZONE":
                    // Try to set property
                    try { dateTime.Timezone = propValue; }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "INJURIES":
                    // Try to set property
                    try { Injuries = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "FATALITIES":
                    // Try to set property
                    try { Deaths = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "WIND SPEED":
                    // Try to set property
                    try { Windspeed = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "START RANGE":
                    // Try to set property
                    try { location.BeginRange = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "END RANGE":
                    // Try to set property
                    try { location.EndRange = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "START YEAR":
                    // Try to set property
                    try { dateTime.BeginYear = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "START MONTH":
                    // Try to set property
                    try { dateTime.BeginMonth = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "START DAY":
                    // Try to set property
                    try { dateTime.BeginDay = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "START TIME":
                    // Try to set property
                    try { dateTime.BeginTime = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "END YEAR":
                    // Try to set property
                    try { dateTime.EndYear = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "END MONTH":
                    // Try to set property
                    try { dateTime.EndMonth = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "END DAY":
                    // Try to set property
                    try { dateTime.EndDay = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "END TIME":
                    // Try to set property
                    try { dateTime.EndTime = Convert.ToInt32(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "START LATITUDE":
                    // Try to set property
                    try { location.BeginLat = Convert.ToDouble(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "START LONGITUDE":
                    // Try to set property
                    try { location.BeginLong = Convert.ToDouble(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "END LATITUDE":
                    // Try to set property
                    try { location.EndLat = Convert.ToDouble(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "END LONGITUDE":
                    // Try to set property
                    try { location.EndLong = Convert.ToDouble(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "PROPERTY DAMAGE":
                    // Try to set property
                    try { PropertyDamage = Convert.ToDecimal(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "CROP DAMAGE":
                    // Try to set property
                    try { CropDamage = Convert.ToDecimal(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                default:
                    // Error if property entered is not a real property
                    Console.WriteLine("Property to modify is invalid!\n\n");
                    return -1;
            }

            // Check if there were errors
            if (excep != null)
            {
                Console.WriteLine("Could not modify property: {0}", property);
                Console.WriteLine(excep.Message + "\n");
                return -1;         // if there were errors
            }
            return 0;              // if property set correctly
        }

        // Get a string of formatted WindEvent properties
        public override string ToString()
        {
            return string.Format("{0}\nWind Speed:          {1} knots",
                                 base.ToString(), Windspeed);
        }
    }
}
