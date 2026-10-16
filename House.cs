class House
{
    private int _floors;

    public int Floors
    {
        get {return _floors; }
        set { _floors = value; }
    }

    public House(int floors)
    {
        _floors = floors;
    }

    public override string ToString()
    {
        if (_floors % 10 == 1 && _floors % 100 != 11)
        {
            return "дом с " + _floors + " этажом";
        }
        else
        {
            return "дом с " + _floors + " этажами";
        }
    }
}
