using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.Clear();

        Console.WriteLine("Welcome to the gym!");
        Console.WriteLine();

        List<Activity> _activities = new List<Activity>();

        Running runningActivity = new Running(new DateTime(2025, 2, 14, 7, 30, 0), 30, 5);
        _activities.Add(runningActivity);

        StationaryBikes stationaryBikes = new StationaryBikes(25, new DateTime(2025, 2, 14, 18, 0, 0), 45);
        _activities.Add(stationaryBikes);

        SwimmingPool swimmingPool = new SwimmingPool(40, new DateTime(2025, 2, 14, 10, 0, 0), 60);
        _activities.Add(swimmingPool);

        foreach (var activity in _activities)
        {
            string activityType = activity.GetType().Name;
            Console.WriteLine($"- {activityType}: {activity.GetSummary()}");
            Console.WriteLine();
        }
    }
}