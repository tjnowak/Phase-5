/**********************************************************************************************************
 Tyler Nowak & Cody Thompson
 C490
 Phase 5
 
 This class contains static methods used to perform the tasks specified by user-chosen options 0-4. 
**********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P5_TylerNowakCodyThompson
{
    // Stores static methods used to perform options 0-4
    class Options
    {
        

        // Add a new event to an EventList object through user input
        public static void Add(EventList list)
        {
            Event anEvent;                    // new event to be added to list
            int cont;                         // holds whether or not to continue looping
            List<string> eventTypes;          // all possible storm types
            string eType;                     // inputted event type

            // Get possible event types
            eventTypes = Event.ReturnStormTypes();

            // Get event type choice
            do
            {
                cont = -1;
                // Display options
                Console.Write("\n");
                Event.DisplayStormTypes();

                // Get choice
                Console.WriteLine("\nEnter the type of storm.");
                eType = Console.ReadLine();

                // Verify input is correct
                foreach (var item in eventTypes)
                    if (item.Contains(eType.ToUpper()))   // catches partial types
                    {
                        eType = item;
                        cont = 0;
                        break;               // can stop looping once match found
                    }
                if (cont == -1)
                    Console.WriteLine("Invalid event-type!");
            } while (cont == -1);

            // Instantiate new event
            if (eType == "HAIL")
                anEvent = new HailEvent();
            else if (eType == "TORNADO")
                anEvent = new TornadoEvent();
            else if (eType == "THUNDERSTORM WIND" ||
                        eType == "MARINE THUNDERSTORM WIND" ||
                        eType == "MARINE STRONG WIND" ||
                        eType == "MARINE HIGH WIND" ||
                        eType == "STRONG WIND")
                anEvent = new WindEvent();
            else
                anEvent = new Event();

            // Set EventType
            if (!(anEvent is HailEvent) &&     // property auto set for hail & tornado
                !(anEvent is TornadoEvent))
            {
                try { anEvent.EventType = eType; }
                catch (ArgumentException N)
                {
                    Console.WriteLine(N.Message + "\n");
                }
            }

            // Set BeginYear
            do
            {
                cont = 0;         // intialize loop continue variable as good
                Console.WriteLine("\nEnter the year the storm began in.");
                try { anEvent.dateTime.BeginYear = Convert.ToInt32(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;    // set loop continue variable as bad
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set BeginMonth
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the month (as an integer) the storm began in.");
                try { anEvent.dateTime.BeginMonth = Convert.ToInt32(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set BeginDay
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the day the storm began.");
                try { anEvent.dateTime.BeginDay = Convert.ToInt32(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set BeginTime
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the time (24-hr time with no ':' ) the storm began.");
                try { anEvent.dateTime.BeginTime = Convert.ToInt32(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set EndYear
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the year the storm ended in.");
                try { anEvent.dateTime.EndYear = Convert.ToInt32(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set EndMonth
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the month (an integer) the storm ended in.");
                try { anEvent.dateTime.EndMonth = Convert.ToInt32(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set EndDay
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the day the storm ended.");
                try { anEvent.dateTime.EndDay = Convert.ToInt32(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set EndTime
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the time (24-hr time with no ':' ) the storm ended.");
                try { anEvent.dateTime.EndTime = Convert.ToInt32(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set State
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the state the storm happened in.");
                try { anEvent.location.State = Console.ReadLine(); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set County
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the county the storm happened in.");
                try { anEvent.location.County = Console.ReadLine(); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set timezone
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the time zone the storm happened in" +
                                  " (3-4 characters, Ex: EST).");
                try { anEvent.dateTime.Timezone = Console.ReadLine(); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set Injuries
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the number of injuries due to the storm.");
                try { anEvent.Injuries = Convert.ToInt32(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set Deaths
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the number of fatalities due to the storm.");
                try { anEvent.Deaths = Convert.ToInt32(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set PropertyDamage
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the amount of property damage (as a number) from the storm.");
                try { anEvent.PropertyDamage = Convert.ToDecimal(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set CropDamage
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the amount of crop damage (as a number) from the storm.");
                try { anEvent.CropDamage = Convert.ToDecimal(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Check event type then set WindSpeed
            if (anEvent is WindEvent)
            {
                do
                {
                    cont = 0;
                    Console.WriteLine("\nEnter the wind speed in knots (an integer).");
                    try { ((WindEvent)anEvent).Windspeed = Convert.ToInt32(Console.ReadLine()); }
                    catch (ArgumentException N)
                    {
                        cont = -1;
                        Console.WriteLine(N.Message + "\n");
                    }
                } while (cont == -1);
            }

            // Check event type then set HailSize
            if (anEvent is HailEvent)
            {
                do
                {
                    cont = 0;
                    Console.WriteLine("\nEnter the hail size in inches (a number).");
                    try { ((HailEvent)anEvent).HailSize = Convert.ToDouble(Console.ReadLine()); }
                    catch (ArgumentException N)
                    {
                        cont = -1;
                        Console.WriteLine(N.Message + "\n");
                    }
                } while (cont == -1);
            }

            // Check event type then set Tornado values
            if (anEvent is TornadoEvent)
            {
                // Set tornado type
                do
                {
                    cont = 0;
                    Console.WriteLine("\nEnter the tornado type (EF0 - EF5).");
                    try { ((TornadoEvent)anEvent).TornadoType = Console.ReadLine(); }
                    catch (ArgumentException N)
                    {
                        cont = -1;
                        Console.WriteLine(N.Message + "\n");
                    }
                } while (cont == -1);

                // Set tornado length
                do
                {
                    cont = 0;
                    Console.WriteLine("\nEnter the tornado length in miles.");
                    try
                    {
                        ((TornadoEvent)anEvent).TornadoLength =
                        Convert.ToDouble(Console.ReadLine());
                    }
                    catch (ArgumentException N)
                    {
                        cont = -1;
                        Console.WriteLine(N.Message + "\n");
                    }
                } while (cont == -1);

                // Set tornado width
                do
                {
                    cont = 0;
                    Console.WriteLine("\nEnter the tornado width in yards.");
                    try
                    {
                        ((TornadoEvent)anEvent).TornadoWidth =
                        Convert.ToDouble(Console.ReadLine());
                    }
                    catch (ArgumentException N)
                    {
                        cont = -1;
                        Console.WriteLine(N.Message + "\n");
                    }
                } while (cont == -1);
            }


            // Set BeginRange
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the beginning range (miles from nearest" +
                                  " city as integer) for the storm.");
                try { anEvent.location.BeginRange = Convert.ToInt32(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set BeginAzimuth
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the beginning azimuth for the storm" +
                                  " (Compass direction, Ex: NE).");
                try { anEvent.location.BeginAzimuth = Console.ReadLine(); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set BeginLocation
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the beginning location (nearest city) for the storm.");
                try { anEvent.location.BeginLocation = Console.ReadLine(); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set EndRange
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the ending range (integer) for the storm.");
                try { anEvent.location.EndRange = Convert.ToInt32(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set EndAzimuth
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the ending azimuth for the storm" +
                                  " (Compass direction, Ex: SW).");
                try { anEvent.location.EndAzimuth = Console.ReadLine(); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set EndLocation
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the ending location (nearest city) for the storm.");
                try { anEvent.location.EndLocation = Console.ReadLine(); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set BeginLat
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the beginning latitude (-90 to 90) for the storm.");
                try { anEvent.location.BeginLat = Convert.ToDouble(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set BeginLong
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the beginning longitude (-180 to 180) for the storm.");
                try { anEvent.location.BeginLong = Convert.ToDouble(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set EndLat
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the ending latitude (-90 to 90) for the storm.");
                try { anEvent.location.EndLat = Convert.ToDouble(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set EndLong
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter the ending longitude (-180 to 180) for the storm.");
                try { anEvent.location.EndLong = Convert.ToDouble(Console.ReadLine()); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set EpisodeDesc
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter a short description of the episode.");
                try { anEvent.EpisodeDesc = Console.ReadLine(); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Set EventDesc
            do
            {
                cont = 0;
                Console.WriteLine("\nEnter a short description of the event.");
                try { anEvent.EventDesc = Console.ReadLine(); }
                catch (ArgumentException N)
                {
                    cont = -1;
                    Console.WriteLine(N.Message + "\n");
                }
            } while (cont == -1);

            // Add anEvent to list
            list.AddEvent(anEvent);

            // Display the added event
            list.DisplayEvents();
        }

        // Modify a field of an event in an EventList oject
        public static void Modify(EventList list)
        {
            int test;                             // holds 0 if input successful; otherwise -1;
            int index;                            // holds the index of an event in a list

            // Display all the events in the list
            list.DisplayEvents();

            // Ask user which event they want to modify
            do
            {
                Console.WriteLine("Enter the index number of the event" +
                                  " you would like to modify.");
                index = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
            } while (index < 0 || index > list.Count());
             
            do
            {
                // Display the event they chose
                Console.WriteLine(list.GetEventFromList(index));

                // Ask for the field they would like to modify, then get the value for that field
                Console.WriteLine("Enter field you would like to modify");
                string field = Console.ReadLine();
                Console.Write("\n");

                Console.WriteLine("What is the new value for this field?");
                string value = Console.ReadLine();
                Console.Write("\n");

                // Modify the field of the event chosen
                test = list.GetEventFromList(index).Modify(field, value);

            } while (test == -1);                 // loop if invalid parameters entered

            // Display the modified event
            Console.WriteLine(list.GetEventFromList(index) + "\n");
        }

        // Search for events of an event-type in an EventList object by a particular field
        public static void Search(EventList list)
        {
            // Display all possible event types; have user select a type to search for.
            Console.Write("\n");
            Event.DisplayStormTypes();
            Console.WriteLine("Which storm type would you like to search? " +
                              "(Please enter the whole type name)");
            string sType = Console.ReadLine();
            Console.Write("\n");

            // Display all possible field names; have user select a type to search for.
            Event.DisplayFieldNames();
            Console.WriteLine("Which field name would you like to search? " +
                              "(Please enter the whole field name)");
            string sField = Console.ReadLine();
            Console.Write("\n");

            // Create new EventList to hold search results
            EventList results = new EventList();

           /* // Search for events
            try
            { list.Search(sType, sField, results); }
            catch (ArgumentException e)
            {
                Console.WriteLine("The search failed.");
                Console.WriteLine(e.Message + "\n");
            }*/

            // Display the resulting events from the search, unless there were no results.
            if (results.Count() == 0)
                Console.WriteLine("\nThe search returned no results.\n");
            else
                for (int index = 0; index < results.Count(); index++)
                {
                    Console.WriteLine("*****************************************" +
                                      "*****************************************\n");
                    Console.WriteLine(results.GetEventFromList(index));
                }          
        }

        // Display storm event statistics to the user
        public static void DisplayStatistics(EventList list)
        {
            int choice;                                     // choice from options           

            do
            {
                // Display options to the user
                Statistics.DisplayStatOptions();
                // Get choice
                Console.WriteLine("Enter an option.");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice < 0 || choice > 3);

            // Carry out choice
            switch (choice)
            {
                case 0:
                    // Calc. top 3 destructive storms
                    Statistics.DisplayTopThree(list);
                    break;
                case 1:
                    // Determine total fatalities in a state for
                    // a storm type
                    Statistics.DisplayFatalities(list);
                    break;
                case 2:
                    // Calc average tornado damage per state
                    Statistics.showMeanCostPerState(list);
                    break;
                default:
                    // Go back to main menu
                    return;
            }
        }
    }
}
