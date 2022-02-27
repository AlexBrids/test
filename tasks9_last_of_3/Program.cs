// Показать последнюю цифру трёхзначного числа

Console.Clear();

int GetLastDigit(int number)
{
    return number % 10;
}

int GetIntegerFormConsole(int min, int max)
{
    int result = 0;
    bool isError = true;
    while(isError)
    {
        Console.Write($"Введите целое число от {min} до {max}: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out result)) isError = result < min || result > max;      
    }
    return result;
}

int number = GetIntegerFormConsole(100, 999);
int finish = GetLastDigit(number);
Console.WriteLine(finish);