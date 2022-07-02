using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_C37 {
    
    internal class SavingsComp {

        private Account _Account { get; set; }

        public int AcctNbr {
            get { return _Account.AcctNbr; }
        }

        public string Name {
            get { return _Account.Name; }
            set { _Account.Name = value; }
        }

        public decimal  Balance {
            get { return _Account.Balance; }
        }

        public decimal InterestRate { get; set; } = 0.12m;

        public void PayInterest(int months) {
            var interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
        }

        public bool Deposit(decimal Amount) {
            return _Account.Deposit(Amount);
        }
        public bool Withdraw(decimal Amount) {
            return _Account.Withdraw(Amount);
        }
        public bool Transfer(decimal Amount, Account ToAccount) {
            return _Account.Transfer(Amount, ToAccount);
        }

        public SavingsComp() {
            _Account = new Account();
        }
    }
}
