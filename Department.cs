class Department
{
    private string _name;
    private Employee _boss;

    //задача 3.4
    private Employee[] _employees;
    

    //задача 2.4
    // public Department(string name)
    // {
    //     _name = name;
    //     _boss = null;
    // }
    // 

    //задача 3.4
    public Department(string name)
    {
        _name = name;
        _boss = null;
        _employees = new Employee[0];
    }
    // 

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Employee Boss
    {
        get { return _boss; }
        set { _boss = value; }
    }

    //задача 3.4
    public Employee[] GetEmployees()
    {
        return _employees;
    }
    
    public void AddEmployee(Employee e)
    {
        Employee[] newArr = new Employee[_employees.Length + 1];
        for (int i = 0; i < _employees.Length; i++)
        {
            newArr[i] = _employees[i];
        }
        newArr[_employees.Length] = e;
        _employees = newArr;
    }
    // 

    public override string ToString()
    {
        if (_boss == null)
        {
            return "Отдел " + _name + " (начальник не назначен)";
        }
        else
        {
            return "Отдел " + _name + ", начальник: " + _boss.Name;
        }
    }
}