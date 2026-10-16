class Program
{
    static void Main()
    {
        Validator v = new Validator();
        Program p = new Program();

        int choice = v.ReadIntInRange(
            "Выберите задание:\n" +
            "1 - Имя (1.3 + 4.5)\n" +
            "2 - Дом (1.5)\n" +
            "3 - Сотрудники и отделы (2.4 + 3.4)\n" +
            "4 - Дроби (5.5)\n" +
            "Ваш выбор: ",
            1, 4);

        switch (choice)
        {
            case 1: p.RunName(v);       break;
            case 2: p.RunHouse(v);      break;
            case 3: p.RunDepartment(v); break;
            case 4: p.RunFraction(v);   break;
        }
    }

    //
    //  ЗАДАНИЕ 1.3 / 4.5 - ИМЯ
    //  Сейчас работает 1.3. Для 4.5 - поменять комментарии
    //  в Name.cs и в методе RunName ниже.
    //

    private void RunName(Validator v)
    {
        //задача 1.3: порядок (фамилия, имя, отчество)
        Console.WriteLine();
        Console.WriteLine("Задача 1.3 — Имя");
        Console.WriteLine();

        string surname = v.ReadStringUntilValid("Введите фамилию (обязательно): ");
        string personalName = v.ReadStringUntilValid("Введите личное имя (обязательно): ");
        v.TryReadOptionalString("Введите отчество (Enter — если нет): ", out string patronymic);

        Name n = new Name(surname, personalName, patronymic);

        Console.WriteLine();
        Console.WriteLine("Результат: " + n);
        //

        //задача 4.5: порядок (имя, фамилия, отчество)
        // Console.WriteLine();
        // Console.WriteLine("Задача 4.5 — Имя");
        // Console.WriteLine();
        
        // string personalName = v.ReadStringUntilValid("Введите личное имя (обязательно): ");
        // v.TryReadOptionalString("Введите фамилию (Enter - если нет): ", out string surname);
        // v.TryReadOptionalString("Введите отчество (Enter - если нет): ", out string patronymic);
        
        // Name n;
        // if (surname != null && patronymic != null)
        // {
        //     n = new Name(personalName, surname, patronymic);
        // }
        // else if (surname != null)
        // {
        //     n = new Name(personalName, surname);
        // }
        // else
        // {
        //     n = new Name(personalName);
        // }
        
        // Console.WriteLine();
        // Console.WriteLine("Результат: " + n);
        //
    }

    private void RunHouse(Validator v)
    {
        Console.WriteLine();
        Console.WriteLine("Задача 1.5 — Дом");
        Console.WriteLine();

        int floors = v.ReadPositiveIntUntilValid("Введите количество этажей: ");

        House h = new House(floors);
        Console.WriteLine();
        Console.WriteLine("Результат: " + h);
    }

    //  ЗАДАНИЕ 2.4 / 3.4 - СОТРУДНИКИ И ОТДЕЛЫ
    //  Сейчас работает 2.4 (без списка сотрудников)
    //  Для 3.4 - поменять комментарии в Employee.cs
    //  и в методе RunDepartment ниже

    private void RunDepartment(Validator v)
    {
        Console.WriteLine();
        // Console.WriteLine("Задача 2.4 — Сотрудники и отделы");
        Console.WriteLine("Задача 3.4 — Сотрудники и отделы");
        Console.WriteLine();

        string deptName = v.ReadStringUntilValid("Введите название отдела: ");
        Department dept = new Department(deptName);

        string name1 = v.ReadStringUntilValid("Имя сотрудника 1: ");
        Employee e1 = new Employee(name1, dept);

        string name2 = v.ReadStringUntilValid("Имя сотрудника 2: ");
        Employee e2 = new Employee(name2, dept);

        string name3 = v.ReadStringUntilValid("Имя сотрудника 3: ");
        Employee e3 = new Employee(name3, dept);

        Console.WriteLine();
        Console.WriteLine("Сотрудники:");
        Console.WriteLine("1 — " + e1.Name);
        Console.WriteLine("2 — " + e2.Name);
        Console.WriteLine("3 — " + e3.Name);

        int bossNum = v.ReadIntInRange("Кто из сотрудников — начальник? (1, 2 или 3): ", 1, 3);

        if (bossNum == 1)      dept.Boss = e1;
        else if (bossNum == 2) dept.Boss = e2;
        else                   dept.Boss = e3;

        Console.WriteLine();
        Console.WriteLine(e1);
        Console.WriteLine(e2);
        Console.WriteLine(e3);

        //задача 3.4: список сотрудников отдела
        Console.WriteLine();
        Console.WriteLine("Сотрудники отдела " + dept.Name + ":");
        Employee[] all = dept.GetEmployees();
        for (int i = 0; i < all.Length; i++)
        {
            Console.WriteLine(all[i].Name);
        }
        //
    }


    private void RunFraction(Validator v)
    {
        Console.WriteLine();
        Console.WriteLine("Задача 5.5 — Дроби");
        Console.WriteLine();

        int n1 = v.ReadIntUntilValid("Введите числитель первой дроби: ");
        int d1 = v.ReadNonZeroIntUntilValid("Введите знаменатель первой дроби: ");

        int n2 = v.ReadIntUntilValid("Введите числитель второй дроби: ");
        int d2 = v.ReadNonZeroIntUntilValid("Введите знаменатель второй дроби: ");

        Fraction f1 = new Fraction(n1, d1);
        Fraction f2 = new Fraction(n2, d2);

        Console.WriteLine();
        Console.WriteLine(f1 + " + " + f2 + " = " + f1.sum(f2));
        Console.WriteLine(f1 + " - " + f2 + " = " + f1.minus(f2));
        Console.WriteLine(f1 + " * " + f2 + " = " + f1.mul(f2));
        Console.WriteLine(f1 + " / " + f2 + " = " + f1.div(f2));
    }
}