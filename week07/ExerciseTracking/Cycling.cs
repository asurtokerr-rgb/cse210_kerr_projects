using System;
//Cycling Activity
public class Cycling : Activity
{
    private float _speed;

    public Cycling(float speed, string name, string date, int length) : base(name, date, length)
    {
        _speed = speed;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetDistance()
    {
        return GetSpeed() * GetLength();
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
}