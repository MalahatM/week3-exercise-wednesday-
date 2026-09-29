// Static class for menus
static class MenuHelper
{
    // Method for showing the BankAccount menu
    public static void ShowMenu()
    {
        Console.WriteLine("\n--- Bank Account ---");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Show balance");
        Console.WriteLine("4. Exit");
        Console.Write("Choose an option: ");
    }

    // Method for showing the Register and Login menu
    public static void ShowAccountMenu()
    {
        Console.WriteLine("\n--- Account Menu ---");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Login");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option: ");
    }
}