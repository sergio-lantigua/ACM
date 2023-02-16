using Acme.Common;

namespace Acme.CommonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesTestValid()
        {
            // Arrange
            string source = "SonicScrewdriver";
            string expected = "Sonic Screwdriver";

            //Act
            string actual = source.InsertSpaces();



            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void InsertSpacesTestWithExistingSpace()
        {
            // Arrange
            string source = "Sonic Screwdriver";
            string expected = "Sonic Screwdriver";

            //Act
            string actual = source.InsertSpaces();


            //Assert
            Assert.Equal(expected, actual);
        }
    }
}