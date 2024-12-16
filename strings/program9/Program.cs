using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter Last Name and Name (format: APELLIDOS, NOMBRE): ");
        string lastname_name = Console.ReadLine();

        int posComma = -1;

        for (int i = 0; i < lastname_name.Length; i++)
        {
            if (posComma == -1 && lastname_name[i] == ',')
            {
                posComma = i;
            }
        }

        if (posComma != -1)
        {
            string lastname = "";
            for (int i = 0; i < posComma; i++)
            {
                lastname += lastname_name[i];
            }
            string name = "";
            for (int i = posComma + 1; i < lastname_name.Length; i++)
            {
                name += lastname_name[i];
            }

            string result = name + " " + lastname;
            Console.WriteLine("result: " + result);
        }
    }
}