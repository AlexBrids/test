// По заданному номеру дня недели вывести его название

Console.Clear();
Console.WriteLine("Введите число: ");

string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

    if (number == 1)
    {
        Console.WriteLine("The first day of the week is Monday");
    }

    if (number == 2)
    {
        Console.WriteLine("The second day of the week is Tuesday");
    }
    
    if (number == 3)
    {
        Console.WriteLine("The third day of the week is Wednesday");
    }
    if (number == 4)
    {
        Console.WriteLine("The forth day os the week is Thursday");
    }
    if (number == 5)
    {
        Console.WriteLine("The firth day of the week is Friday");
    }
    if (number == 6)
    {
        Console.WriteLine("The sixth day of the week is Saturday");
    }
    if (number == 7)
    {
        Console.WriteLine("The seventh day of the week is Sunday");
    }

