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


            var cells = line.Split(',');
            
            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3) //"34.073638", "-84.677017", Taco Bell Acwort..." Taco Bell with name, location, lat&&long.
            {
                logger.LogWarning(" You have less than three items. Imcomplete data.");
               
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            var latitude = double.Parse(cells[0]);
            var longitude = double.Parse(cells[1]);
            var name = cells[2];

          
            var point = new Point();
            point.Longitude = longitude;
            point.Latitude = latitude;

            var tacoBell = new TacoBell();
            tacoBell.Name = name;
            tacoBell.Location = point;
            
           
            return tacoBell; //return of something ITrackable
        }
    }
}