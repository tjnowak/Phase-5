/**********************************************************************************************************
 Tyler Nowak & Cody Thompson
 C490
 Phase 4
 
 This class stores details about an event of inclement weather.
 *********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_TylerNowakCodyThompson

{
    // Stores information about a single weather event
    class Event
    {
        private static readonly List<string> STORM_TYPES =        // list of all possible event types
            new List<string> {"ASTRONOMICAL LOW TIDE", "AVALANCHE", "BLIZZARD", 
                              "COASTAL FLOOD", "COLD/WIND CHILL", "DEBRIS FLOW",
                              "DENSE FOG", "DENSE SMOKE", "DROUGHT", "DUST DEVIL",
                              "DUST STORM", "EXCESSIVE HEAT", "EXTREME COLD/WIND CHILL",
                              "FLASH FLOOD", "FLOOD", "FROST/FREEZE", "FUNNEL CLOUD",
                              "FREEZING FOG", "HAIL", "HEAT", "HEAVY RAIN", "HEAVY SNOW",
                              "HIGH SURF", "HIGH WIND", "HURRICANE", "ICE STORM",
                              "LAKE-EFFECT SNOW", "LAKESHORE FLOOD", "LIGHTNING",
                              "MARINE HAIL", "MARINE HIGH WIND", "MARINE STRONG WIND",
                              "MARINE THUNDERSTORM WIND", "RIP CURRENT", "SEICHE",
                              "SLEET", "STORM SURGE/TIDE", "STRONG WIND", 
                              "THUNDERSTORM WIND", "TORNADO", "TROPICAL DEPRESSION",
                              "TROPICAL STORM", "TSUNAMI", "VOLCANIC ASH", "WATERSPOUT",
                              "WILDFIRE", "WINTER STORM", "WINTER WEATHER"};


        private static readonly List<string> FIELD_NAMES =    // list of all possible field names
            new List<string> {"EVENT TYPE", "EPISODE DESCRIPTION", "EVENT DESCRIPTION",
                              "TORNADO TYPE", "STATE", "COUNTY", "START AZIMUTH", "START LOCATION",
                              "END AZIMUTH", "END LOCATION", "TIME ZONE", "INJURIES", "FATALITIES",
                              "WIND SPEED", "HAIL SIZE", "START RANGE", "END RANGE", "START YEAR",
                              "START MONTH", "START DAY", "START TIME", "END YEAR", "END MONTH",
                              "END DAY", "END TIME", "TORNADO LENGTH", "TORNADO WIDTH",
                              "START LATITUDE", "START LONGITUDE", "END LATITUDE", "END LONGITUDE", 
                              "PROPERTY DAMAGE", "CROP DAMAGE"};

        private static int globalID = 1;        // holds next ID to be assigned to an event 

        private string eventType;               // type of storm (ex: flood)
        private string episodeDesc;             // desc. of episode in which a storm event occurred
        private string eventDesc;               // desc. of a particular storm event
        private int injuries;                   // number of people injured by a storm event
        private int deaths;                     // number of people killed by a storm event
        private decimal propertyDamage;         // property damage (in dollars) caused by an event
        private decimal cropDamage;             // crop damage (in dollars) caused by an event

        public EventLocation location = new EventLocation();
        public EventDateTime dateTime = new EventDateTime();
        
        // Property to get/set an unique ID to an event
        public int DistinctID { get; private set; } 
        
        // Property to get/set the global ID for the next event
        private static int GlobalID
        {
            get
            {
                return globalID;
            }
            set
            {
                if (value > globalID)                     // new ID must be > old ID
                    globalID = value;
                else
                    throw new ArgumentOutOfRangeException("Invalid globalID!");
            }
        }

        // Default Constructor
        public Event()
        {
            // Set event ID
            DistinctID = GlobalID;
            // Increment global ID
            try { GlobalID++; }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message + "\n");
            }
        }

        // Property to get/set the type of storm event
        public virtual string EventType
        {
            get
            {
                return eventType;
            }
            set
            {
                if (STORM_TYPES.Contains(value.ToUpper()) &&  // must be in the STORM_TYPES list
                    value.ToUpper() != "HAIL" &&              
                    value.ToUpper() != "TORNADO" &&           // excludes types in derived classes
                    value.ToUpper() != "THUNDERSTORM WIND" &&
                    value.ToUpper() != "MARINE THUNDERSTORM WIND" &&
                    value.ToUpper() != "MARINE STRONG WIND" &&
                    value.ToUpper() != "MARINE HIGH WIND" &&
                    value.ToUpper() != "STRONG WIND")
                    eventType = value.ToUpper();
                else
                    throw new ArgumentException("Invalid event-type!");
            }
        }

        // Property to get/set the description of the episode encompassing a storm event
        public string EpisodeDesc
        {
            get
            {
                return episodeDesc;
            }
            set
            {
                episodeDesc = value;
            }
        }

        // Property to get/set the description of a storm event
        public string EventDesc
        {
            get
            {
                return eventDesc;
            }
            set
            {
                eventDesc = value;
            }
        }

        // Property to get/set the number of injuries due to a storm event
        public int Injuries
        {
            get
            {
                return injuries;
            }
            set
            {
                if (value >= 0)                   // can only have '+' number of injuries
                    injuries = value;
                else
                    throw new ArgumentException("Number of injuries must be >= 0!");
            }
        }

        // Property to get/set the number of fatalities due to a storm event
        public int Deaths
        {
            get
            {
                return deaths;
            }
            set
            {
                if (value >= 0)                  // can only have '+' number of deaths
                    deaths = value;
                else
                    throw new ArgumentException("Number of deaths must be >= 0!");
            }
        }

        // Property to get/set the dollar amount of property damage caused by a storm event
        public decimal PropertyDamage
        {
            get
            {
                return propertyDamage;
            }
            set
            {
                if (value >= 0)                 // must be a '+' amount of dollars
                    propertyDamage = value;
                else
                    throw new ArgumentException("Property damage must be >= 0!");
            }
        }

        // Property to get/set the dollar amount of crop damage caused by a storm event
        public decimal CropDamage
        {
            get
            {
                return cropDamage;
            }
            set
            {
                if (value >= 0)                 // must be a '+' amount
                    cropDamage = value; 
                else
                    throw new ArgumentException("Crop damage must be >= 0!");
            }
        }

        // Display a list of all possible storm types
        public static void DisplayStormTypes()
        {
            Console.WriteLine("Here is a list of all the storm types:\n");
            foreach (var type in STORM_TYPES)
                Console.WriteLine(type);
            Console.Write("\n");
        }

        // Return the list of all possible storm types
        public static List<string> ReturnStormTypes()
        {
            return STORM_TYPES;
        }

        // Display a list of all possible field names
        public static void DisplayFieldNames()
        {
            Console.WriteLine("Here is a list of all the field names:\n");
            foreach (var name in FIELD_NAMES)
                Console.WriteLine(name);
            Console.Write("\n");
        }

        //Return the list of all possible field names
        public static List<string> ReturnFieldNames()
        {
            return FIELD_NAMES;
        }

        // Modify an Event property.  Returns 0 if successful or -1 
        // if unsuccessful.
        public virtual int Modify(string property, string propValue)
        {
            ArgumentException excep = null;           // holds an exception that is thrown

            switch (property.ToUpper())
            {
                case "EVENT TYPE":
                    // Try to set property
                    try {EventType = propValue;}
                    catch (ArgumentException e) {excep = e;}  // set excep if exception thrown
                    break;             
                case "EPISODE DESCRIPTION":
                    // Try to set property
                    try {EpisodeDesc = propValue;}
                    catch (ArgumentException e) {excep = e;}
                    break; 
                case "EVENT DESCRIPTION":
                    // Try to set property
                    try {EventDesc = propValue;}
                    catch (ArgumentException e) {excep = e;}
                    break; 
                case "STATE":
                    // Try to set property
                    try {location.State = propValue;}
                    catch (ArgumentException e) {excep = e;}
                    break; 
                case "COUNTY":
                    // Try to set property
                    try {location.County = propValue;}
                    catch (ArgumentException e) {excep = e;}
                    break;
                case "START AZIMUTH":
                    // Try to set property
                    try {location.BeginAzimuth = propValue;}
                    catch (ArgumentException e) {excep = e;}
                    break;
                case "START LOCATION":
                    // Try to set property
                    try {location.BeginLocation = propValue;}
                    catch (ArgumentException e) {excep = e;}
                    break;
                case "END AZIMUTH":
                    // Try to set property
                    try {location.EndAzimuth = propValue;}
                    catch (ArgumentException e) {excep = e;}
                    break;
                case "END LOCATION":
                    // Try to set property
                    try {location.EndLocation = propValue;}
                    catch (ArgumentException e) {excep = e;}
                    break;
                case "TIME ZONE":
                    // Try to set property
                    try {dateTime.Timezone = propValue;}
                    catch (ArgumentException e) {excep = e;}
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


        // Get a string of formatted Event properties
        public override string ToString()
        {
            return string.Format("Event Type:          {0}\n" +
                                 ((EpisodeDesc != null) ? "Episode Description: {1}\n" : "") +
                                 ((EventDesc != null) ? "Event Description:   {2}\n" : "") +
                                 "Injuries:            {3}\n" +
                                 "Fatalities:          {4}\n" +
                                 "Property Damage:     ${5}\n" +
                                 "Crop Damage:         ${6}\n" +
                                 "{7}\n{8}",
                                 EventType, EpisodeDesc, EventDesc,
                                 Injuries, Deaths, PropertyDamage, 
                                 CropDamage, location, dateTime);
        }

        // Stores information about the location in the U.S. of a storm event
        public class EventLocation
        {
            private static readonly List<string> STATES =     // list of all states/regions in U.S.
                new List<string> {"ALABAMA", "ALASKA", "AMERICAN SAMOA", "ARIZONA",
                                  "ARKANSAS", "ATLANTIC NORTH", "ATLANTIC SOUTH",
                                  "CALIFORNIA", "COLORADO", "CONNECTICUT", "DELAWARE",
                                  "DISTRICT OF COLUMBIA", "E PACIFIC", "FLORIDA",
                                  "GEORGIA", "GUAM", "GULF OF MEXICO", "HAWAII",
                                  "HAWAII WATERS", "IDAHO", "ILLINOIS", "INDIANA",
                                  "IOWA", "KANSAS", "KENTUCKY", "LAKE ERIE",
                                  "LAKE HURON", "LAKE MICHIGAN", "LAKE ONTARIO",
                                  "LAKE ST CLAIR", "LAKE SUPERIOR", "LOUISIANA",
                                  "MAINE", "MARYLAND", "MASSACHUSETTS", "MICHIGAN",
                                  "MINNESOTA", "MISSISSIPPI", "MISSOURI", "MONTANA",
                                  "NEBRASKA", "NEVADA", "NEW HAMPSHIRE", "NEW JERSEY",
                                  "NEW MEXICO", "NEW YORK", "NORTH CAROLINA",
                                  "NORTH DAKOTA", "OHIO", "OKLAHOMA", "OREGON",
                                  "PENNSYLVANIA", "PUERTO RICO", "RHODE ISLAND", 
                                  "SOUTH CAROLINA", "SOUTH DAKOTA", "TENNESSEE",
                                  "TEXAS", "UTAH", "VERMONT", "VIRGIN ISLANDS", 
                                  "VIRGINIA", "WASHINGTON", "WEST VIRGINIA",
                                  "WISCONSIN", "WYOMING"};

            private static readonly List<string> AZIMUTHS =    // list of possible azimuth directions
                new List<string> {"E", "ENE", "ESE", "N", "NE", "NNE", "NNW", "NW", "S",
                                  "SE", "SSE", "SSW", "SW", "W", "WNW", "WSW"};

            private string state;                  // state/region an event occurred in
            private string county;                 // county/zone/marine an event occurred in
            private int beginRange;                // miles an event began from a city/airport/lake center
            private string beginAzimuth;           // beginning compass direction from a city/airport/lake
            private string beginLocation;          // center from which beginning range is calculated
            private double beginLat;                // Latitude where an event began (in degrees)
            private double beginLong;               // Longitude where an event began (in degrees)
            private int endRange;                  // miles an event ended from a city/airport/lake
            private string endAzimuth;             // ending compass direction from a city/airport/lake
            private string endLocation;            // center from which ending range is calculated
            private double endLat;                  // Latitude where an event ended (in degrees)
            private double endLong;                 // Longitude where an event ended (in degrees)

            // Property to get/set state an event occurred in
            public string State
            {
                get
                {
                    return state;
                }
                set
                {
                    if (STATES.Contains(value.ToUpper()))  // entered state must be in STATES list
                        state = value.ToUpper();           // store state in all caps
                    else
                        throw new ArgumentException("Not a valid state/region!");
                }
            }

            // Property to get/set county an event occurred in
            public string County
            {
                get
                {
                    return county;
                }
                set
                {                                       // can't compare with list of counties
                    county = value.ToUpper();           // over 3,000 possible counties!
                }                                       // store in all caps
            }

            // Property to get/set the beginning range (in miles) of an event
            public int BeginRange
            {
                get
                {
                    return beginRange;
                }
                set
                {
                    if (value >= 0)                    // must be '+' distance
                        beginRange = value;
                    else
                        throw new ArgumentException("Range can't be negative!");
                }
            }

            // Property to get/set the beginning azimuth (compass direction) of an event
            public string BeginAzimuth
            {
                get
                {
                    return beginAzimuth;
                }
                set
                {
                    if (AZIMUTHS.Contains(value.ToUpper()))   // must be in the AZIMUTHS list
                        beginAzimuth = value.ToUpper();       // store in all caps
                    else
                        throw new ArgumentException("Not a valid compass direction!");
                }
            }

            // Property to get/set city/airport/lake beginning range is determined by
            public string BeginLocation
            {
                get
                {
                    return beginLocation;
                }
                set
                {
                    beginLocation = value.ToUpper();          // too many cities to check against
                }                                             // store in all caps
            }

            // Property to get/set beginning latitude of an event
            public double BeginLat
            {
                get
                {
                    return beginLat;
                }
                set
                {
                    if (value >= -90 && value <= 90)        // must be >= -90 and <= 90
                        beginLat = value;
                    else
                        throw new ArgumentException("Latitude must be between -90 and 90!");
                }
            }

            // Property to get/set beginning longitude of an event
            public double BeginLong
            {
                get
                {
                    return beginLong;
                }
                set
                {
                    if (value >= -180 && value <= 180)      // must be >= -180 and <= 180
                        beginLong = value;
                    else
                        throw new ArgumentException("Longitude must be between -180 and 180!");
                    
                }
            }
            
            // Property to get/set the ending range (in miles) of an event
            public int EndRange
            {
                get
                {
                    return endRange;
                }
                set
                {
                    if (value >= 0)                    // must be '+' distance
                        endRange = value;
                    else
                        throw new ArgumentException("Range can't be negative!");
                }
            }

            // Property to get/set the ending azimuth (compass direction) of an event
            public string EndAzimuth
            {
                get
                {
                    return endAzimuth;
                }
                set
                {
                    if (AZIMUTHS.Contains(value.ToUpper()))   // must be in the AZIMUTHS list
                        endAzimuth = value.ToUpper();         // store in all caps
                    else
                        throw new ArgumentException("Not a valid compass direction!");
                }
            }

            // Property to get/set city/airport/lake ending range is determined by
            public string EndLocation
            {
                get
                {
                    return endLocation;
                }
                set
                {
                    endLocation = value.ToUpper();          // too many cities to check against
                }                                           // store in all caps
            }

            // Property to get/set ending latitude of an event
            public double EndLat
            {
                get
                {
                    return endLat;
                }
                set
                {

                    if (value >= -90 && value <= 90)        // must be >= -90 and <= 90
                        endLat = value;
                    else
                        throw new ArgumentException("Latitude must be between -90 and 90!");
                }
            }

            // Property to get/set ending longitude of an event
            public double EndLong
            {
                get
                {
                    return endLong;
                }
                set
                {
                    if (value >= -180 && value <= 180)      // must be >= -180 and <= 180
                        endLong = value;
                    else
                        throw new ArgumentException("Longitude must be between -180 and 180!");
                }
            }

            // Return list of states
            public static List<string> ReturnStateNames()
            {
                return STATES;
            }

            // Get a string of formatted EventLocation properties
            public override string ToString()
            {
                return string.Format("\nState:               {0}\n" +
                                     "County:              {1}\n" +
                                     "Start Location:      {2} miles {3} of {4}\n" +
                                     "Start Latitude:      {5}\n" +
                                     "Start Longitude:     {6}\n" +
                                     "End Location:        {7} miles {8} of {9}\n" +
                                     "End Latitude:        {10}\n" +
                                     "End Longitude:       {11}\n\n", 
                                     State, County, BeginRange,
                                     BeginAzimuth, BeginLocation,
                                     BeginLat, BeginLong, EndRange,
                                     EndAzimuth, EndLocation,
                                     EndLat, EndLong);
            }
        }

        // Stores information about the date and time of an event
        public class EventDateTime
        {
            private static readonly List<string> TIMEZONES =     // timezone list in U.S. and territories
                new List<string> {"AKST", "AKDT", "AST", "CST", "CDT", "EST", "EDT", "GST",
                                  "HST", "HDT", "MST", "MDT", "PST", "PDT", "SST", "ChST",
                                  "HAST", "HADT"};

            private string timezone;                      // timezone an event occurred in
            private int beginYear;                        // year an event started in
            private int beginMonth;                       // month an event started in
            private int beginDay;                         // day an event started in
            private int beginTime;                        // time an event started (24-hr clock)
            private int endYear;                          // year an event ended in
            private int endMonth;                         // month an event ended in
            private int endDay;                           // day an event ended in
            private int endTime;                          // time an event ended (24-hr clock)

            // Property to get/set timezone an event occurred in
            public string Timezone
            {
                get
                {
                    return timezone;
                }
                set
                {
                    if (TIMEZONES.Contains(value.ToUpper()))     // must be in TIMEZONES list
                        timezone = value.ToUpper();              // store in all caps
                    else
                        throw new ArgumentException("Invalid timezone!");
                }
            }

            // Property to get/set year an event began in
            public int BeginYear
            {
                get
                {
                    return beginYear;
                }
                set
                {
                    if ((value >= 1951) &&                       // must be between 1951
                        (value <= DateTime.Now.Year))            // and current year
                        beginYear = value;
                    else
                        throw new ArgumentException("Year must be between" +
                                                    " 1951 and the present!");  
                }
            }

            // Property to get/set month an event began in
            public int BeginMonth
            {
                get
                {
                    return beginMonth;
                }
                set
                {
                    if ((value >= 1) && (value <= 12))          // must be >= 1 and <= 12
                        beginMonth = value;
                    else
                        throw new ArgumentException("Month must be between 1 and 12!");
                }
            }

            // Property to get/set day an event began on
            public int BeginDay
            {
                get
                {
                    return beginDay;
                }
                set
                {
                    if ((value >= 1 && value <= 31) &&           // only certain months have day 31
                        (BeginMonth == 1 || BeginMonth == 3 || BeginMonth == 5 ||
                         BeginMonth == 7 || BeginMonth == 8 || BeginMonth == 10 ||
                         BeginMonth == 12 || BeginMonth == 0))    // allow 1-31 if month not set yet
                        beginDay = value;
                    else if ((value >= 1 && value <= 30) &&       // certain months end on day 30
                             (BeginMonth == 4 || BeginMonth == 6 ||
                              BeginMonth == 9 || BeginMonth == 11))
                        beginDay = value;
                    else if ((value >= 1 && value <= 29) &&        // if month is Feb., max day 
                             BeginMonth == 2)                      // is 29
                        beginDay = value;
                    else
                        throw new ArgumentException("Not a valid day of the month!");
                }
            }

            // Property to get/set the time an event began at (24-hr clock)
            public int BeginTime
            {
                get
                {
                    return beginTime;
                }
                set
                {
                    if ((value >= 0 && value <= 2359) &&             // time is between 0-23:59
                        (value % 100 >= 0 && value % 100 <= 59))     // minutes are from 0-59
                        beginTime = value;
                    else
                        throw new ArgumentException("Time must be between 0 and 2359!");
                }
            }

            // Property to get/set year an event ended in
            public int EndYear
            {
                get
                {
                    return endYear;
                }
                set
                {
                    if ((BeginYear != 0) &&                     // can't be < BeginYear
                       (value < BeginYear))
                        throw new ArgumentException("Year can't be < start year!");

                    if ((value >= 1951) &&                       // must be between 1951
                        (value <= DateTime.Now.Year))            // and current year
                        endYear = value;
                    else
                        throw new ArgumentException("Year must be between" +
                                                    " 1951 and the present!");
                                                  
                }
            }

            // Property to get/set month an event ended in
            public int EndMonth
            {
                get
                {
                    return endMonth;
                }
                set
                {
                    if ((BeginMonth != 0) &&
                        (BeginYear != 0) &&
                        (EndYear != 0) &&
                        (value < BeginMonth) &&            // must be >= BeginMonth
                        (EndYear == BeginYear))            // unless EndYear > BeginYear
                        throw new ArgumentException("Month can't be < start month unless" +
                                                    " end year > start year!");
                         
                    if ((value >= 1) || (value <= 12))          // must be >= 1 and <= 12
                        endMonth = value;
                    else
                        throw new ArgumentException("Month must be between 1 and 12!");
                }
            }

            // Property to get/set the day an event ended on
            public int EndDay
            {
                get
                {
                    return endDay;
                }
                set
                {
                    if((BeginDay != 0) &&                        // check for < BeginDay
                       (BeginMonth != 0) &&
                       (EndMonth != 0) &&
                       (BeginYear != 0) &&
                       (EndYear != 0) &&
                       (value < BeginDay) &&
                       (EndMonth <= BeginMonth) &&
                       (EndYear == BeginYear))
                        throw new ArgumentException("Day can't be < start day unless" +
                                                    " end month > start month or" +
                                                    " unless end year > start year!");
                       
                    if ((value >= 1 && value <= 31) &&           // only certain months have day 31
                        (EndMonth == 1 || EndMonth == 3 || EndMonth == 5 ||
                         EndMonth == 7 || EndMonth == 8 || EndMonth == 10 ||
                         EndMonth == 12 || EndMonth == 0))       // allow 1-31 if month not set yet
                        endDay = value;
                    else if ((value >= 1 && value <= 30) &&      // certain months end on day 30
                             (EndMonth == 4 || EndMonth == 6 ||
                              EndMonth == 9 || EndMonth == 11))
                        endDay = value;
                    else if ((value >= 1 && value <= 29) &&      // if month is Feb., max day 
                             EndMonth == 2)                      // is 29
                        endDay = value;
                    else
                        throw new ArgumentException("Not a valid day of the month!");
                }
            }

            // Property to get/set the time an event ended at (24-hr clock)
            public int EndTime
            {
                get
                {
                    return endTime;
                }
                set
                {
                    if ((BeginTime != 0) &&                          // check for EndTime < BeginTime
                        (BeginDay != 0) &&
                        (EndDay != 0) &&
                        (BeginMonth != 0) &&
                        (EndMonth != 0) &&
                        (BeginYear != 0) &&
                        (EndYear != 0) &&
                        (value < BeginTime) &&
                        (EndDay <= BeginDay) &&
                        (EndMonth <= BeginMonth) &&
                        (EndYear == BeginYear))
                        throw new ArithmeticException("Time can't be < start time unless" +
                                                      " end day > start day or" +
                                                      " end month > start month or" +
                                                      " end year > start year!");

                    if ((value >= 0 && value <= 2359) &&             // time is between 0-23:59
                        (value % 100 >= 0 && value % 100 <= 59))     // minutes are from 0-59
                        endTime = value;
                    else
                        throw new ArgumentException("Time must be between 0 and 2359!");
                }
            }

            // Get a string of formatted EventDateTime properties
            public override string ToString()
            {
                return string.Format("Start Date:          {0}/{1}/{2}\n" +
                                     "Start Time:          {3}:{4} {5}\n" +
                                     "End Date:            {6}/{7}/{8}\n" +
                                     "End Time:            {9}:{10} {5}\n\n",
                                     BeginMonth, BeginDay,
                                     BeginYear, (BeginTime / 100),     // hours = time / 100
                                     (BeginTime % 100), Timezone,      // minutes = time % 100
                                     EndMonth, EndDay, EndYear,
                                     (EndTime / 100), (EndTime % 100));
            }

        }
    }
}
