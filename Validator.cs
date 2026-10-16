class Validator
{
    public bool TryReadInt(string prompt, out int value)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        return int.TryParse(input, out value);
    }

    public bool TryReadString(string prompt, out string value)
    {
        Console.Write(prompt);
        value = Console.ReadLine();
        return !string.IsNullOrWhiteSpace(value);
    }

    public bool TryReadOptionalString(string prompt, out string value)
    {
        Console.Write(prompt);
        value = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(value))
        {
            value = null;
        }
        return true;
    }

    public bool IsPositive(int x)
    {
        return x > 0;
    }

    // ==== Методы с повторным вводом ====

    public int ReadIntUntilValid(string prompt)
    {
        int value;
        while (true)
        {
            if (TryReadInt(prompt, out value))
            {
                return value;
            }
            Console.WriteLine("Введено не число. Попробуйте ещё раз.");
        }
    }

    public int ReadPositiveIntUntilValid(string prompt)
    {
        int value;
        while (true)
        {
            if (!TryReadInt(prompt, out value))
            {
                Console.WriteLine("Введено не число. Попробуйте ещё раз.");
                continue;
            }
            if (!IsPositive(value))
            {
                Console.WriteLine("Значение должно быть больше нуля. Попробуйте ещё раз.");
                continue;
            }
            return value;
        }
    }

    public int ReadNonZeroIntUntilValid(string prompt)
    {
        int value;
        while (true)
        {
            if (!TryReadInt(prompt, out value))
            {
                Console.WriteLine("Введено не число. Попробуйте ещё раз.");
                continue;
            }
            if (value == 0)
            {
                Console.WriteLine("Значение не может быть нулём. Попробуйте ещё раз.");
                continue;
            }
            return value;
        }
    }

    public string ReadStringUntilValid(string prompt)
    {
        string value;
        while (true)
        {
            if (TryReadString(prompt, out value))
            {
                return value;
            }
            Console.WriteLine("Значение не может быть пустым. Попробуйте ещё раз.");
        }
    }

    public int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        while (true)
        {
            if (!TryReadInt(prompt, out value))
            {
                Console.WriteLine("Введено не число. Попробуйте ещё раз.");
                continue;
            }
            if (value < min || value > max)
            {
                Console.WriteLine("Значение должно быть от " + min + " до " + max + ". Попробуйте ещё раз.");
                continue;
            }
            return value;
        }
    }
}