class Scripture {
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text) {
        _reference = reference;

        _words = new List<Word>();
        string[] words = text.Split(" ");

        foreach (string word in words) {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords(int total) {

        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount > total) {
            int index = random.Next(_words.Count);

            if (!_words[index].IsHidden()) {
                _words[index].Hide();
                hiddenCount++;
            }
            
        }

    }



    public void DisplayScripture() {
        Console.WriteLine($"{_words}");
    }

}