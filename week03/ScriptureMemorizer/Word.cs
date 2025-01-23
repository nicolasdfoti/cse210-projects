class Word {

    private string _word;
    private bool _isHidden = false;

    public Word(string word) {
        _word = word;
    }

    public void Hide() {
        _isHidden = true;
    }

    public void Show() {
        _isHidden = false;
    }

    public bool IsHidden() {
        return _isHidden;
    }

    public string GetDisplayText() {

        if (_isHidden == true) {
            foreach (var letter in _word) {
                return "_";
            }
        }

        else if (_isHidden == false) {
            return _word;
        }
        
        return " ";

    }   

}