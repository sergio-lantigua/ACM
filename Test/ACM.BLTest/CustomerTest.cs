using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
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
            Customer customer = new Customer
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
            Customer customer = new Customer
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
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };

            string expected = "Bilbo";


            //-- Act


            //-- Assert
            Assert.Equal(1, Customer.InstanceCounter);

        }


    }
}