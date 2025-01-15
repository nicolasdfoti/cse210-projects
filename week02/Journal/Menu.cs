class Menu {

    public List<string> _menu = new List<string>() {

        "1. Add event",
        "2. Display Journal",
        "3. Save to a file",
        "4. Load from a file",
        "5. Exit"

    };

    public void DisplayMenu() {

        foreach (var option in _menu) {
            Console.WriteLine(option);
        }

    }

}