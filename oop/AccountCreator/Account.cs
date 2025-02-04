using System;
public class Account
{
    public string Username {get; private set;}
    public Account (string Name)
    {
        Username = Name;
    }

    public static string AccountGenerator()
    {
        Console.Write("enter user base: ");
        #pragma warning disable CS8600 
        string baseName = Console.ReadLine();
        string suffix = Guid.NewGuid().ToString().Substring(0, 8);
        return baseName + suffix;
    }
    public override string ToString()
    {
        return $"Account name: {Username}";
    }
}