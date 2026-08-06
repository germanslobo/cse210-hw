using System;

public abstract class Activity
{
    private string _date;
    private double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string Date => _date;
    public double Minutes => _minutes;

    // Abstract methods to be overridden by derived classes
    public abstract double GetDistance(); // returns miles or km
    public abstract double GetSpeed();    // returns mph or kph
    public abstract double GetPace();     // returns min per mile/km

    // Base implementation of GetSummary using polymorphic method calls
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}