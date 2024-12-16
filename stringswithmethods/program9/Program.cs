using System;
class Program
{
    static void Main()
    {
        string[] typesOfExpense = {"food", "accomodation", "transport", "clothing"};
        double[] expenses = new double[4];
        int[] counters = new int[4];

        Console.WriteLine("enter the expenses in different categories, enter 'end' to end.");

        bool keepGoing = true;

        while (keepGoing)
        {
            Console.WriteLine("enter the type of expense (food, accomodation, transport, clothing): ");
            string typeOfExpense = Console.ReadLine().ToLower();

            if (typeOfExpense == "end")
            {
                keepGoing = false;
                continue;
            }

            int indexType = -1;
            for (int i = 0; i < typesOfExpense.Length; i++)
            {
                if (typesOfExpense[i].ToLower() == typeOfExpense)
                {
                    indexType = i;
                }
            }

            if (indexType == -1)
            {
                Console.WriteLine("invalid type of expense, try again.");
                continue;
            }

            Console.WriteLine("enter the amount of expense: ");
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount) || amount < 0)
            {
                Console.WriteLine("invalid amount, try again.");
            }

            expenses[indexType] += amount;
            counters[indexType] ++;
        }

        Console.WriteLine($"\nexpenses amounts per type: ");
        for (int i = 0; i < expenses.Length; i++)
        {
            Console.WriteLine($"{typesOfExpense[i]}: {expenses[i]}€");
        }

        Console.WriteLine($"\namount of expenses in food: {counters[0]}");

        double maxExpense = expenses[0];
        string typeAndExpense = typesOfExpense[0];

        for (int i = 1; i < expenses.Length; i++)
        {
            if (expenses[i] > maxExpense)
            {
                maxExpense = expenses[i];
                typeAndExpense = typesOfExpense[i];
            }
        }

        Console.WriteLine($"\nThe type of expense in which the most was spent is: {typeAndExpense} for a total of {maxExpense}€.");
    }
}