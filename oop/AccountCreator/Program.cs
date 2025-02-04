class Program
{
    static void Main(string[] args)
    {
        string username = Account.AccountGenerator();
        Account account = new Account(username);
        Console.WriteLine("Generated account: " + account);

        Console.Write("Generate password? [Y/N]: ");
        #pragma warning disable CS8600
        string choice = Console.ReadLine();
        string passwordValue;

        if (choice.ToLower() == "y")
        {
            passwordValue = Password.GeneratePassword();
            Console.WriteLine("Generated Password: " + passwordValue);
        }
        else
        {
            Console.Write("Enter password: ");
            passwordValue = Console.ReadLine();
        }

        if (!Password.IsValid(passwordValue))
        {
            Console.WriteLine("Error: Password must be at least 8 characters and contain a mix of letters and numbers.");
        }
        else
        {
            Password password = new Password(passwordValue);
            Console.WriteLine("password successfully created!");
        }

        Console.WriteLine("thanks for using the generator!");
    }
}   