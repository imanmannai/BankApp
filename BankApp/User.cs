using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class User
    {
        public enum UserRole
        {
            Customer, 
            Admin, 
            BankOwner
        }

        public enum UserStatus
        {
            Active, 
            Locked, 
            Deleted
        }

        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; } 

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public UserStatus Status { get; set; }
    }
}
