using System;
using System.Threading;
public class Breathing : Activity
{
    //use the starting message and asking duration from Parent class
    public Breathing()
    {
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    //Show an alternate message of  "Breathe in..." and "Breathe out...". 
    //After message show countdown pause from parent class
    //Continue until the duration of the user's input
    //End with message and list of duration from parent class
    public void Run()
    {
        StartDisplay();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);

            if (DateTime.Now >= endTime) break;

            Console.Write("\nNow breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }

        EndDisplay();
    }
}
