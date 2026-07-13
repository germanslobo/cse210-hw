namespace Fractions
{
    public class Fraction
    {
        // Private attributes (Encapsulation)
        private int _top;
        private int _bottom;

        // 1. Constructor with no parameters (Initializes the number to 1/1)
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        // 2. Constructor with one parameter for the top (Denominator defaults to 1)
        public Fraction(int top)
        {
            _top = top;
            _bottom = 1;
        }

        // 3. Constructor with two parameters (one for the top, one for the bottom)
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        // Getter for the top number
        public int GetTop()
        {
            return _top;
        }

        // Setter for the top number
        public void SetTop(int top)
        {
            _top = top;
        }

        // Getter for the bottom number
        public int GetBottom()
        {
            return _bottom;
        }

        // Setter for the bottom number
        public void SetBottom(int bottom)
        {
            // Safeguard to protect the object's state integrity
            if (bottom != 0)
            {
                _bottom = bottom;
            }
        }

        // Returns the fraction in string format (e.g., "3/4")
        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }

        // Returns a double representing the decimal value
        public double GetDecimalValue()
        {
            // Explicitly cast _top to a double to prevent integer truncation during division
            return (double)_top / _bottom;
        }
    }
}