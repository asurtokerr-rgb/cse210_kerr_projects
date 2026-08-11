// date and length of the activity
// Base class for all activities
using System;
public abstract class Activity
{
    private string _name;
    private string _date;
    private int _length;

    //Constructor for Activity 
    public Activity(string name, string date, int length)
    {
        _name = name;
        _date = date;
        _length = length;
    }

    //getters and setters for time
    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    //getters and setters for activity length
    public int GetLength()
    {
        return _length;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    //getters and setters for activity name
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();
    //Display Summary of the Activity
    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_length}): Distance:{MathF.Round(GetDistance(), 2)} km, Speed: {MathF.Round(GetSpeed(), 2)} kph, Pace: {MathF.Round(GetPace(), 2)} min per km");

    }
}