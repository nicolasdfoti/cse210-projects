public class Fraction {

    // Attributes
    private int _top_number = 0;
    private int _bottom_number = 0;

    // Constructors

    public Fraction() {
        _top_number = 1;
        _bottom_number = 1;
    }

    public Fraction(int top) {
        _top_number = top;
        _bottom_number = 1;
    }

    public Fraction(int top, int bottom) {
        _top_number = top;
        _bottom_number = bottom;
    }

    // Getters and Setters
    public int GetTop() {
        return _top_number;
    }

    public int GetBottom() {
        return _bottom_number;
    }

    public void SetTop(int firstNumber) {
        _top_number = firstNumber;
    }

    public void SetBottom(int secondNumber) {
        _bottom_number = secondNumber;
    }

    // Methods
    public void GetFractionString() {
        SetTop(3);
        SetBottom(4);
    }

    public double GetDecimalValue(int firstNumber, int bottomNumber) {
        return firstNumber % bottomNumber;
    }

}