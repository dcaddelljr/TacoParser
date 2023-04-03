namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser : ITrackable
    {
        readonly ILog logger = new TacoLogger();

        public string Name { get ; set ; }
        public Point Location { get ; set ; }

        public ITrackable Parse(string line)  // taking a line, converting it into 3 strings, and convert the 3 strings into one Taco Bell.
        {
            logger.LogInfo("Begin parsing"); //logging the info everytime you log the information


            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');
            
            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3) //"34.073638", "-84.677017", Taco Bell Acwort..." Taco Bell with name, location, lat&&long.
            {
                logger.LogWarning(" You have less than three items. Imcomplete data.");
                // Log that and return null
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            var latitude = double.Parse(cells[0]);
            // grab the longitude from your array at index 1
            var longitude = double.Parse(cells[1]);
            // grab the name from your array at index 2
            var name = cells[2];

            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            // You'll need to create a TacoBell class
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly

            var point = new Point();
            point.Longitude = longitude;
            point.Latitude = latitude;

            var tacoBell = new TacoBell();
            tacoBell.Name = name;
            tacoBell.Location = point;
            
            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable

            return tacoBell; //return of something ITrackable
        }
    }
}