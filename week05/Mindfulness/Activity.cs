using System;
using System.Collections.Generic;
using System.Threading;
using System.Security.Cryptography;
//Parent Class for all activity
public class Activity
{
    protected string _activityName = "";
    protected string _description = "";
    protected int _duration = 0;

    public Activity()
    {
        _activityName = "";
        _description = "";

    }
    //For All Activity Display Activity Name, Description

    public void SetTimer(int duration)
    {
        _duration = duration;
    }

    public void StartDisplay()
    {
        Console.WriteLine($"Welcome to {_activityName} Activity");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        //Ask user for and set the duration of the activity in seconds
        Console.Write("How long, would you like for the session?");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            _duration = duration;
        }
        else
        {
            _duration = 30;
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    // tell the user to prepare to begin and pause for several seconds
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;
            if (i >= animationString.Count)
            {
                i = 0;
            }
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    // Give a good job message then pause and give the list of the activity they did and its duration before finishing

    public void EndDisplay()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of {_activityName} Activity");
        ShowSpinner(3);
    }

}