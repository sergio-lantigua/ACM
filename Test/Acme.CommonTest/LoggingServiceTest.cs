using ACM.BL;
using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.CommonTest
{
    public class LoggingServiceTest
    {
        [Fact]
        public void WriteToFileTest()
        {
            //arrage
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "pepe@lll.com",
                FirstName = "pedro",
                LastName = "candelario",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(1)
            {
                ProductName = "rake",
                Description = "garden utility",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            //act
            LoggingService.WriteToFile(changedItems);

            //Assert
            //nothing to assert
        }
    }
}
