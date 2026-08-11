using System;

class Program
{
    static void Main(string[] args)
    {
        Running r = new Running(5, "Running", "11 Aug 2026", 30);
        Cycling c = new Cycling(10, "Cycling", "12 Aug 2026", 60);
        Swimming s = new Swimming(4, "Swimming", "13 Aug 2026", 20);

        List<Activity> activities = new List<Activity>();
        activities.Add(r);
        activities.Add(c);
        activities.Add(s);

        foreach (Activity k in activities)
        {
            k.GetSummary();
        }
    }
}