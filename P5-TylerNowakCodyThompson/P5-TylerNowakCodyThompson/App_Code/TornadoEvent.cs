/**********************************************************************************************************
Tyler Nowak & Cody Thompson
C490
Phase 5
 
This class stores details about a tornado weather event.
**********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_TylerNowakCodyThompson
{
    // Stores information about a tornado event
    class TornadoEvent : Event
    {
        private static readonly List<string> TORNADO_TYPES =      // list of all types of tornados
            new List<string> { "EF0", "EF1", "EF2", "EF3", "EF4", "EF5" };

        private string tornadoType;             // f-scale type indicating tornado severity 
        private double tornadoLength;           // length of tornado segment in miles
        private double tornadoWidth;            // width of tornado in yards
        private string eventType;               // type of storm (TORNADO)

        // Property to get/set the magnitude of a tornado using the f-scale
        public string TornadoType
        {
            get
            {
                return tornadoType;
            }
            set
            {
                if (TORNADO_TYPES.Contains(value.ToUpper()))    // type must be in TORNADO_TYPES list
                    tornadoType = value.ToUpper();
                else
                    throw new ArgumentException("Invalid tornado type!");
            }
        }

        // Property to get/set the length of a tornado (miles)
        public double TornadoLength
        {
            get
            {
                return tornadoLength;
            }
            set
            {
                if (value >= 0)                   // length must be '+'
                    tornadoLength = value;
                else
                    throw new ArgumentException("Tornado length must be >= 0!");
            }
        }

        // Property to get/set the width of a tornado (yards)
        public double TornadoWidth
        {
            get
            {
                return tornadoWidth;
            }
            set
            {
                if (value >= 0)                   // width must be '+'
                    tornadoWidth = value;
                else
                    throw new ArgumentException("Tornado width must be >= 0!");
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
                if (value.ToUpper() == "TORNADO")              // can only be tornado
                    eventType = value.ToUpper();
                else
                    throw new ArgumentException("Invalid event-type!");
            }
        }

        // Modify a TornadoEvent property.  Returns 0 if successful or -1 
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
                case "TORNADO TYPE":
                    // Try to set property
                    try { TornadoType = propValue; }
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
                case "TORNADO LENGTH":
                    // Try to set property
                    try { TornadoLength = Convert.ToDouble(propValue); }
                    catch (ArgumentException e) { excep = e; }
                    break;
                case "TORNADO WIDTH":
                    // Try to set property
                    try { TornadoWidth = Convert.ToDouble(propValue); }
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

        // Default constructor
        public TornadoEvent()
        {
            EventType = "TORNADO";
        }

        // Get a string of formatted TornadoEvent properties
        public override string ToString()
        {
            return string.Format("{0}\nTornado Type:        {1}\n" +
                                 "Tornado Length:      {2} miles\n" +
                                 "Tornado Width:       {3} yards",
                                 base.ToString(), TornadoType,
                                 TornadoLength, TornadoWidth);
        }
    }
}
