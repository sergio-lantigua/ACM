namespace ACM.BL
{
    public class Customer
    {
        public Customer():this(0)
        {

        }
        public Customer(int customerId)
        {
            _instanceCounter += 1;
            CustomerId = customerId; 
            AddressList = new List<Address>();

        }
        public List<Address> AddressList { get; set; }
        public string FirstName { get; set; }
        public int CustomerType { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; }
        public string FullName  
        {
            get 
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName; 
            }
        }

        private string _lastName;
        public string LastName { get => _lastName; set => _lastName = value; }
        public static int InstanceCounter { get => _instanceCounter; }

        private static int _instanceCounter;

        ///<summary>
        /// Validates the customer data
        ///</summary>
        ///<returns></returns>
        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;

            return isValid;
        }
    }
}