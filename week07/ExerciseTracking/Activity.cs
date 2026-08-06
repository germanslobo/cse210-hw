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

    // Encapsulated property allowing child classes to access length in minutes
    protected double Minutes => _minutes;

    // Abstract calculation methods required by the base class
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Base implementation calling polymorphic methods (not overridden in child classes)
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}