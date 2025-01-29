using BankLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankServices
{
    public class InterestService
    {
        public void ApplyInterestToAccounts(List<Account> accounts)
        {
            foreach (var account in accounts)
            {
                if (account is SavingsAccount savingsAccount)
                {
                    savingsAccount.ApplyInterest();
                    Console.WriteLine($"Interest applied to SavingsAccount ({savingsAccount.AccountNumber}) New Balance {savingsAccount.Balance:C}");
                }

                if (account is HighInterestSavingsAccount highInterestSavingsAccount)
                {
                    highInterestSavingsAccount.ApplyInterest();
                    highInterestSavingsAccount.ApplyBonusInterest(0.01m);
                    Console.WriteLine($"Bonus Interest applied to SavingsAccount ({highInterestSavingsAccount.AccountNumber}) New Balance {highInterestSavingsAccount.Balance:C}");
                }
            }
        }
    }
}
