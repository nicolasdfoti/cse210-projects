public class GoalsManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalsManager()
    {}

    public string choice;

    public void Start()
    {

        Console.WriteLine("Welcome to the Eternal Quest Program!");
        Console.WriteLine();

        choice = "";

        while (choice != "quit")
        {

            DisplayPlayerInfo();

            Console.WriteLine("Choose one of the following: ");
            Console.WriteLine();

            Console.WriteLine("1. Create New Goal.");
            Console.WriteLine("2. List Goals.");
            Console.WriteLine("3. Save Goals.");
            Console.WriteLine("4. Load Goals.");
            Console.WriteLine("5. Record Event.");
            Console.WriteLine("6. Quit.");
            Console.WriteLine();

            Console.Write("Answer here: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
                Console.WriteLine();
            }

            else if (choice == "2")
            {
                Console.WriteLine();
                Console.WriteLine("- List of goals: ");
                ListGoalDetails();
            }

            else if (choice == "3")
            {

            }

            else if (choice == "4")
            {

            }

            else if (choice == "5")
            {
                RecordEvent();
            }

            else if (choice == "6" || choice == "quit".ToLower())
            {
                Console.WriteLine("Thanks for using the Eternal Quest Program! Keep goaling! :)");
            }
        } 
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"- You have {_score} points");
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
        Console.WriteLine();
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }

        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("- What type of goal do you want to add?");
        Console.WriteLine();

        Console.WriteLine("1. Simple Goal.");
        Console.WriteLine("2. Eternal Goal.");
        Console.WriteLine("3. Checklist Goal.");
        Console.WriteLine();

        Console.Write("- Enter your answer: ");

        string answer = Console.ReadLine();
        Console.WriteLine();

        if (answer == "1")
        {
            Console.Write("- What is the name of the goal? ");
            string name = Console.ReadLine();

            Console.Write("- What is the description of the goal? ");
            string description = Console.ReadLine();

            Console.Write("- How many points do you want this goal to have? ");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine();

            SimpleGoal simple = new SimpleGoal(name, description, points);

            _goals.Add(simple);
        }

        else if (answer == "2")
        {
            Console.Write("- What is the name of the goal? ");
            string name = Console.ReadLine();

            Console.Write("- What is the description of the goal? ");
            string description = Console.ReadLine();

            Console.Write("- How many points do you want this goal to have? ");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine();

            EternalGoal eternal = new EternalGoal(name, description, points);

            _goals.Add(eternal);
        }

        else if (answer == "3")
        {
            Console.Write("- What is the name of the goal? ");
            string name = Console.ReadLine();

            Console.Write("- What is the description of the goal? ");
            string description = Console.ReadLine();

            Console.Write("- How many points do you want this goal to have? ");
            int points = int.Parse(Console.ReadLine());

            Console.Write("- How many time does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("- What is the bonus for accomplishing this goal? ");
            int bonus = int.Parse(Console.ReadLine());
            Console.WriteLine();

            ChecklistGoal checklist = new ChecklistGoal(target, bonus, name, description, points);

            _goals.Add(checklist);
        }

        else 
        {
            Console.WriteLine("Please, enter a numeric value.");
            Console.WriteLine();
        }
    
    }

    public void RecordEvent()
    {
        int number = 1;

        foreach (var goal in _goals)
        {
            Console.WriteLine($"{number++}. {goal.GetName()}");
        }

        Console.WriteLine();
        Console.WriteLine("- Which goal did you accomplish?");
        Console.Write("- Enter your answer in numbers: ");
        Console.WriteLine();
        
        int answer = int.Parse(Console.ReadLine());

        _goals[answer - 1].RecordEvent();

        if (_goals[answer - 1] is ChecklistGoal checklist && checklist.isComplete())
        {
            _score += checklist.GetPoints() + checklist.GetBonus();
            Console.WriteLine($"Congratulations! You completed {checklist.GetName()} and earned {checklist.GetBonus()}");
        }

        else if (_goals[answer - 1] is ChecklistGoal checklist1 && !checklist1.isComplete())
        {
            _score += checklist1.GetPoints();
            checklist1.GetStringRepresentation();
        }

        else
        {
        _score += _goals[answer - 1].GetPoints();
        Console.WriteLine("Event recorded successfully!");
        Console.WriteLine($"You earned {_goals[answer - 1].GetPoints()}");
        Console.WriteLine();
        }

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }
}