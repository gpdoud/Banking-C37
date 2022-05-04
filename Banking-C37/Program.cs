using Banking_C37;

var acct1 = new Account() {
    Name = "Checking 1"
};
var acct2 = new Account() {
    Name = "Checking 2"
};

acct1.Deposit(1000);
acct2.Deposit(500);

acct1.Withdraw(200);
acct2.Withdraw(50);

Console.WriteLine($"Acct1 balance is {acct1.Balance:c}, Acct2 balance is {acct2.Balance:c}");

acct1.Withdraw(1000);

Console.WriteLine($"Acct1 balance is {acct1.Balance:c}, Acct2 balance is {acct2.Balance:c}");

acct2.Transfer(100, acct1);

Console.WriteLine($"Acct1 balance is {acct1.Balance:c}, Acct2 balance is {acct2.Balance:c}");

acct1.Deposit(-100);
acct2.Withdraw(-200);

Console.WriteLine($"Acct1 balance is {acct1.Balance:c}, Acct2 balance is {acct2.Balance:c}");