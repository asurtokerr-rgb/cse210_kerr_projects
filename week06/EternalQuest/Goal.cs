using System;
//base class for goal classes

public abstract class Goal
{

    protected string _shortName;
    protected string _description;

    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Getters for member variables
    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    // Abstract method for handling recording events and returning earned points.
    public abstract int RecordEvent();

    // Abstract method for determining completion status

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }
    // Abstract method for file serialization format
    public abstract string GetStringRepresentation();


}
