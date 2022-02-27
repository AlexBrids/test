// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Clear();

int GetMumber ()
{
    int randomNumber = new Random().Next(1, 50);
    return randomNumber;
}

int number = GetMumber();
Console.WriteLine($"Случайное число: {number}");

Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();
int givenNumber = int.Parse (numberStr);



void IsMultiple (int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        int result = firstNumber % secondNumber;
        if (result == 0)
        {
            Console.WriteLine("Число 1 кратно числу 2, остаток равен 0");
        }
        else
        {
            Console.WriteLine($"Число 1 не кратно числу 2, остаток при делении {result}");
        }
    }
    if (secondNumber > firstNumber)
    {
        int result = secondNumber % firstNumber;
        if (result == 0)
        {
            Console.WriteLine("Число 2 кратно числу 1, остаток равен 0");
        }
        else
        {
            Console.WriteLine($"Число 2 не кратно числу 1, остаток при делении {result}");
        }
    }
}


IsMultiple(number, givenNumber);