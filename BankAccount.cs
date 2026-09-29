// Uppgift BankAccount

// Class for bank account
class BankAccount
{
    // Field for balance
    private decimal balance = 0;

    // Method for depositing money
    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    // Method for withdrawing money
    public void Withdraw(decimal amount)
    {
        // Check if there is enough money in the account
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Not enough money in the account.");
        }
    }

    // Method for showing the current balance
    public void ShowBalance()
    {
        Console.WriteLine($"Current balance: {balance}");
    }
}