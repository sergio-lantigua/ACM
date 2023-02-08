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

        [Fact]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            CustomerRepository customerRepository = new CustomerRepository();

            Customer expected = new Customer(1)
            {
                EmailAddress = "pepe@gmail.com",
                FirstName = "Sergio",
                LastName = "lantigua",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag end",
                        StreetLine2 = "Bagshot row",
                        City = "La vega",
                        State = "consepcio la vega",
                        Country = "RD",
                        PostalCode = "12345"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Bag end",
                        StreetLine2 = "Bagshot row",
                        City = "Santiago",
                        State = "Santiago",
                        Country = "RD",
                        PostalCode = "145"
                    }
                }
            };



            //-- Act
            Customer actual = customerRepository.Retrieve(1);


            //-- Assert
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);

            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.Equal(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.Equal(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.Equal(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.Equal(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.Equal(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }

    }
}
