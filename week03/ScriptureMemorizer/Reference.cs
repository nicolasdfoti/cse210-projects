class Reference {

    private string _book = "Joshua";
    private int _chapter = 1;
    private int _startVerse = 9;
    private int _endVerse;

    public Reference(string book, int chapter, int verse) {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void GetDisplayText() {
        Console.WriteLine($"{_book}{_chapter}: {_startVerse}-{_endVerse}");
    }

}