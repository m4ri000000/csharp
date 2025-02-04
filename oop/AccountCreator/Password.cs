using System.Security.Cryptography.X509Certificates;
using System.Text;
using System;

public class Password
{
    public string Value { get; set; }
    public Password(string password)
    {
        if (IsValid(password))
        {
            Value = password;
        }
        else
        {
            throw new ArgumentException("Password must be at least 8 characters long and contain a mix of letters and numbers.");
        }
    }
    public static string GeneratePassword()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
        var random = new Random();
        var builder = new StringBuilder();
        int i;
        for (i = 0; i < 12; i++)
        {
            builder.Append(chars[random.Next(chars.Length)]);
        }
        return builder.ToString();
    }

    public static bool IsValid(string password)
    {
        if (password.Length < 8) return false;
        bool hasLetter = false, hasDigit = false;
        foreach(var c in password)
        {
            if(char.IsLetter(c)) hasLetter = true;
            if(char.IsDigit(c)) hasDigit = true;
        }
        return hasDigit && hasLetter;
    }

    public override string ToString()
    {
        return $"Password: {new string('*', Value.Length)} (hidden)";
    }
}