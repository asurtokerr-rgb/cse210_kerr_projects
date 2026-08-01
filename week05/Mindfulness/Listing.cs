using System;
using System.Collections.Generic;
using System.Threading;
public class Listing : Activity
{

    private List<string> _prompts;
    private List<string> _usedPrompts;
    private Random _random;

    public Listing()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _usedPrompts = new List<string>();
        _random = new Random();
    }
    public void Run()
    {
        //use the starting message and asking duration from Parent class
        StartDisplay();

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetUniqueRandomPrompt()} ---\n");
        Console.Write("You may begin in: ");
        //Show countdown to begin thingking
        ShowCountDown(5);
        Console.WriteLine();
        //Display the the list
        List<string> userItems = GetListFromUser();
        Console.WriteLine($"\nYou listed {userItems.Count} items!");
        //End
        EndDisplay();
    }

    private string GetUniqueRandomPrompt()
    {
        if (_usedPrompts.Count >= _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        string prompt;
        do
        {
            int index = _random.Next(_prompts.Count);
            prompt = _prompts[index];
        } while (_usedPrompts.Contains(prompt));

        _usedPrompts.Add(prompt);
        return prompt;
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    items.Add(item);
                }
            }
            else
            {
                Thread.Sleep(100);
            }
        }

        return items;
    }

}






