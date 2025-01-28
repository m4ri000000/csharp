using System;
public class CheckNumber 
{
    public bool IsPerfectSquare(int n)
    {
        if (n < 0) return false;

        int sqrt = (int)Math.Sqrt(n);
        return sqrt * sqrt == n;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        CheckNumber check = new CheckNumber(); //calling object here
        Console.WriteLine($"{check.IsPerfectSquare(16)}");
        Console.WriteLine($"{check.IsPerfectSquare(21)}");
    }
}