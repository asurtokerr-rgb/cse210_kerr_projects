using System;
using System.Threading;

// Exceeding requirements:
//1. Session Analytics/Activity Log: Tracks how many times each activity was completed during the current application runtime and displays a summary log when quitting.
//2. Non-Repeating Randomization: Implements tracking lists within the Reflecting and Listing activities to ensure prompts and questions do not repeat until all options have been shown once.
class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;
        //Repeat the Menu

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Breathing Activity");
            Console.WriteLine("   2. Reflection Activity");
            Console.WriteLine("   3. Listing Activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the Menu: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Breathing breathing = new Breathing();
                breathing.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                Reflection reflection = new Reflection();
                reflection.Run();
                reflectionCount++;
            }
            else if (choice == "3")
            {
                Listing listing = new Listing();
                listing.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Session Summary Log:");
                Console.WriteLine($" - Breathing Activities Completed: {breathingCount}");
                Console.WriteLine($" - Reflecting Activities Completed: {reflectionCount}");
                Console.WriteLine($" - Listing Activities Completed: {listingCount}");
                Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please select 1 through 4.");
                Thread.Sleep(1500);
            }
        }
    }
}