using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLTest
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //-- Arrange
            OrderRepository orderRepository = new OrderRepository();

            Order expected = new Order(1)
            {
               OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };



            //-- Act
            Order actual = orderRepository.Retrieve(1);


            //-- Assert
            Assert.Equal(expected.OrderId, actual.OrderId);
            Assert.Equal(expected.OrderDate, actual.OrderDate);
        }
    }
}
