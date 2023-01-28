using System;
class Activity
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
    }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public virtual void Start()
    {
        Console.WriteLine("Starting activity: " + Name);
        Console.WriteLine("Description: " + Description);
        Console.Write("Enter duration (in seconds): ");
        Duration = int.Parse(Console.ReadLine());
    }

    public virtual void End()
    {
        Console.WriteLine("You have completed the " + Name + " activity for " + Duration + " seconds.");
    }
}

class BreathingActivity : Activity
{
    public override void Start()
    {
        base.Start();
        Console.WriteLine("Preparing to begin...");
        Thread.Sleep(30);
        for (int i = Duration; i > 0; i--)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(10);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(10);
        }
    }
}

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
       
       
    };

    private List<string> questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
    };

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Preparing to begin...");
        Thread.Sleep(30);
        Random rnd = new Random();
        int remainingTime = Duration;
        while (remainingTime > 0)
        {
            int questionIndex = rnd.Next(questions.Count);
            Console.WriteLine(prompts[questionIndex]);
            Thread.Sleep(30);
            Console.WriteLine(questions[questionIndex]);
            remainingTime -= 5;
            Thread.Sleep(20);
        }
    }
}

class ListingActivity : Activity
{    private List<string> prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public

};

