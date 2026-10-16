class Name
{
    private string _surname;
    private string _personalName;
    private string _patronymic;

    //задача 1.3
    public Name(string surname, string personalName, string patronymic)
    {
        _surname = surname;
        _personalName = personalName;
        _patronymic = patronymic;
    }
    //

    //задача 4.5
    // public Name(string personalName)
    // {
    //     _personalName = personalName;
    //     _surname = null;
    //     _patronymic = null;
    // }
    
    // public Name(string personalName, string surname)
    // {
    //     _personalName = personalName;
    //     _surname = surname;
    //     _patronymic = null;
    // }
    
    // public Name(string personalName, string surname, string patronymic)
    // {
    //     _personalName = personalName;
    //     _surname = surname;
    //     _patronymic = patronymic;
    // }
    //

    public string Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }

    public string PersonalName
    {
        get { return _personalName; }
        set { _personalName = value; }
    }

    public string Patronymic
    {
        get { return _patronymic; }
        set { _patronymic = value; }
    }

    //задача 1.3
    public override string ToString()
    {
        string result = "";
        if (!string.IsNullOrWhiteSpace(_surname))
        {
            result += _surname + " ";
        }
        if (!string.IsNullOrWhiteSpace(_personalName))
        {
            result += _personalName + " ";
        }
        if (!string.IsNullOrWhiteSpace(_patronymic))
        {
            result += _patronymic + " ";
        }
        return result.TrimEnd();
    }
    //

    //задача 4.5
    // public override string ToString()
    // {
    //     string result = "";
    //     if (!string.IsNullOrWhiteSpace(_personalName))
    //     {
    //         result += _personalName + " ";
    //     }
    //     if (!string.IsNullOrWhiteSpace(_patronymic))
    //     {
    //         result += _patronymic + " ";
    //     }
    //     if (!string.IsNullOrWhiteSpace(_surname))
    //     {
    //         result += _surname + " ";
    //     }
    //     return result.TrimEnd();
    // }
    //
}