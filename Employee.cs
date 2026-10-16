class Employee
{
    private string _name;
    private Department _department;

    //задача 2.4
    // public Employee(string name, Department department)
    // {
    //     _name = name;
    //     _department = department;
    // }
    //

    //задача 3.4
    public Employee(string name, Department department)
    {
        _name = name;
        _department = department;
        department.AddEmployee(this);
    }
    //

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Department Department
    {
        get { return _department; }
        set { _department = value; }
    }

    public override string ToString()
    {
        if (_department.Boss == this)
        {
            return _name + " начальник отдела " + _department.Name;
        }
        else if (_department.Boss == null)
        {
            return _name + " работает в отделе " + _department.Name + ", начальник не назначен";
        }
        else
        {
            return _name + " работает в отделе " + _department.Name + ", начальник которого " + _department.Boss.Name;
        }
    }
}