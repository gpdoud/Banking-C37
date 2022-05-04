using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_C37 {
    internal class Account {

        private static int NextId = 1;

        public int AcctNbr { get; private set; } = 0;
        public string Name { get; set; } = string.Empty;
        public decimal Balance { get; private set; } = 0;

        public bool Deposit(decimal Amount) {
            if(Amount <= 0) {
                Console.WriteLine("Amount must be > zero");
                return false;
            }
            Balance = Balance + Amount;
            return true;
        }

        public bool Withdraw(decimal Amount) {
            if (Amount <= 0) {
                Console.WriteLine("Amount must be > zero");
                return false;
            }
            if (Amount > Balance) {
                Console.WriteLine("Insufficient funds");
                return false;
            }
            Balance = Balance - Amount;
            return true;
        }

        public bool Transfer(decimal Amount, Account ToAccount) {
            var Success = Withdraw(Amount);
            if (Success) {
                ToAccount.Deposit(Amount);
                return true;
            }
            return false;
        }

        public Account() {
            AcctNbr = NextId++;
        }

    }
}
