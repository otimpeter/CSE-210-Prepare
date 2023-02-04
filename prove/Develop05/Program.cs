using System;
namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.AddGoal(new SimpleGoal("Run a marathon", 1000));
            user.AddGoal(new EternalGoal("Read scriptures", 100));
            user.AddGoal(new ChecklistGoal("Attend the temple", 50, 10, 500));

            user.RecordEvent("Run a marathon");
            user.RecordEvent("Read scriptures");
            user.RecordEvent("Read scriptures");
            user.RecordEvent("Attend the temple");
            user.RecordEvent("Attend the temple");

            Console.WriteLine("User's score: " + user.Score);
            Console.WriteLine("Goals: ");
            foreach (Goal goal in user.Goals)
            {
                Console.WriteLine(goal);
            }
        }
    }

    abstract class Goal
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public bool IsComplete { get; set; }

        public Goal(string name, int points)
        {
            Name = name;
            Points = points;
            IsComplete = false;
        }

        public abstract void RecordEvent();
        public override string ToString()
        {
            return Name + " - " + (IsComplete ? "Complete" : "Incomplete");
        }
    }

    class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int points) : base(name, points) { }

        public override void RecordEvent()
        {
            IsComplete = true;
        }
    }

    class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points) { }

        public override void RecordEvent()
        {
            Points += Points;
        }
    }

    class ChecklistGoal : Goal
    {
        public int TimesCompleted { get; set; }
        public int TargetCompletions { get; set; }
        public int BonusPoints { get; set; }

        public ChecklistGoal(string name, int points, int targetCompletions, int bonusPoints) : base(name, points)
        {
            TargetCompletions = targetCompletions;
            BonusPoints = bonusPoints;
        }

        public override void RecordEvent()
        {
            TimesCompleted++;
            if (TimesCompleted == TargetCompletions)
            {
                IsComplete = true;
                Points += BonusPoints;
            }
        }

        public override string ToString()
        {
            return Name + " - Completed " + TimesCompleted + "/" + TargetCompletions + " times";
        }
    }

    class User
    {
        public List<Goal> Goals { get; set; }
        public int Score { get; set; }

        public User()
        {
            Goals = new List<Goal>();
            Score = 0;
        }

        public void AddGoal(Goal goal)
        {
            Goals.Add(goal);
        }

        public void RecordEvent(string goalName)
       
