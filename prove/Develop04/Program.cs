

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
        Thread.Sleep(3000);
        for (int i = Duration; i > 0; i--)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
        }
    }
}

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Preparing to begin...");
        Thread.Sleep(3000);
        Random rnd = new Random();
        int remainingTime = Duration;
        while (remainingTime > 0)
        {
            int questionIndex = rnd.Next(questions.Count);
            Console.WriteLine(prompts[questionIndex]);
            Thread.Sleep(3000);
            Console.WriteLine(questions[questionIndex]);
            remainingTime -= 5;
            Thread.Sleep(2000);
        }
    }
}

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public

}