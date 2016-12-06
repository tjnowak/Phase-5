/**********************************************************************************************************
 Tyler Nowak & Cody Thompson
 C490
 Phase 5
 
 This class stores a collection of inclement weather events.
 *********************************************************************************************************/
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace P5_TylerNowakCodyThompson
{
    // Stores information about a list of weather events
    class EventList
    {
        private List<Event> stormList;             // list of events

        // Get an event from the list given an index
        public Event GetEventFromList(int index)
        {
            return stormList[index];
        }

        // Default constructor
        public EventList()
        {
            stormList = new List<Event>();
        }

        // Clear the list of events
        public void ClearList()
        {
            stormList.Clear();
        }

        // Add an event to the list
        public void AddEvent(Event storm)
        {
            stormList.Add(storm);                  // add to end of list
        }

        // Gets the number of events in the list
        public int Count()
        {
            return stormList.Count;
        }

        // Display events stored in the list
        public void DisplayEvents()
        {
            foreach (var storm in stormList)
            {
                Console.WriteLine("[Index: {0}]   {1}/{2}/{3}  {4, -26}   {5} COUNTY, {6}\n",
                                  stormList.IndexOf(storm), storm.dateTime.BeginMonth, 
                                  storm.dateTime.BeginDay, storm.dateTime.BeginYear,
                                  storm.EventType, storm.location.County, 
                                  storm.location.State);
            }
        }

        // Search for events in the list by a particular event property
        public void Search(string eType, string property, EventList searchResults)
        {
            bool test = false;             // holds whether or not eType is a valid EventType

            // Clear searchResults of any elements
            searchResults.ClearList();
            // Convert eType to all uppercase chars
            eType = eType.ToUpper();
            // Convert property to all uppercase chars
            property = property.ToUpper();

            // Get list of possible event types
            List<string> stormTypes = Event.ReturnStormTypes();
            // Test whether or not eType is a valid EventType
            foreach (var type in stormTypes)
                {
                    if (type.Contains(eType))      // catch partially inputted types
                    {
                        eType = type;
                        test = true;
                        break;                     // don't need to continue looping
                    }
                }
            if (test == false)
                throw new ArgumentException("Invalid event type");

            // Test for partially entered property
            List<string> fieldNames = Event.ReturnFieldNames();
            foreach (var name in fieldNames)
                if (name.Contains(property))
                {
                    property = name;
                    break;
                }

            // Get a list of all the events that match the event type.
            var correctEtypeList = stormList.Where(c => c.EventType == eType);
            string propValue;
            int startRange, endRange = 0;
            double dStartRange, dEndRange = 0;

            switch (property)
            {
                case "EPISODE DESCRIPTION":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the episode description you are searching for.");
                    propValue = Console.ReadLine();
                    foreach (var storm in correctEtypeList)
                        if (storm.EpisodeDesc.ToUpper().Contains(propValue.ToUpper()))
                            searchResults.AddEvent(storm);
                    break;
                case "EVENT DESCRIPTION":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the event description you are searching for.");
                    propValue = Console.ReadLine();
                    foreach (var storm in correctEtypeList)
                        if (storm.EventDesc.ToUpper().Contains(propValue.ToUpper()))
                            searchResults.AddEvent(storm);
                    break;
                case "TORNADO TYPE":
                    // Add property matches to searchResults
                    if (eType == "TORNADO")
                    {
                        Console.WriteLine("Please enter the tornado type (EF0 through EF5) you" +
                                          " are searching for.");
                        propValue = Console.ReadLine();
                        foreach (var storm in correctEtypeList)
                            if (storm is TornadoEvent)
                                if (((TornadoEvent)storm).TornadoType.Contains(propValue.ToUpper()))
                                    searchResults.AddEvent(storm);
                    }
                    break;
                case "STATE":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the state's full name you are searching for.");
                    propValue = Console.ReadLine();
                    foreach (var storm in correctEtypeList)
                        if (storm.location.State.Contains(propValue.ToUpper()))
                            searchResults.AddEvent(storm);
                    break;
                case "COUNTY":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the full county name you are searching for.");
                    propValue = Console.ReadLine();
                    foreach (var storm in correctEtypeList)
                        if (storm.location.County.Contains(propValue.ToUpper()))
                            searchResults.AddEvent(storm);
                    break;
                case "START AZIMUTH":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the starting azimuth (Compass direction, Ex: SW)" +
                                      " you are searching for. ");
                    propValue = Console.ReadLine();
                    foreach (var storm in correctEtypeList)
                        if (storm.location.BeginAzimuth.Contains(propValue.ToUpper()))
                            searchResults.AddEvent(storm);
                    break;
                case "START LOCATION":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the full start location name (nearest city) " +
                                      "you are searching for.");
                    propValue = Console.ReadLine();
                    foreach (var storm in correctEtypeList)
                        if (storm.location.BeginLocation.Contains(propValue.ToUpper()))
                            searchResults.AddEvent(storm);
                    break;
                case "END AZIMUTH":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the ending azimuth (Compass direction, Ex: SW) " +
                                      "you are searching for .");
                    propValue = Console.ReadLine();
                    foreach (var storm in correctEtypeList)
                        if (storm.location.EndAzimuth.Contains(propValue.ToUpper()))
                            searchResults.AddEvent(storm);
                    break;
                case "END LOCATION":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the full end location name (nearest city) " +
                                      "you are searching for.");
                    propValue = Console.ReadLine();
                    foreach (var storm in correctEtypeList)
                        if (storm.location.EndLocation.Contains(propValue.ToUpper()))
                            searchResults.AddEvent(storm);
                    break;
                case "TIME ZONE":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the time zone (Ex: est) you are searching for.");
                    propValue = Console.ReadLine();
                    foreach (var storm in correctEtypeList)
                        if (storm.dateTime.Timezone.Contains(propValue.ToUpper()))
                            searchResults.AddEvent(storm);
                    break;
                case "INJURIES":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (integer) on the range of the " +
                                      "number of injuries you are searching for.");
                    startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (integer) on the range of the " +
                                       "number of injuries you are searching for.");
                    endRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.Injuries >= startRange && storm.Injuries <= endRange)
                            searchResults.AddEvent(storm);
                    break;
                case "FATALITIES":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (integer) on the range of the " +
                                      "number of fatalities you are searching for.");
                    startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (integer) on the range of the " +
                                      "number of fatalities you are searching for.");
                    endRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.Deaths >= startRange && storm.Deaths <= endRange)
                            searchResults.AddEvent(storm);
                    break;
                case "WIND SPEED":
                    // Add property matches to searchResults
                    if (eType == "THUNDERSTORM WIND" || 
                        eType == "MARINE THUNDERSTORM WIND" ||
                        eType == "MARINE STRONG WIND" || 
                        eType == "MARINE HIGH WIND" || 
                        eType == "STRONG WIND")
                    {
                        Console.WriteLine("Please enter the lower bound (integer) on the range of wind " +
                                          "speeds (measured in knots) you are searching for. ");
                        startRange = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nPlease enter the upper bound (integer) on the range of " +
                                          "wind speeds (measured in knots) you are searching for. ");
                        endRange = Convert.ToInt32(Console.ReadLine());
                        foreach (var storm in correctEtypeList)
                            if (storm is WindEvent)
                                if (((WindEvent)storm).Windspeed >= startRange && 
                                    ((WindEvent)storm).Windspeed <= endRange)
                                    searchResults.AddEvent(storm);
                    }
                    break;
                case "HAIL SIZE":
                    // Add property matches to searchResults
                    if (eType == "HAIL")
                    {
                        Console.WriteLine("Please enter the lower bound (number in inches) on the range " +
                                          "of hail sizes you are searching for.");
                        dStartRange = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nPlease enter the upper bound (number in inches) on the " +
                                          "range of hail sizes you are searching for.");
                        dEndRange = Convert.ToInt32(Console.ReadLine());
                        foreach (var storm in correctEtypeList)
                            if (storm is HailEvent)
                                if (((HailEvent)storm).HailSize >= dStartRange &&
                                    ((HailEvent)storm).HailSize <= dEndRange)
                                    searchResults.AddEvent(storm);
                    }
                    break;
                case "START RANGE":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound of event start ranges " +
                                      "(miles from nearest city as integer) you are searching for.");
                    startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound of event start ranges " +
                                      "(miles from nearest city as integer) you are searching for.");
                    endRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.location.BeginRange >= startRange && 
                            storm.location.BeginRange <= endRange)
                            searchResults.AddEvent(storm);
                    break;
                case "END RANGE":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound of event end ranges " +
                                      "(miles from nearest city as integer) you are searching for.");
                    startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound of event end ranges " +
                                      "(miles from nearest city as integer) you are searching for.");
                                      endRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.location.EndRange >= startRange && 
                            storm.location.EndRange <= endRange)
                            searchResults.AddEvent(storm);
                    break;
                case "START YEAR":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (as integer) on the range of" +
                                      " event start years you are searching for.");
                    startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (as integer) on the range of" +
                                      " event start years you are searching for.");
                    endRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.dateTime.BeginYear >= startRange && 
                            storm.dateTime.BeginYear <= endRange)
                            searchResults.AddEvent(storm);
                    break;
                case "START MONTH":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (as integer, 1-12) on the range of" +
                                      " event start months you are searching for.");
                    startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (as integer, 1-12) on the range of" +
                                      " event start months you are searching for.");
                    endRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.dateTime.BeginMonth >= startRange &&
                            storm.dateTime.BeginMonth <= endRange)
                            searchResults.AddEvent(storm);
                    break;
                case "START DAY":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (as integer, day of month) on the " +
                                      "range of event start days you are searching for.");
                    startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (as integer, day of month) on " +
                                      "the range of event start days you are searching for.");
                    endRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.dateTime.BeginDay >= startRange && 
                            storm.dateTime.BeginDay <= endRange)
                            searchResults.AddEvent(storm);
                    break;
                case "START TIME":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (24 hour time with no ':', EX " +
                                      ": 1425) on the range of event start times you are searching for.");
                    startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (24 hour time with no ':' EX " +
                                      ": 1456) on the range of event start times you are searching for.");
                    endRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.dateTime.BeginTime >= startRange && 
                            storm.dateTime.BeginTime <= endRange)
                            searchResults.AddEvent(storm);
                    break;
                case "END YEAR":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (as integer) on the range of " +
                                      "event end years you are searching for.");
                    startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (as integer) on the range of " +
                                      "event end years you are searching for.");
                    endRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.dateTime.EndYear >= startRange && 
                            storm.dateTime.EndYear <= endRange)
                            searchResults.AddEvent(storm);
                    break;
                case "END MONTH":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (as integer, 1-12) on the range " + 
                                      "of event end months you are searching for.");
                    startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (as integer, 1-12) on the " + 
                                      "range of event end months you are searching for.");
                    endRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.dateTime.EndMonth >= startRange && 
                            storm.dateTime.EndMonth <= endRange)
                            searchResults.AddEvent(storm);
                    break;
                case "END DAY":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (as integer, day of the month) on " +
                                      "the range of event end days you are searching for.");
                    startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (as integer, day of the month) " +
                                      "on the range of event end days you are searching for.");
                    endRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.dateTime.EndDay >= startRange && 
                            storm.dateTime.EndDay <= endRange)
                            searchResults.AddEvent(storm);
                    break;
                case "END TIME":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (24 hour time with no ':', " + 
                                      "EX: 1043) on the range of event end times you are searching for.");
                    startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (24 hour time with no ':', " +
                                      "EX: 1115) on the range of event end times you are searching for.");
                    endRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.dateTime.EndTime >= startRange && storm.dateTime.EndTime <= endRange)
                            searchResults.AddEvent(storm);
                    break;
                case "TORNADO LENGTH":
                    // Add property matches to searchResults
                    if (eType == "TORNADO")
                    {
                        Console.WriteLine("Please enter the lower bound (how far in miles) on the " + 
                                          "range of tornado lengths (distance traveled) you are " +
                                           "searching for.");
                        dStartRange = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nPlease enter the upper bound (how far in miles) on " +
                                          "the range of tornado lengths (distance traveled) you " +
                                          "are searching for.");
                        dEndRange = Convert.ToInt32(Console.ReadLine());
                        foreach (var storm in correctEtypeList)
                            if (storm is TornadoEvent)
                                if (((TornadoEvent)storm).TornadoLength >= dStartRange &&
                                    ((TornadoEvent)storm).TornadoLength <= dEndRange)
                                    searchResults.AddEvent(storm);
                    }
                    break;
                case "TORNADO WIDTH":
                    // Add property matches to searchResults
                    if (eType == "TORNADO")
                    {
                        Console.WriteLine("Please enter the lower bound (yards) on the range of " +
                                          "tornado widths (diameter accross) you are searching for.");
                        dStartRange = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nPlease enter the upper bound (yards) on the range of " +
                                           "tornado widths (diameter accross) you are searching for.");
                        dEndRange = Convert.ToInt32(Console.ReadLine());
                        foreach (var storm in correctEtypeList)
                            if (storm is TornadoEvent)
                                if (((TornadoEvent)storm).TornadoWidth >= dStartRange &&
                                    ((TornadoEvent)storm).TornadoWidth <= dEndRange)
                                    searchResults.AddEvent(storm);
                    }
                    break;
                case "START LATITUDE":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (-90 to 90) on the range of " +
                                      "event start latitudes you are searching for.");
                    dStartRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (-90 to 90) on the range of " +
                                      "event start latitudes you are searching for.");
                    dEndRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.location.BeginLat >= dStartRange && 
                            storm.location.BeginLat <= dEndRange)
                            searchResults.AddEvent(storm);
                    break;
                case "START LONGITUDE":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (-180 to 180) on the range of " +
                                      "event start longitudes you are searching for.");
                    dStartRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (-180 to 180) on the range " +
                                      "of event start longitudes you are searching for.");
                    dEndRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.location.BeginLong >= dStartRange && 
                            storm.location.BeginLong <= dEndRange)
                            searchResults.AddEvent(storm);
                    break;
                case "END LATITUDE":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (-90 to 90) on the range of event " +
                                      "end latitudes you are searching for.");
                    dStartRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (-90 to 90) on the range of " +
                                      "event end latitudes you are searching for.");
                    dEndRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.location.EndLat >= dStartRange && 
                            storm.location.EndLat <= dEndRange)
                            searchResults.AddEvent(storm);
                    break;
                case "END LONGITUDE":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (-180 to 180) on the range " +
                                      "of event end longitudes you are searching for.");
                    dStartRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (-180 to 180) on the range " +
                                      "of event end longitudes you are searching for.");
                    dEndRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.location.EndLong >= dStartRange && 
                            storm.location.EndLong <= dEndRange)
                            searchResults.AddEvent(storm);
                    break;
                case "PROPERTY DAMAGE":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (as a number without '$') " + 
                                      "on the range of property damage you are searching for.");
                    dStartRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (as a number without '$') " +
                                      "on the range of property damage you are searching for.");
                    dEndRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.PropertyDamage >= (decimal)dStartRange && 
                            storm.PropertyDamage <= (decimal)dEndRange)
                            searchResults.AddEvent(storm);
                    break;
                case "CROP DAMAGE":
                    // Add property matches to searchResults
                    Console.WriteLine("Please enter the lower bound (as a number without '$') " + 
                                      "on the range of crop damage you are searching for.");
                    dStartRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter the upper bound (as a number without '$') " +
                                      "on the range of crop damage you are searching for.");
                    dEndRange = Convert.ToInt32(Console.ReadLine());
                    foreach (var storm in correctEtypeList)
                        if (storm.CropDamage >= (decimal)dStartRange && 
                            storm.CropDamage <= (decimal)dEndRange)
                            searchResults.AddEvent(storm);
                    break;
                default:
                    // Error if property entered is not a real property
                    throw new ArgumentException("Property to search is invalid!\n\n");
            }
        }

        // Read in data from the database, load it into Event objects, and store them in stormList.
        public void ReadData()
        {
            Event anEvent;                                       // holds a storm event
            int intValue;                                        // to hold converted string
            double doubleValue;                                  // to hold converted string
            string amount;                                       // to hold a dollar amount
            char[] checkChars = { 'K', 'k',                      // chars to check if in a string
                                  'M', 'm' };                    

            // Clear stored data in event list
            ClearList();

            using (DBviaEFEntities MyTables = new DBviaEFEntities())
            {
                // Pull in all events from the DB
                var eventListDB = from e in MyTables.WeatherEvents
                                  select e;

                foreach (var e in eventListDB)
                {
                    // Create a new object of type Event or a derived type
                    if (e.EVENT_TYPE.ToUpper() == "HAIL")
                        anEvent = new HailEvent();
                    else if (e.EVENT_TYPE.ToUpper() == "TORNADO")
                        anEvent = new TornadoEvent();
                    else if (e.EVENT_TYPE.ToUpper() == "THUNDERSTORM WIND" ||
                             e.EVENT_TYPE.ToUpper() == "MARINE THUNDERSTORM WIND" ||
                             e.EVENT_TYPE.ToUpper() == "MARINE STRONG WIND" ||
                             e.EVENT_TYPE.ToUpper() == "MARINE HIGH WIND" ||
                             e.EVENT_TYPE.ToUpper() == "STRONG WIND")
                        anEvent = new WindEvent();
                    else
                        anEvent = new Event();

                    if (e.BEGIN_YEARMONTH != "")
                    {
                        try
                        {
                            // Set BeginYear
                            anEvent.dateTime.BeginYear = Convert.ToInt32(e.BEGIN_YEARMONTH) / 100;
                            // Set BeginMonth
                            anEvent.dateTime.BeginMonth = Convert.ToInt32(e.BEGIN_YEARMONTH) % 100;
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set BeginDay
                    if (e.BEGIN_DAY != "")
                    {
                        try
                        {
                            anEvent.dateTime.BeginDay = Convert.ToInt32(e.BEGIN_DAY);
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set BeginTime
                    if (e.BEGIN_TIME != "")
                    {
                        try
                        {
                            anEvent.dateTime.BeginTime = Convert.ToInt32(e.BEGIN_TIME);
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    if (e.END_YEARMONTH != "")
                    {
                        try
                        {
                            // Set EndYear
                            anEvent.dateTime.EndYear = Convert.ToInt32(e.END_YEARMONTH) / 100;
                            // Set EndMonth
                            anEvent.dateTime.EndMonth = Convert.ToInt32(e.END_YEARMONTH) % 100;
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set EndDay
                    if (e.END_DAY != "")
                    {
                        try
                        {
                            anEvent.dateTime.EndDay = Convert.ToInt32(e.END_DAY);
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set EndTime
                    if (e.END_TIME != "")
                    {
                        try
                        {
                            anEvent.dateTime.EndTime = Convert.ToInt32(e.END_TIME);
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set State
                    if (e.STATE != "")
                    {
                        try
                        {
                            anEvent.location.State = e.STATE;
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set EventType
                    if (e.EVENT_TYPE != "")
                    {
                        if (!(anEvent is HailEvent) &&    // hail & tornado are auto set
                            !(anEvent is TornadoEvent))
                        {
                            try
                            {
                                anEvent.EventType = e.EVENT_TYPE;
                            }
                            catch (ArgumentException ex) {throw; }
                        }
                    }

                    // Set County
                    if (e.CZ_NAME != "")
                    {
                        try
                        {
                            anEvent.location.County = e.CZ_NAME;
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set Timezone
                    try
                    {
                        if (e.CZ_TIMEZONE.Length >= 3)
                            if (Char.IsLetter(e.CZ_TIMEZONE, 0) &&
                                Char.IsLetter(e.CZ_TIMEZONE, 1) &&
                                Char.IsLetter(e.CZ_TIMEZONE, 2))
                                if ((e.CZ_TIMEZONE.Length >= 4) &&
                                    Char.IsLetter(e.CZ_TIMEZONE, 3))
                                    anEvent.dateTime.Timezone =
                                        // Use first 4 chars if all letters
                                        new string(e.CZ_TIMEZONE.Take(4).ToArray());
                                else anEvent.dateTime.Timezone =
                                        // Use first 3 chars if all letters
                                        new string(e.CZ_TIMEZONE.Take(3).ToArray());
                    }
                    catch (ArgumentException ex) { throw; }

                    // Set Injuries
                    if (e.INJURIES_DIRECT != "")
                    {
                        try
                        {
                            anEvent.Injuries = Convert.ToInt32(e.INJURIES_DIRECT);
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set Injuries (add indirect injuries)
                    if (e.INJURIES_INDIRECT != "")
                    {
                        try
                        {
                            anEvent.Injuries = anEvent.Injuries +
                                               Convert.ToInt32(e.INJURIES_INDIRECT);
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set Deaths
                    if (e.DEATHS_DIRECT != "")
                    {
                        try
                        {
                            anEvent.Deaths = Convert.ToInt32(e.DEATHS_DIRECT);
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set Deaths (add indirect deaths)
                    if (e.DEATHS_INDIRECT != "")
                    {
                        try
                        {
                            anEvent.Deaths = anEvent.Deaths +
                                             Convert.ToInt32(e.DEATHS_INDIRECT);
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set PropertyDamage
                    if (e.DAMAGE_PROPERTY != "")
                    {
                        try
                        {                                     // get rid of 'K' or 'M' at end
                            amount = e.DAMAGE_PROPERTY.TrimEnd(checkChars);
                            if (e.DAMAGE_PROPERTY.ToUpper()[e.DAMAGE_PROPERTY.Length - 1] == 'K')
                                anEvent.PropertyDamage = Convert.ToDecimal(amount) * 1000M;
                            else
                                anEvent.PropertyDamage = Convert.ToDecimal(amount) * 1000000M;
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set CropDamage
                    if (e.DAMAGE_CROPS != "")
                    {
                        try
                        {                                    // get rid of 'K' or 'M' at end
                            amount = e.DAMAGE_CROPS.TrimEnd(checkChars);
                            if (e.DAMAGE_CROPS.ToUpper()[e.DAMAGE_CROPS.Length - 1] == 'K')
                                anEvent.CropDamage = Convert.ToDecimal(amount) * 1000M;
                            else
                                anEvent.CropDamage = Convert.ToDecimal(amount) * 1000000M;
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    if (e.MAGNITUDE != "")
                    {
                        try
                        {
                            // Set Windspeed if possible
                            if (anEvent is WindEvent)
                            {
                                Int32.TryParse(e.MAGNITUDE, out intValue);
                                ((WindEvent)anEvent).Windspeed = intValue;
                            }
                            // Set HailSize if possible
                            if (anEvent is HailEvent)
                            {
                                Double.TryParse(e.MAGNITUDE, out doubleValue);
                                ((HailEvent)anEvent).HailSize = doubleValue;
                            }
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set TornadoType
                    if (e.TOR_F_SCALE != "")
                    {
                        if (anEvent is TornadoEvent)
                        {
                            try
                            {
                                ((TornadoEvent)anEvent).TornadoType = e.TOR_F_SCALE;
                            }
                            catch (ArgumentException ex) { throw; }
                        }
                    }

                    // Set TornadoLength
                    if (e.TOR_LENGTH != "")
                    {
                        if (anEvent is TornadoEvent)
                        {
                            try
                            {
                                ((TornadoEvent)anEvent).TornadoLength =
                                    Convert.ToDouble(e.TOR_LENGTH);
                            }
                            catch (ArgumentException ex) { throw; }
                        }
                    }

                    // Set TornadoWidth
                    if (e.TOR_WIDTH != "")
                    {
                        if (anEvent is TornadoEvent)
                        {
                            try
                            {
                                ((TornadoEvent)anEvent).TornadoWidth =
                                    Convert.ToDouble(e.TOR_WIDTH);
                            }
                            catch (ArgumentException ex) { throw; }
                        }
                    }

                    // Set BeginRange
                    if (e.BEGIN_RANGE != "")
                    {
                        try
                        {
                            anEvent.location.BeginRange = Convert.ToInt32(e.BEGIN_RANGE);
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set BeginAzimuth
                    if (e.BEGIN_AZIMUTH != "")
                    {
                        try
                        {
                            anEvent.location.BeginAzimuth = e.BEGIN_AZIMUTH;
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set BeginLocation
                    if (e.BEGIN_LOCATION != "")
                    {
                        try
                        {
                            anEvent.location.BeginLocation = e.BEGIN_LOCATION;
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set EndRange
                    if (e.END_RANGE != "")
                    {
                        try
                        {
                            anEvent.location.EndRange = Convert.ToInt32(e.END_RANGE);
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set EndAzimuth
                    if (e.END_AZIMUTH != "")
                    {
                        try
                        {
                            anEvent.location.EndAzimuth = e.END_AZIMUTH;
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set EndLocation
                    if (e.END_LOCATION != "")
                    {
                        try
                        {
                            anEvent.location.EndLocation = e.END_LOCATION;
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set BeginLat
                    if (e.BEGIN_LAT != "")
                    {
                        try
                        {
                            anEvent.location.BeginLat = Convert.ToDouble(e.BEGIN_LAT);
                        }
                        catch (ArgumentException ex) { throw; }
                    }

                    // Set BeginLong
                    if (e.BEGIN_LON != "")
                    {
                        try
                        {
                            anEvent.location.BeginLong = Convert.ToDouble(e.BEGIN_LON);
                        }
                        catch (ArgumentException ex) {throw; }
                    }

                    // Set EndLat
                    if (e.END_LAT != "")
                    {
                        try
                        {
                            anEvent.location.EndLat = Convert.ToDouble(e.END_LAT);
                        }
                        catch (ArgumentException ex) {throw; }
                    }

                    // Set EndLong
                    if (e.END_LON != "")
                    {
                        try
                        {
                            anEvent.location.EndLong = Convert.ToDouble(e.END_LON);
                        }
                        catch (ArgumentException ex) { throw; }
                    }
                    // Store anEvent in list
                    AddEvent(anEvent);
                }
            }
        }

        // Calculate top three most destructive storms (in total $ damage) in the list.
        // If there is a tie, the storms are chosen by date of occurrence.
        public void GetTopThree(string eType, EventList results)
        {  
            // Find top 3 storms
            var query = (from s in stormList              // self-joining for demonstration purposes
                         join e in stormList on s.DistinctID equals e.DistinctID
                         let damage = s.CropDamage + s.PropertyDamage
                         where s.EventType.Any(x => s.EventType.Equals(eType))  // s must be of type eType
                         orderby damage descending,                       
                                 s.dateTime.BeginYear descending,      // sort by highest damage then by 
                                 s.dateTime.BeginMonth descending,     // most recent
                                 s.dateTime.BeginDay descending,   
                                 s.dateTime.BeginTime descending
                         select s).Take(3);

            // Clear out any events in results
            results.ClearList();

            // Add top 3 storms to results
            foreach (var item in query)
            {
                results.AddEvent(item);
            }
        }

        // From the list, determine the total number of fatalities recorded
        // in a state due to a certain type of storm
        public int DetermineFatalities(string state, string eType)
        {
            // Find all occurrences of a type of storm
            var occurrences = from s in stormList
                              where s.EventType.Any(x => s.EventType.Equals(eType))
                              select s;

            // Find all storms with fatalities in the specific state
            var fatalStorms = from s in stormList
                              where (s.Deaths > 0) &&
                                    (s.location.State == state) 
                              select s;

            // Find storms of type eType with fatalities in the state
            var fatalOccurrences = (occurrences.Select(x => x)
                                   .Intersect(fatalStorms.Select(y => y)));

            // Return number of total fatalities for storms of type eType in the state
            return (fatalOccurrences.Sum(x => x.Deaths));
        }

        // Display the average damage caused by tornadoes per state
        public List<string> CalculateMeanDamagePerState()
        {
            List<string> tornadoDamage = new List<string>();       // holds mean damage by state

            // Find average crop damage grouped by state
            var MeanDamageCrop = from s in stormList
                                 where s.EventType == "TORNADO"
                                 group s by s.location.State into stateGroup
                                 select new
                                 {
                                     State = stateGroup.Key,
                                     AvgCropDamage = stateGroup.Average(s => s.CropDamage)
                                 };

            // Find average property damage grouped by state
            var MeanDamageProp = from c in stormList
                                 where c.EventType == "TORNADO"
                                 group c by c.location.State into stateGroup
                                 select new
                                 {
                                     State = stateGroup.Key,
                                     AvgPropDamage = stateGroup.Average(c => c.PropertyDamage)
                                 };

            // Find total average damage per state
            var MeanDamage = from x in MeanDamageCrop
                             join z in MeanDamageProp on x.State equals z.State
                             let damage = x.AvgCropDamage + z.AvgPropDamage
                             select new
                             {
                                 State = x.State,
                                 TotalAverageDmg = damage
                             };

            // Add the results to a list
            foreach (var thing in MeanDamage)
            {
                tornadoDamage.Add(String.Format("{0, -15} = {1:c}", thing.State, thing.TotalAverageDmg));
            }

            // Return list of damage by state
            return tornadoDamage;
        }
    }
}
