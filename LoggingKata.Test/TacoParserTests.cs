using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything  Lat, Long

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual); //This is going to test something that isn't null


        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("32.571331, - 85.499655, Taco Bell Auburn...",- 85.499655)]
        [InlineData("33.587217, -85.057114, Taco Bell Carrollto...", -85.057114)]
        [InlineData("33.648244, -84.011856, Taco Bell Acwort...", -84.011856)]
        [InlineData("33.450442, -86.984822, Taco Bell Hueytow...", -86.984822)]
        [InlineData("33.849014, -87.279978, Taco Bell Jasper...", -87.279978)]
        public void ShouldParseLongitude(string line, double expected)
            // This is a method that will run a test for us...PARSE will take a string and turn it into a Taco Bell/
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange - write the code we need in order to call the mthod we're testing
            var tacoParserInstance = new TacoParser();
            //Act
            var actual = tacoParserInstance.Parse(line); 
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("30.416551, -86.607497, Taco Bell Fort Walton Beac...", 30.416551)]
        [InlineData("34.690282, -86.581582, Taco Bell Huntsville...", 34.690282)]
        [InlineData("33.051273, -85.028938, Taco Bell Lagrang...", 33.051273)]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("32.381582, -86.215604, Taco Bell Montgomer...", 32.381582)]
        [InlineData("30.157708, -85.591198, Taco Bell Panama Cit...", 30.157708)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var latitude = new TacoParser();
            //Act
            var actual = latitude.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
