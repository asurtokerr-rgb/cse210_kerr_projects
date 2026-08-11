using System;
using System.Dynamic;
//running activity
public class Running : Activity
{
    private float _distance;

    public Running(float distance, string name, string date, int length) : base(name, date, length)
    {
        _distance = distance;
    }
    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return _distance / GetLength() * 60;
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
}