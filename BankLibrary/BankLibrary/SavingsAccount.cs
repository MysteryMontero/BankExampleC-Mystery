using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class SavingsAccount : Account
    {
        public decimal Interestrate { get; private set; }
        public SavingsAccount(string accountNumber, string accountname, decimal initialBalance, decimal interestRate) :
            base(accountNumber, accountname, initialBalance)
        {
            Interestrate = interestRate;
        }
        public void ApplyInterest()
        {
            decimal interestPayment = Balance * Interestrate;
            this.Deposit(interestPayment);
        }
    }
}
