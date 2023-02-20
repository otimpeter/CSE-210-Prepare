using System;
using System.Threading;
// MINDFULL Activity
namespace MindfulnessActivities
{
    class Mindfulness
    {
        static void Main(string[] args)
        {
            int userChoice;
            int duration;
            int counter = 0;
            string input;
            List<string> items = new List<string>();

            Console.WriteLine("Welcome to Mindfulness Activities!");
            Console.WriteLine("Choose an activity: ");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Listing");

            input = Console.ReadLine();
            userChoice = Convert.ToInt32(input);

            Console.WriteLine("Enter the duration of the activity in seconds: ");
            input = Console.ReadLine();
            duration = Convert.ToInt32(input);

            Console.WriteLine("Prepare to begin. The activity will start in 3 seconds...");
            Thread.Sleep(3000);

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("Breathing Activity");
                    Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

                    for (int i = duration; i > 0; i--)
                    {
                        Console.WriteLine("Breathe in... ");
                        Thread.Sleep(1000);
                        Console.WriteLine("Breathe out... ");
                        Thread.Sleep(1000);
                    }

                    Console.WriteLine("You have done a good job! You completed the Breathing Activity for " + duration + " seconds.");
                    Thread.Sleep(3000);
                    Console.WriteLine("The activity has ended.");
                    break;

                case 2:
                    Console.WriteLine("Listing Activity");
                    Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

                    string[] prompts = {
                        "Who are people that you appreciate?",
                        "What are personal strengths of yours?",
                        "Who are people that you have helped this week?",
                        "When have you felt the Holy Ghost this month?",
                        "Who are some of your personal heroes?"
                    };

                    Random rnd = new Random();
                    int randomPrompt = rnd.Next(0, prompts.Length);

                    Console.WriteLine(prompts[randomPrompt]);
                    Console.WriteLine("Start listing items in 3 seconds...");
                    Thread.Sleep(3000);

                    for (int i = duration; i > 0; i--)
                    {
                        Console.WriteLine("Enter an item: ");
                        input = Console.ReadLine();
                        items.Add(input);
                        counter++;
                    }

                    Console.WriteLine("You have done a good job! You listed " + counter + " items in " + duration + " seconds.");
                    Thread.Sleep(3000);
                    Console.WriteLine("The activity has ended.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.ReadLine();
        }
    }
}