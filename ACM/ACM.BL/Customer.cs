using System;
using ACM.Common;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public OperationResult ValidateEmail()
        {
            var result = new OperationResult
            {
                Success = true
            };
            result.Add("Email Successfull");

            return result;
        }
    }
}
