using System;
using System.Globalization;
public class Chatbot
{
    public string Name { get; set; }
    public string GreetingMessage { get; set; }
    public List<string> FallbackResponses { get; set; }

    public Chatbot(string name)
    {
        Name = name;
        GreetingMessage = $"Hey there! I am {Name}, your chatbot, how can I help you today?";
        FallbackResponses = new List<string>
        {
            "I'm sorry, could you rephrase that?",
            "I'm not sure I understood that.",
            "Let's try something else, how can I help?"
        };
    }
    public virtual void Greet()
    {
        Console.WriteLine(GreetingMessage);
    }
    public virtual string Respond(string input)
    {
        if (input.ToLower().Contains("hello"))
            return  "Hi! how can I help?";
        else if (input.ToLower().Contains("bye"))
            return "Goodbye!";
        else
            return GetFallbackResponse();
    }

    public string GetFallbackResponse()
    {
        Random random = new Random();
        int index = random.Next(FallbackResponses.Count);
        return FallbackResponses[index];
    }
}

public class SpecializedChatbot : Chatbot
{
    public Dictionary<string, string> Database { get; set; }
    public SpecializedChatbot(string name) : base(name)
    {
        Database = new Dictionary<string, string>
        {
            {"weather", "I can't predict the weather just yet!"},
            {"time", $"The current date is {DateTime.Now.ToShortDateString()}."},
            {"name", $"My name is {Name}, nice to meet you!"}
        };
    }
    public override string Respond(string input)
    {
        foreach (var keyword in Database.Keys)
        {
            if (input.ToLower().Contains(keyword))
                return Database[keyword];
        }
        return base.Respond(input);
    }
}