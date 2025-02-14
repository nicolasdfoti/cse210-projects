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

        Running runningActivity = new Running(new DateTime(2025, 2, 14), 45, 10);
        _activities.Add(runningActivity);

        StationaryBikes stationaryBikes = new StationaryBikes(40, new DateTime(2025, 2, 14), 10);
        _activities.Add(stationaryBikes);

        SwimmingPool swimmingPool = new SwimmingPool(100, (new DateTime(2025, 2, 14)), 40);
        _activities.Add(swimmingPool);

        foreach (var activity in _activities)
        {
            string activityType = activity.GetType().Name;
            Console.WriteLine($"{activityType}: {activity.GetSummary()}");
            Console.WriteLine();
        }
    }
}