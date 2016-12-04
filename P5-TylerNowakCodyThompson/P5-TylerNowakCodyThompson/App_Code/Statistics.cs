/**********************************************************************************************************
 Tyler Nowak & Cody Thompson
 C490
 Phase 4
 
 This class contains static methods used to perform the tasks associated with calculating and displaying
 statistics chosen by the user. 
 *********************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_TylerNowak_CodyThompson
{
    class Statistics
    {
        // Display statistic options the user can have calculated
        public static void DisplayStatOptions()
        {
            Console.WriteLine("\nOption 0: Calculate top three most destructive storms");
            Console.WriteLine("Option 1: Determine overall fatalities in a state due to a type of storm");
            Console.WriteLine("Option 2: Determine average tornado damage by state");
            Console.WriteLine("Option 3: Go back to main menu\n");
        }

        // Display top 3 most destruction storms (in dollars)
        // in an EventList
        public static void DisplayTopThree(EventList list)
        {
            string eType;                  // event type to display stats for
            List<string> eventTypes;       // all possible storm types
            bool badInput = true;          // if input is invalid
            decimal totalDamage = 0;       // due to an event

            EventList result = new EventList();       // holds top 3 storms

            // Get possible event types
            eventTypes = Event.ReturnStormTypes();

            do
            {
                // Get user's choice for event type
                Event.DisplayStormTypes();
                Console.WriteLine("Enter a storm type.");
                eType = Console.ReadLine();

                // Verify input is correct
                foreach (var item in eventTypes)
                    if (item.Contains(eType.ToUpper()))   // catches partial types
                    {
                        eType = item;
                        badInput = false;
                        break;               // can stop looping once match found
                    }
            } while (badInput);

            // Calculate top three storms
            list.GetTopThree(eType, result);

            // Determine damage of top storm in results
            if (result.Count() > 0)
                totalDamage = result.GetEventFromList(0).PropertyDamage + 
                              result.GetEventFromList(0).CropDamage;    
  
            // Display results
            if (totalDamage == 0)
                Console.WriteLine("\nNo storms of this type have caused any damage!\n");
            else
            {
                Console.WriteLine("\nThe storms below have caused the most damage as of " +
                                  "the current date.\nFor ties, the most recent storms were chosen.\n");
                for (int index = 0; index < result.Count(); index++)
                {
                    Console.WriteLine("*****************************************" +
                                      "*****************************************\n");
                    Console.WriteLine(result.GetEventFromList(index));
                }
            }
        }

        // Display the total fatalities that have occurred in a state due to a 
        // particular storm type.  Look at all storm records in an EventList.
        public static void DisplayFatalities(EventList list)
        {
            string eType;                  // event type to display stats for
            List<string> eventTypes;       // all possible storm types
            List<string> stateNames;       // all possible state names
            string state;
            int fatalities;                // total state deaths due to storms of type eType
            bool badState = true;          // if state input is invalid
            bool badType = true;           // if eType input is invalid

            // Get possible event types
            eventTypes = Event.ReturnStormTypes();
            //Get possible state names
            stateNames = Event.EventLocation.ReturnStateNames();

            do
            {
                // Get user's choice for event type
                Console.Write("\n");
                Event.DisplayStormTypes();
                Console.WriteLine("Enter a storm type.");
                eType = Console.ReadLine();

                // Verify input is correct
                foreach (var item in eventTypes)
                    if (item.Contains(eType.ToUpper()))  // catches partial types
                    {
                        eType = item;
                        badType = false;
                        break;               // can stop looping once match found
                    }
            } while (badType);

            do
            {
                // Get user's choice for state
                Console.WriteLine("\nEnter a state to get the statistic for.");
                Console.WriteLine("State must written fully (no abbrevs or periods).");
                state = Console.ReadLine();

                // Verify input is correct
                foreach (var item in stateNames)
                    if (item.Contains(state.ToUpper()))  // catches partial states
                    {
                        state = item;
                        badState = false;
                        break;               // can stop looping once match found
                    }
            } while (badState);

            // Determine total fatalities in state due to storms of eType
            fatalities = list.DetermineFatalities(state, eType);
            
            // Display results to user
            Console.WriteLine("\nOverall, there have been {0} {1} fatalities in {2}.\n",
                              fatalities, eType, state);
        }

        // Display the average damage caused by tornadoes by state 
        public static void showMeanCostPerState(EventList list)
        {
            List<string> damage = new List<string>();             // list of avg tornado damage

            // Calculate average damage per state
            damage = list.CalculateMeanDamagePerState();

            // Display results to user
            Console.WriteLine("\nBelow is a list of the average damage (property + crop)" +
                              " caused by a tornado in each state.\nOnly states with" +
                              " historical tornado records are shown\n");
            foreach (var item in damage)
                Console.WriteLine(item);
        }
    }
}
