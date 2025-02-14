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
                SaveGoals();
            }

            else if (choice == "4")
            {
                LoadGoals();
            }

            else if (choice == "5")
            {
                RecordEvent();
            }

            else if (choice == "6" || choice == "quit".ToLower())
            {
                Console.WriteLine("Thanks for using the Eternal Quest Program! Keep goaling! :)");
                break;
            }
        } 
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"- You have {_score} points");
        Console.WriteLine();

        if (_score >= 20000)
        {
            Console.WriteLine("Congrats! You are now in level 7: You are the Maze King!");
        }

        else if (_score >= 10000)
        {
            Console.WriteLine("Congrats! You are now in level 6: You're a Maze Pro!");
        }

        else if (_score >= 8000)
        {
            Console.WriteLine("Congrats! You are now in level 5: You become the Maze's Guide!");
        }

        else if (_score >= 6000)
        {
            Console.WriteLine("Congrats! You are now in level 4: You are now a Maze Guide.");
        }

        else if (_score >= 4000)
        {
            Console.WriteLine("Congrats! You are now in level 3: You become a Maze Explorer.");
        }

        else if (_score >= 2000)
        {
            Console.WriteLine("Congrats! You are now in level 2: Entering the Goal's Maze.");
        }

        else if (_score >= 0)
        {
            Console.WriteLine("You're on level 1.");
        }

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
        if (_goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals yet.");
            Console.WriteLine();
        }

        else
        {
            foreach (var goal in _goals)
            {
            Console.WriteLine(goal.GetDetailsString());
            }

            Console.WriteLine();
        }
        
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

            string brackets = "";

            EternalGoal eternal = new EternalGoal(brackets, name, description, points);

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

        int answer = int.Parse(Console.ReadLine());
        Console.WriteLine();

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
        Console.Write("- What is the name of the file: ");
        string fileName = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(fileName))
        {
            file.WriteLine(_score);

            foreach (var goal in _goals)
            {
                file.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }

        Console.WriteLine("Saved successfully!");
        Console.WriteLine();
    }

    public void LoadGoals()
    {
        _goals.Clear();
        Console.Write("- What is the name of the file: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            _score = int.Parse(lines[0]);
            
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(",");

                if (parts.Length == 3)
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    Goal simpleGoal = new SimpleGoal(name, description, points);
                    _goals.Add(simpleGoal);
                }

                else if (parts.Length == 4)
                {
                    string brackets = parts[1];
                    string name = parts[2];
                    string description = parts[3];
                    int points = int.Parse(parts[4]);

                    Goal eternalGoal = new EternalGoal(brackets, name, description, points);
                    _goals.Add(eternalGoal);
                }

                else if (parts.Length >= 5)
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);

                    Goal checkListGoal = new ChecklistGoal(target, bonus, name, description, points);
                    _goals.Add(checkListGoal);
                }

                Console.WriteLine("Loaded successfully!");
                Console.WriteLine();
            }
        }

        else
        {
            Console.WriteLine($"File '{fileName}' does not exist.");
        }

    }
}