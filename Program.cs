// Temperature uppgift

Temperatur myTemp = new Temperatur();

Console.WriteLine("Write your room's temperature:");

myTemp.Temperature = double.Parse(Console.ReadLine()!);

Console.WriteLine(myTemp.CheckTemperature());

// Car uppgift
Car myCar = new Car();
Console.WriteLine("Write your car's age:");
myCar.Age = double.Parse(Console.ReadLine()!);
Console.WriteLine("Does your car have insurance? (true/false):");
myCar.Insurance = bool.Parse(Console.ReadLine()!);
Console.WriteLine(myCar.CheckAge());


// BankAccount uppgift

BankAccount account = new BankAccount();

bool running = true;

while (running)
{
    MenuHelper.ShowMenu();

    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            Console.Write("Enter amount to deposit: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine()!);

            account.Deposit(depositAmount);
            break;

        case "2":
            Console.Write("Enter amount to withdraw: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine()!);

            account.Withdraw(withdrawAmount);
            break;

        case "3":
            account.ShowBalance();
            break;

        case "4":
            running = false;
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}
  