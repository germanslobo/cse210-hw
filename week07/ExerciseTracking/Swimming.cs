public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double minutes, int laps) 
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance in kilometers: laps * 50 meters / 1000
        return (_laps * 50.0) / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60.0;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
}