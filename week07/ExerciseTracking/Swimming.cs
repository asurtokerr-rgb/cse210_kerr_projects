using System;
using System.Dynamic;
// Swimming Activity
public class Swimming : Activity
{
    private float _laps;

    public Swimming(float laps, string name, string date, int length) : base(name, date, length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override float GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
}