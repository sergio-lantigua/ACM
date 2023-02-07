namespace ACM.BL
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
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

        public Customer()
        {
            _instanceCounter += 1;
        }

    }
}