using System;
namespace FitnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();
            
            // create some activities of different types
            RunningActivity running = new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0);
            CyclingActivity cycling = new CyclingActivity(new DateTime(2022, 11, 4), 45, 20.0);
            SwimmingActivity swimming = new SwimmingActivity(new DateTime(2022, 11, 5), 60, 30);
            
            // add them to the list
            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

            // display the summary for each activity
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }

    class Activity
    {
        private DateTime date;
        private int mins;

        public Activity(DateTime date, int mins)
        {
            this.date = date;
            this.mins = mins;
        }

        public virtual double GetDistance()
        {
            // default implementation, overridden in derived classes
            return 0.0;
        }

        public virtual double GetSpeed()
        {
            // default implementation, overridden in derived classes
            return 0.0;
        }

        public virtual double GetPace()
        {
            // default implementation, overridden in derived classes
            return 0.0;
        }

        public string GetSummary()
        {
            // use the other methods to produce the summary string
            return $"{date:d} {GetType().Name} ({mins} min)- Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
        }
    }

    class RunningActivity : Activity
    {
        private double distance; // in miles

        public RunningActivity(DateTime date, int mins, double distance) : base(date, mins)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return distance / (double)mins * 60.0; // mph
        }

        public override double GetPace()
        {
            return (double)mins / distance; // min per mile
        }
    }

    class CyclingActivity : Activity
    {
        private double speed; // in kph

        public CyclingActivity(DateTime date, int mins, double speed) : base(date, mins)
        {
            this.speed = speed;
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetDistance()
        {
            return speed / 60.0 * (double)mins; // km
        }

        public override double GetPace()
        {
            return 60.0 / speed; // min per km
        }
    }

    class SwimmingActivity : Activity
    {
        private int laps;

        public SwimmingActivity(DateTime date, int mins, int laps) : base(date, mins)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return laps * 50.0 / 1000.0; // km
        }

        public override double GetSpeed()
        {
            return GetDistance() / (double)mins * 60.0; // kph
        }

        public override double GetPace()
        {
            return (double)mins / Get
        
            List<Activity> activities = new List<Activity>();
            
            // create some activities of different types
            RunningActivity running = new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0);
            CyclingActivity cycling = new CyclingActivity(new DateTime(2022, 11, 4), 45, 20.0);
            SwimmingActivity swimming = new SwimmingActivity(new DateTime(2022, 11, 5), 60, 30);
            
            // add them to the list
            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

            // display the summary for each activity
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
    
    



