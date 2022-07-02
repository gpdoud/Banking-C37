using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Banking_C37.Exceptions;

namespace Banking_C37 {
    internal class Account {

        private static int NextId = 1;

        public int AcctNbr { get; private set; } = 0;
        public string Name { get; set; } = string.Empty;
        public decimal Balance { get; private set; } = 0;

        public bool Deposit(decimal Amount) {
            if(Amount <= 0) {
                //Console.WriteLine("Amount must be > zero");
                var ex =  new AmountGreaterThanZeroException("Amount must be > zero");
                ex.Amount = Amount;
                throw ex;
            }
            Balance = Balance + Amount;
            return true;
        }

        public bool Withdraw(decimal Amount) {
            if (Amount <= 0) {
                var ex = new AmountGreaterThanZeroException("Amount must be > zero");
                ex.Amount = Amount;
                throw ex;
            }
            if (Amount > Balance) {
                throw new Exception("Insufficient funds");
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
