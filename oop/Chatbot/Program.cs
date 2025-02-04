using System;
class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the chatbot
            Chatbot myChatbot = new SpecializedChatbot("cookie");

            // Greet the user
            myChatbot.Greet();

            // Start conversation loop
            string input;
            do
            {
                Console.Write("You: ");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                string response = myChatbot.Respond(input);
                Console.WriteLine($"{myChatbot.Name}: {response}");

            } while (!input.Equals("bye", StringComparison.OrdinalIgnoreCase));
        }
    }