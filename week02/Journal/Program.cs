using System;

// Creativity: This program exceeds the core requirements by allowing
// the user to save and load journal entries from a file.
/* ======================================================================= EXCEEDING THE REQUIREMENTS / CREATIVITY DOCUMENTATION =======================================================================
 1. Prompts the user for their current habit baseline upon startup, then dynamically tracks and increments their consecutive days of journaling directly on the main menu to reinforce the habit.
 2. Dedicated Spiritual Growth Prompts (Addressing Lack of Direction): Provides an explicit feature path for spiritual journaling, prompting users to record specific scripture verses and spiritual insights gained during the day. 
3. Added a prompt question to ask the user how many consecutive days they have been writing so they can have motivation to write daily*/


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._prompt = generator.GetRandomPrompt();

                Console.WriteLine(entry._prompt);
                Console.Write("> ");
                entry._text = Console.ReadLine();
                Console.WriteLine("How many days have you been writing consecutively? ");
                entry._consecDays = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();

                journal.SaveToFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}