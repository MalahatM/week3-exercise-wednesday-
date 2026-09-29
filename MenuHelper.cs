// Static class for showing the menu
static class MenuHelper
{
    // Method for showing menu options
    public static void ShowMenu()
    {
        Console.WriteLine("\n--- Bank Account ---");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Show balance");
        Console.WriteLine("4. Exit");
        Console.Write("Choose an option: ");
    }
}