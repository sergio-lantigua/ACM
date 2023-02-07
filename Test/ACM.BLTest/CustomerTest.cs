using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer(1)
            {
                FirstName = "Bilbo",
                LastName = "Baggings"
            };
 
            string expected = "Baggings, Bilbo";


            //-- Act
            string actual = customer.FullName;


            //-- Assert
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void FullName_FirstNameEmpty_ReturnLastName() {
            //-- Arrange
            Customer customer = new Customer(1)
            {
                LastName = "Baggings"
            };

            string expected = "Baggings";


            //-- Act
            string actual = customer.FullName;


            //-- Assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void FullName_LastNameEmpty_ReturnFirstName()
        {
            //-- Arrange
            Customer customer = new Customer(1)
            {
                FirstName = "Bilbo"
            };

            string expected = "Bilbo";


            //-- Act
            string actual = customer.FullName;


            //-- Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void InstanceCounter()
        {
            //-- Arrange
            Customer customer = new Customer(1)
            {
                FirstName = "Bilbo"
            };

            string expected = "Bilbo";


            //-- Act


            //-- Assert
            Assert.Equal(1, Customer.InstanceCounter);

        }

        [Fact]
        public void ValidateValid()
        {
            //-- Arrange
            Customer customer = new Customer(1)
            {
                FirstName = "Bilbo",
                LastName = "Baggings"
            };

            bool expected = true;


            //-- Act
            bool actual = customer.Validate();


            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Validate_MissingFirstNameLastName_ReturnFalse( )
        {
            //-- Arrange
            Customer customer = new Customer(1)
            {
                EmailAddress = "pepe@gmail.com"
            };

            bool expected = false;


            //-- Act
            bool actual = customer.Validate();


            //-- Assert
            Assert.Equal(expected, actual);
        }


    }
}