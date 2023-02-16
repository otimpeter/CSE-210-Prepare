using System;

public class Activity
{
    private DateTime date;
    private int length;

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        string summary = date.ToString("dd MMM yyyy") + " " + GetType().Name + " (" + length + " min) - ";
        summary += "Distance " + GetDistance().ToString("F1") + " km, ";
        summary += "Speed " + GetSpeed().ToString("F1") + " kph, ";
        summary += "Pace " + GetPace().ToString("F1") + " min per km";
        return summary;
    }
}

public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (length / 60.0);
    }

    public override double GetPace()
    {
        return length / distance;
    }
}

public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed * (length / 60.0);
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }
}

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (length / 60.0);
    }

    public override double GetPace()
    {
        return length / (laps * 50.0 / 1000.0);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Activity[] activities = new Activity[]
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 3), 30, 6.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

        Console.ReadLine();
    }
}
