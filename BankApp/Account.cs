using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Account
    {
        public enum AccountStatus
        {
            Active,
            Frozen,
            Closed
        }

        public string AccountNumber { get; set; }
        public string OwnerID { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }

        public string Currency { get; set; }    
        public AccountStatus Status { get; set; }
    }
}
