class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set { _denominator = value; }
    }

    public override string ToString()
    {
        return _numerator + "/" + _denominator;
    }

    public Fraction sum(Fraction other)
    {
        int newNum = _numerator * other._denominator + other._numerator * _denominator;
        int newDen = _denominator * other._denominator;
        return new Fraction(newNum, newDen);
    }

    public Fraction sum(int other)
    {
        return sum(new Fraction(other, 1));
    }

    public Fraction minus(Fraction other)
    {
        int newNum = _numerator * other._denominator - other._numerator * _denominator;
        int newDen = _denominator * other._denominator;
        return new Fraction(newNum, newDen);
    }

    public Fraction minus(int other)
    {
        return minus(new Fraction(other, 1));
    }
    public Fraction mul(Fraction other)
    {
        int newNum = _numerator * other._numerator;
        int newDen = _denominator * other._denominator;
        return new Fraction(newNum, newDen);
    }

    public Fraction mul(int other)
    {
        return mul(new Fraction(other, 1));
    }

    public Fraction div(Fraction other)
    {
        int newNum = _numerator * other._denominator;
        int newDen = _denominator * other._numerator;
        return new Fraction(newNum, newDen);
    }

    public Fraction div(int other)
    {
        return div(new Fraction(other, 1));
    }
}