using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Transaction
    {
        public enum TransactionType
        {
            Deposit, 
            Withdrawal,
            Transfer
        }

        public enum Status
        {
            Pending,
            Completed,
            Failed
        }   
        

        public string TransactionID { get; set; }
        public string SenderAccountNumber { get; set; }

        public string TargetAccountNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public TransactionType TypeOfTransaction { get; set; }

        public string Currency { get; set; }    
        public Status TransactionStatus { get; set; }

    }
}
