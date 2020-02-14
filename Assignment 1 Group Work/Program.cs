using System;

namespace Assignment_1_Group_Work
{
    class Program
    {
        //Create variables that'll update as the program runs
        public static double total_population = 100.00;
        public static int total_states = 27;
        public static bool pass_population = true;
        public static bool pass_states = true;
        public static bool all_countries_participating = true;
        public static bool austria, belgium = true;
        static void Main(string[] args)
        {
            //Call the function that lets the user choose if all countries are participating
            participating();

            Console.WriteLine($"Total population in favour: {total_population}%");
            Console.WriteLine($"Total states in favour: {total_states}");

            if (pass_population == true && pass_states == true)
            {
                Console.WriteLine("The vote has passed");
            }
            else
            {
                Console.WriteLine("The vote failed to pass");
            }

            Console.WriteLine(austria);

            Console.WriteLine("Please enter a state to change the choice of:");
            string state_to_change = Console.ReadLine();
            Console.WriteLine(state_to_change);
        }

        static void participating()
        {
            Console.WriteLine("Are all countries participating? (yes/no):");
            string participating_choice = Console.ReadLine();
            participating_choice.ToLower();
            if (participating_choice == "yes")
            {
                all_countries_participating = true;
            }
            else if (participating_choice == "no")
            {
                all_countries_participating = false;
            }
        }

        static void voting()
        {

        }
    }
}
