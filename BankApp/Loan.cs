using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Loan
    {
        public enum LoanStatus
        {
            Active,
            PaidOff,
            Defaulted, // When the borrower fails to repay
            Closed
        }

        public string LoanID { get; set; }
        public string BorrowerID { get; set; }
        // The original borrowed amount
        public decimal PrincipalAmount { get; set; }
        // The current outstanding amount
        public decimal OutstandingAmount { get; set; }
        public float InterestRate { get; set; } // Annual interest rate as a percentage
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }

        public LoanStatus Status { get; set; }

    }
}
