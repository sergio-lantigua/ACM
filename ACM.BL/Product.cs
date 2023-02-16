using Acme.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; }

        private string _productName = string.Empty;
        public string ProductName { get => _productName.InsertSpaces(); set => _productName = value; }
        public string Description { get; set; } = String.Empty;
        public Decimal? CurrentPrice { get; set; }

        public override string ToString() => ProductName;

        ///<summary>
        /// Validates the product data
        ///</summary>
        ///<returns></returns>
        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public string Log() => $"{ProductId}: {ProductName} Description: {Description} Status: {EntityState.ToString()}";
    }
}
