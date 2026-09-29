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
        // Deposit money
        case "1":
            Console.Write("Enter amount to deposit: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine()!);

            account.Deposit(depositAmount);
            break;

        // Withdraw money
        case "2":
            Console.Write("Enter amount to withdraw: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine()!);

            account.Withdraw(withdrawAmount);
            break;

        // Show current balance
        case "3":
            account.ShowBalance();
            break;

        // Exit BankAccount menu
        case "4":
            running = false;
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}


// Register and Login uppgift

// Create an Account object
Account userAccount = new Account();

bool accountRunning = true;

while (accountRunning)
{
    MenuHelper.ShowAccountMenu();

    string accountChoice = Console.ReadLine()!;

    switch (accountChoice)
    {
        // Register
        case "1":
            Console.Write("Enter username: ");
            string registerUsername = Console.ReadLine()!;

            Console.Write("Enter password: ");
            string registerPassword = Console.ReadLine()!;

            // Try to register the user
            if (userAccount.Register(registerUsername, registerPassword))
            {
                Console.WriteLine("Registration successful!");
            }
            else
            {
                Console.WriteLine("Password is not strong enough.");
            }

            break;

        // Login
        case "2":
            Console.Write("Enter username: ");
            string loginUsername = Console.ReadLine()!;

            Console.Write("Enter password: ");
            string loginPassword = Console.ReadLine()!;

            // Check username and password
            if (userAccount.Login(loginUsername, loginPassword))
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Wrong username or password.");
            }

            break;

        // Exit Account menu
        case "3":
            accountRunning = false;
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
}