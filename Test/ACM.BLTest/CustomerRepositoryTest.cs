using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //-- Arrange
            CustomerRepository customerRepository = new CustomerRepository();

            Customer expected = new Customer(1)
            {
               EmailAddress = "pepe@gmail.com",
               FirstName = "Sergio",
               LastName = "lantigua"
            };



            //-- Act
            Customer actual = customerRepository.Retrieve(1);


            //-- Assert
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
        }

    }
}
