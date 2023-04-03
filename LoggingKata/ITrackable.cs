namespace LoggingKata
{
    public interface ITrackable
    {
        //This means Taco Bell must have a name and a location.
        string Name { get; set; }
        Point Location { get; set; }
    }
}