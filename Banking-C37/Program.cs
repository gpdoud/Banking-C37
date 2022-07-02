using Banking_C37;
using Banking_C37.Exceptions;

var sav1 = new SavingsComp();
sav1.Name = "My Savings";

sav1.Deposit(100);
try {
    sav1.Withdraw(-200);
} catch (AmountGreaterThanZeroException ex) {
    Console.WriteLine($"{ex.Message}; Amount was ${ex.Amount:n}");
} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}
sav1.PayInterest(8);
Console.WriteLine(sav1.Balance);


/*
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
*/